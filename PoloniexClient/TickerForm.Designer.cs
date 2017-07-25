﻿namespace CryptoMarketClient {
    partial class TickerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                DisposeCore();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpPoloniex = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.currencyCard1 = new CryptoMarketClient.CurrencyCard();
            this.orderBookPanel = new DevExpress.XtraEditors.SidePanel();
            this.bidPanel = new DevExpress.XtraEditors.SidePanel();
            this.bidGridControl = new DevExpress.XtraGrid.GridControl();
            this.bidGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.askPanel = new DevExpress.XtraEditors.SidePanel();
            this.askGridControl = new DevExpress.XtraGrid.GridControl();
            this.askGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.tradeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tradeHistoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.orderBookPanel.SuspendLayout();
            this.bidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidGridView)).BeginInit();
            this.askPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.askGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.askGridView)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tradeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeHistoryItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpPoloniex});
            this.ribbonControl1.Size = new System.Drawing.Size(2455, 315);
            // 
            // rpPoloniex
            // 
            this.rpPoloniex.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpPoloniex.Name = "rpPoloniex";
            this.rpPoloniex.Text = "Poloniex";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel3);
            this.sidePanel1.Controls.Add(this.currencyCard1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(531, 315);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1322, 907);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.chartControl1);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(0, 241);
            this.sidePanel3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1322, 666);
            this.sidePanel3.TabIndex = 2;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.DataBindings = null;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(1322, 666);
            this.chartControl1.TabIndex = 0;
            // 
            // currencyCard1
            // 
            this.currencyCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.currencyCard1.Location = new System.Drawing.Point(0, 0);
            this.currencyCard1.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.currencyCard1.Name = "currencyCard1";
            this.currencyCard1.Size = new System.Drawing.Size(1322, 241);
            this.currencyCard1.TabIndex = 0;
            this.currencyCard1.Ticker = null;
            // 
            // orderBookPanel
            // 
            this.orderBookPanel.Controls.Add(this.bidPanel);
            this.orderBookPanel.Controls.Add(this.askPanel);
            this.orderBookPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderBookPanel.Location = new System.Drawing.Point(0, 315);
            this.orderBookPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.orderBookPanel.Name = "orderBookPanel";
            this.orderBookPanel.Size = new System.Drawing.Size(531, 907);
            this.orderBookPanel.TabIndex = 1;
            this.orderBookPanel.Text = "sidePanel2";
            this.orderBookPanel.Resize += new System.EventHandler(this.sidePanel2_Resize);
            // 
            // bidPanel
            // 
            this.bidPanel.Controls.Add(this.bidGridControl);
            this.bidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidPanel.Location = new System.Drawing.Point(0, 558);
            this.bidPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bidPanel.Name = "bidPanel";
            this.bidPanel.Size = new System.Drawing.Size(530, 349);
            this.bidPanel.TabIndex = 2;
            this.bidPanel.Text = "sidePanel5";
            // 
            // bidGridControl
            // 
            this.bidGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bidGridControl.Location = new System.Drawing.Point(0, 0);
            this.bidGridControl.MainView = this.bidGridView;
            this.bidGridControl.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bidGridControl.MenuManager = this.ribbonControl1;
            this.bidGridControl.Name = "bidGridControl";
            this.bidGridControl.Size = new System.Drawing.Size(530, 349);
            this.bidGridControl.TabIndex = 1;
            this.bidGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bidGridView});
            // 
            // bidGridView
            // 
            this.bidGridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bidGridView.Appearance.Row.Options.UseBackColor = true;
            this.bidGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bidGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.bidGridView.GridControl = this.bidGridControl;
            this.bidGridView.Name = "bidGridView";
            this.bidGridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.bidGridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.bidGridView.OptionsBehavior.Editable = false;
            this.bidGridView.OptionsDetail.EnableMasterViewMode = false;
            this.bidGridView.OptionsView.ShowColumnHeaders = false;
            this.bidGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Rate";
            this.gridColumn2.FieldName = "Value";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Amount";
            this.gridColumn3.FieldName = "Amount";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // askPanel
            // 
            this.askPanel.Controls.Add(this.askGridControl);
            this.askPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.askPanel.Location = new System.Drawing.Point(0, 0);
            this.askPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.askPanel.Name = "askPanel";
            this.askPanel.Size = new System.Drawing.Size(530, 558);
            this.askPanel.TabIndex = 1;
            this.askPanel.Text = "sidePanel4";
            // 
            // askGridControl
            // 
            this.askGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.askGridControl.Location = new System.Drawing.Point(0, 0);
            this.askGridControl.MainView = this.askGridView;
            this.askGridControl.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.askGridControl.MenuManager = this.ribbonControl1;
            this.askGridControl.Name = "askGridControl";
            this.askGridControl.Size = new System.Drawing.Size(530, 557);
            this.askGridControl.TabIndex = 0;
            this.askGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.askGridView});
            this.askGridControl.Resize += new System.EventHandler(this.askGridControl_Resize);
            // 
            // askGridView
            // 
            this.askGridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.askGridView.Appearance.Row.Options.UseBackColor = true;
            this.askGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.askGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRate,
            this.gcAmount});
            this.askGridView.GridControl = this.askGridControl;
            this.askGridView.Name = "askGridView";
            this.askGridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.askGridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.askGridView.OptionsBehavior.Editable = false;
            this.askGridView.OptionsDetail.EnableMasterViewMode = false;
            this.askGridView.OptionsView.ShowGroupPanel = false;
            this.askGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcRate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gcRate
            // 
            this.gcRate.Caption = "Rate";
            this.gcRate.FieldName = "Value";
            this.gcRate.Name = "gcRate";
            this.gcRate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gcRate.Visible = true;
            this.gcRate.VisibleIndex = 0;
            // 
            // gcAmount
            // 
            this.gcAmount.Caption = "Amount";
            this.gcAmount.FieldName = "Amount";
            this.gcAmount.Name = "gcAmount";
            this.gcAmount.Visible = true;
            this.gcAmount.VisibleIndex = 1;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.tradeGridControl);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(1853, 315);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(602, 907);
            this.sidePanel2.TabIndex = 3;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // tradeGridControl
            // 
            this.tradeGridControl.DataSource = this.tradeHistoryItemBindingSource;
            this.tradeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tradeGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tradeGridControl.Location = new System.Drawing.Point(1, 0);
            this.tradeGridControl.MainView = this.gridView1;
            this.tradeGridControl.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tradeGridControl.MenuManager = this.ribbonControl1;
            this.tradeGridControl.Name = "tradeGridControl";
            this.tradeGridControl.Size = new System.Drawing.Size(601, 907);
            this.tradeGridControl.TabIndex = 0;
            this.tradeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTime,
            this.colAmount,
            this.colRate,
            this.colTotal,
            this.colFill,
            this.colType,
            this.colId});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colType;
            gridFormatRule1.Name = "FormatRulesTradeBuy";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = TradeType.Buy;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colType;
            gridFormatRule2.Name = "FormatRulesTradeSell";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = TradeType.Sell;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.Column = this.colFill;
            gridFormatRule3.ColumnApplyTo = this.colAmount;
            gridFormatRule3.Name = "FormatRulesFillType";
            formatConditionIconSet1.CategoryName = "Ratings";
            formatConditionIconSetIcon1.PredefinedName = "Stars3_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Stars3_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Stars3_3.png";
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "Stars3";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule3.Rule = formatConditionRuleIconSet1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.tradeGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // tradeHistoryItemBindingSource
            // 
            this.tradeHistoryItemBindingSource.DataSource = typeof(CryptoMarketClient.TradeHistoryItem);
            // 
            // colTime
            // 
            this.colTime.DisplayFormat.FormatString = "hh:mm:ss.fff";
            this.colTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            // 
            // colRate
            // 
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Visible = true;
            this.colRate.VisibleIndex = 2;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colFill
            // 
            this.colFill.FieldName = "Fill";
            this.colFill.Name = "colFill";
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 3;
            // 
            // TickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2455, 1222);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.orderBookPanel);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "TickerForm";
            this.Text = "CurrencyInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.orderBookPanel.ResumeLayout(false);
            this.bidPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bidGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidGridView)).EndInit();
            this.askPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.askGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.askGridView)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tradeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeHistoryItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpPoloniex;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.GridControl askGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView askGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gcRate;
        private DevExpress.XtraGrid.Columns.GridColumn gcAmount;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel orderBookPanel;
        private DevExpress.XtraEditors.SidePanel bidPanel;
        private DevExpress.XtraGrid.GridControl bidGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView bidGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SidePanel askPanel;
        private CurrencyCard currencyCard1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraGrid.GridControl tradeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tradeHistoryItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colFill;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}