﻿using CryptoMarketClient.Binance;
using CryptoMarketClient.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMarketClient.Forms.Instruments {
    public partial class WalletInvestorDataForm : XtraForm {
        

        public WalletInvestorDataForm() {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            DownloadData();
        }

        public List<WalletInvestorDataItem> Items { get; set; }

        bool Stop { get; set; }
        private void DownloadData() {
            BinanceExchange.Default.Connect();
            PoloniexExchange.Default.Connect();

            Stop = false;
            List<WalletInvestorDataItem> list = new List<WalletInvestorDataItem>();
            this.walletInvestorDataItemBindingSource.DataSource = list;
            var handle = SplashScreenManager.ShowOverlayForm(this.gridControl);
            double percent = Convert.ToDouble(this.barEditItem1.EditValue);
            for(int i = 1; i < 1000; i++) {
                if(Stop)
                    break;
                this.siStatus.Caption = "<b>Downloading page " + i + "</b>";
                Application.DoEvents();
                WebClient wc = new WebClient();
                byte[] data = wc.DownloadData(string.Format("https://walletinvestor.com/?sort=-percent_change_24h&page={0}&per-page=100", i));
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(new MemoryStream(data));

                HtmlNode node = doc.DocumentNode.Descendants().FirstOrDefault(n => n.GetAttributeValue("class", "") == "currency-desktop-table kv-grid-table table table-hover table-bordered table-striped table-condensed kv-table-wrap");
                if(node == null)
                    return;
                HtmlNode body = node.Element("tbody");
                List<HtmlNode> rows = body.Descendants().Where(n => n.GetAttributeValue("data-key", "") != "").ToList();
                if(rows.Count == 0)
                    break;
                bool finished = false;
                foreach(HtmlNode row in rows) {
                    HtmlNode name = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "2");
                    HtmlNode prices = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "3");
                    HtmlNode change24 = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "4");
                    HtmlNode volume24 = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "5");
                    HtmlNode marketCap = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "7");

                    try {
                        WalletInvestorDataItem item = new WalletInvestorDataItem();
                        item.Name = name.Descendants().FirstOrDefault(n => n.GetAttributeValue("class", "") == "detail").InnerText.Trim();
                        item.LastPrice = Convert.ToDouble(CorrectString(prices.Element("a").InnerText));
                        item.Rise = change24.Element("a").GetAttributeValue("class", "") != "red";
                        string change = CorrectString(change24.InnerText);
                        item.Change24 = Convert.ToDouble(change);
                        if(item.Change24 < percent) {
                            finished = true;
                            break;
                        }
                        item.Volume = volume24.InnerText.Trim();
                        item.MarketCap = marketCap.Element("a").InnerText.Trim();
                        item.ListedOnBinance = BinanceExchange.Default.Tickers.FirstOrDefault(t => t.MarketCurrency == item.Name) != null;
                        item.ListedOnPoloniex = PoloniexExchange.Default.Tickers.FirstOrDefault(t => t.MarketCurrency == item.Name) != null;
                        list.Add(item);
                    }
                    catch(Exception) {
                        continue;
                    }
                }
                Items = list;
                this.gridView1.RefreshData();
                Application.DoEvents();
                if(finished)
                    break;
            }
            SplashScreenManager.CloseOverlayForm(handle);
        }

        private void biRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DownloadData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Stop = true;
        }

        protected string CorrectString(string str) {
            return str.Replace("%", "").Replace("+", "").Replace(',', '.').Trim();
        }

        protected virtual bool GetForecastFor(WalletInvestorDataItem item, WalletInvestorPortalHelper helper) {
            PortalClient wc = new PortalClient(helper.Chromium);
            
            byte[] data = wc.DownloadData(string.Format("https://walletinvestor.com/forecast?currency={0}", item.Name));
            if(data == null)
                return false;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(new MemoryStream(data));

            HtmlNode node = doc.DocumentNode.Descendants().FirstOrDefault(n => n.GetAttributeValue("class", "") == "currency-desktop-table kv-grid-table table table-hover table-bordered table-striped table-condensed");
            if(node == null)
                return false;
            HtmlNode body = node.Element("tbody");
            List<HtmlNode> rows = body.Descendants().Where(n => n.GetAttributeValue("data-key", "") != "").ToList();
            if(rows.Count == 0)
                return false;
            foreach(HtmlNode row in rows) {
                HtmlNode name = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "0");
                HtmlNode forecast14 = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "1");
                HtmlNode forecast3Month = row.Descendants().FirstOrDefault(n => n.GetAttributeValue("data-col-seq", "") == "2");

                try {
                    string nameText = name.Descendants().FirstOrDefault(n => n.GetAttributeValue("class", "") == "detail").InnerText.Trim();
                    if(item.Name != nameText)
                        continue;

                    item.Forecast14Day = Convert.ToDouble(CorrectString(forecast14.Element("a").InnerText));
                    item.Forecast3Month = Convert.ToDouble(CorrectString(forecast3Month.Element("a").InnerText));

                    Get7DayForecastFor(item, name.Element("a").GetAttributeValue("href", ""));

                    break;
                }
                catch(Exception) {
                    continue;
                }
            }
            return false;
        }

        protected virtual bool Get7DayForecastFor(WalletInvestorDataItem item, string adress) {
            WebClient wc = new WebClient();

            byte[] data = wc.DownloadData(string.Format(adress, item.Name));
            if(data == null)
                return false;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(new MemoryStream(data));

            HtmlNode node = doc.DocumentNode.Descendants().FirstOrDefault(n => n.GetAttributeValue("class", "") == "seven-day-forecast-desc");
            if(node == null)
                return false;

            string[] items = node.InnerText.Split(' ');
            if(items.Length < 2)
                return false;
            try {
                item.Forecast7Day = Convert.ToDouble(items[0].Trim());
            }
            catch(Exception) {
                return false;
            }
            return true;
        }

        private void biForecast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Stop = false;

            this.siStatus.Caption = "<b>Autorizing on walletinvestor.com</b>";
            WalletInvestorPortalHelper helper = new WalletInvestorPortalHelper();
            helper.Enter("ArsenAbazyan@gmail.com", "ejv8iU93bdBnRnG");
            if(!helper.WaitUntil(30000, () => helper.State == PortalState.AutorizationDone)) {
                XtraMessageBox.Show("Error autorizing on walletinvestor.com");
                return;
            }

            foreach(WalletInvestorDataItem item in Items) {
                this.siStatus.Caption = "<b>Update forecast for " + item.Name + "</b>";
                if(GetForecastFor(item, helper))
                    this.gridView1.RefreshRow(this.gridView1.GetRowHandle(Items.IndexOf(item)));
                Application.DoEvents();
                if(Stop)
                    break;
            }
            if(Stop)
                this.siStatus.Caption = "<b>Interrupted</b>";
            else 
                this.siStatus.Caption = "<b>Done</b>";
        }

    }

    public class WalletInvestorDataItem {
        public string Name { get; set; }
        public double LastPrice { get; set; }
        public double Change24 { get; set; }
        public bool Rise { get; set; }
        public string Volume { get; set; }
        public string MarketCap { get; set; }

        [DisplayName("Listed on Binance")]
        public bool ListedOnBinance { get; set; }
        [DisplayName("Listed on Poloniex")]
        public bool ListedOnPoloniex { get; set; }

        [DisplayName("7 Day Forecast")]
        public double Forecast7Day { get; set; }

        [DisplayName("14 Day Forecast")]
        public double Forecast14Day { get; set; }

        [DisplayName("3 Month Forecast")]
        public double Forecast3Month { get; set; }
    }
}
