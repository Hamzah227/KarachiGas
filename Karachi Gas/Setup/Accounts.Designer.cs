namespace Karachi_Gas.Setup
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rbOwn = new System.Windows.Forms.RadioButton();
            this.radioCompany = new System.Windows.Forms.RadioButton();
            this.radioParty = new System.Windows.Forms.RadioButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccOpening = new DevExpress.XtraEditors.TextEdit();
            this.txtAccTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtAccCode = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radioCapital = new System.Windows.Forms.RadioButton();
            this.radioExpense = new System.Windows.Forms.RadioButton();
            this.radioLiabilities = new System.Windows.Forms.RadioButton();
            this.radioIncome = new System.Windows.Forms.RadioButton();
            this.radioAssets = new System.Windows.Forms.RadioButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridAccounts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccOpening = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccNature = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccOpening.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(901, 146);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.save;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save And Close";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.saveandclose;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Update";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.actions_reload;
            this.barButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Delete";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.del1;
            this.barButtonItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem4.VisibleInSearchMenu = false;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Reset";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.resetview;
            this.barButtonItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Close";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.clearheaderandfooter1;
            this.barButtonItem6.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtAccOpening);
            this.groupControl1.Controls.Add(this.txtAccTitle);
            this.groupControl1.Controls.Add(this.txtAccCode);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(877, 176);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "INFORMATION";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rbOwn);
            this.panelControl2.Controls.Add(this.radioCompany);
            this.panelControl2.Controls.Add(this.radioParty);
            this.panelControl2.Location = new System.Drawing.Point(118, 106);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(185, 32);
            this.panelControl2.TabIndex = 9;
            // 
            // rbOwn
            // 
            this.rbOwn.AutoSize = true;
            this.rbOwn.Location = new System.Drawing.Point(133, 9);
            this.rbOwn.Name = "rbOwn";
            this.rbOwn.Size = new System.Drawing.Size(47, 17);
            this.rbOwn.TabIndex = 2;
            this.rbOwn.Text = "Own";
            this.rbOwn.UseVisualStyleBackColor = true;
            // 
            // radioCompany
            // 
            this.radioCompany.AutoSize = true;
            this.radioCompany.Location = new System.Drawing.Point(5, 9);
            this.radioCompany.Name = "radioCompany";
            this.radioCompany.Size = new System.Drawing.Size(70, 17);
            this.radioCompany.TabIndex = 1;
            this.radioCompany.Text = "Company";
            this.radioCompany.UseVisualStyleBackColor = true;
            // 
            // radioParty
            // 
            this.radioParty.AutoSize = true;
            this.radioParty.Location = new System.Drawing.Point(77, 9);
            this.radioParty.Name = "radioParty";
            this.radioParty.Size = new System.Drawing.Size(51, 17);
            this.radioParty.TabIndex = 0;
            this.radioParty.Text = "Party";
            this.radioParty.UseVisualStyleBackColor = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Account Type";
            // 
            // txtAccOpening
            // 
            this.txtAccOpening.Location = new System.Drawing.Point(118, 82);
            this.txtAccOpening.MenuManager = this.ribbonControl1;
            this.txtAccOpening.Name = "txtAccOpening";
            this.txtAccOpening.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAccOpening.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtAccOpening.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtAccOpening.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.txtAccOpening.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccOpening.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtAccOpening.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtAccOpening.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txtAccOpening.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAccOpening.Size = new System.Drawing.Size(185, 20);
            this.txtAccOpening.TabIndex = 7;
            this.txtAccOpening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccOpening_KeyPress);
            // 
            // txtAccTitle
            // 
            this.txtAccTitle.Location = new System.Drawing.Point(118, 56);
            this.txtAccTitle.MenuManager = this.ribbonControl1;
            this.txtAccTitle.Name = "txtAccTitle";
            this.txtAccTitle.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAccTitle.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.Transparent;
            this.txtAccTitle.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtAccTitle.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtAccTitle.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.txtAccTitle.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccTitle.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtAccTitle.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtAccTitle.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txtAccTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAccTitle.Size = new System.Drawing.Size(339, 20);
            this.txtAccTitle.TabIndex = 6;
            this.txtAccTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccTitle_KeyPress);
            // 
            // txtAccCode
            // 
            this.txtAccCode.Enabled = false;
            this.txtAccCode.Location = new System.Drawing.Point(118, 30);
            this.txtAccCode.MenuManager = this.ribbonControl1;
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Properties.ReadOnly = true;
            this.txtAccCode.Size = new System.Drawing.Size(106, 20);
            this.txtAccCode.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radioCapital);
            this.panelControl1.Controls.Add(this.radioExpense);
            this.panelControl1.Controls.Add(this.radioLiabilities);
            this.panelControl1.Controls.Add(this.radioIncome);
            this.panelControl1.Controls.Add(this.radioAssets);
            this.panelControl1.Location = new System.Drawing.Point(118, 137);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(339, 34);
            this.panelControl1.TabIndex = 4;
            // 
            // radioCapital
            // 
            this.radioCapital.AutoSize = true;
            this.radioCapital.Location = new System.Drawing.Point(279, 7);
            this.radioCapital.Name = "radioCapital";
            this.radioCapital.Size = new System.Drawing.Size(58, 17);
            this.radioCapital.TabIndex = 4;
            this.radioCapital.Text = "Capital";
            this.radioCapital.UseVisualStyleBackColor = true;
            // 
            // radioExpense
            // 
            this.radioExpense.AutoSize = true;
            this.radioExpense.Location = new System.Drawing.Point(207, 7);
            this.radioExpense.Name = "radioExpense";
            this.radioExpense.Size = new System.Drawing.Size(66, 17);
            this.radioExpense.TabIndex = 3;
            this.radioExpense.Text = "Expense";
            this.radioExpense.UseVisualStyleBackColor = true;
            // 
            // radioLiabilities
            // 
            this.radioLiabilities.AutoSize = true;
            this.radioLiabilities.Location = new System.Drawing.Point(134, 7);
            this.radioLiabilities.Name = "radioLiabilities";
            this.radioLiabilities.Size = new System.Drawing.Size(67, 17);
            this.radioLiabilities.TabIndex = 2;
            this.radioLiabilities.Text = "Liabilities";
            this.radioLiabilities.UseVisualStyleBackColor = true;
            // 
            // radioIncome
            // 
            this.radioIncome.AutoSize = true;
            this.radioIncome.Location = new System.Drawing.Point(77, 7);
            this.radioIncome.Name = "radioIncome";
            this.radioIncome.Size = new System.Drawing.Size(60, 17);
            this.radioIncome.TabIndex = 1;
            this.radioIncome.Text = "Income";
            this.radioIncome.UseVisualStyleBackColor = true;
            // 
            // radioAssets
            // 
            this.radioAssets.AutoSize = true;
            this.radioAssets.Location = new System.Drawing.Point(5, 7);
            this.radioAssets.Name = "radioAssets";
            this.radioAssets.Size = new System.Drawing.Size(57, 17);
            this.radioAssets.TabIndex = 0;
            this.radioAssets.Text = "Assets";
            this.radioAssets.UseVisualStyleBackColor = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Account Nature";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Opening";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Title";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Account Code";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridAccounts);
            this.groupControl2.Location = new System.Drawing.Point(12, 334);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(877, 203);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "ACCOUNTS";
            // 
            // gridAccounts
            // 
            this.gridAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAccounts.Location = new System.Drawing.Point(2, 21);
            this.gridAccounts.MainView = this.gridView1;
            this.gridAccounts.MenuManager = this.ribbonControl1;
            this.gridAccounts.Name = "gridAccounts";
            this.gridAccounts.Size = new System.Drawing.Size(873, 180);
            this.gridAccounts.TabIndex = 0;
            this.gridAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridAccounts.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridAccounts_ProcessGridKey);
            this.gridAccounts.Click += new System.EventHandler(this.gridAccounts_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AccountCode,
            this.AccTitle,
            this.AccOpening,
            this.AccType,
            this.colAccNature});
            this.gridView1.GridControl = this.gridAccounts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // AccountCode
            // 
            this.AccountCode.AppearanceCell.Options.UseTextOptions = true;
            this.AccountCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccountCode.AppearanceHeader.Options.UseFont = true;
            this.AccountCode.Caption = "Account Code";
            this.AccountCode.FieldName = "AccID";
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.OptionsColumn.ReadOnly = true;
            this.AccountCode.Visible = true;
            this.AccountCode.VisibleIndex = 0;
            this.AccountCode.Width = 79;
            // 
            // AccTitle
            // 
            this.AccTitle.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccTitle.AppearanceHeader.Options.UseFont = true;
            this.AccTitle.Caption = "Account Title";
            this.AccTitle.FieldName = "Title";
            this.AccTitle.Name = "AccTitle";
            this.AccTitle.OptionsColumn.ReadOnly = true;
            this.AccTitle.Visible = true;
            this.AccTitle.VisibleIndex = 1;
            this.AccTitle.Width = 231;
            // 
            // AccOpening
            // 
            this.AccOpening.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccOpening.AppearanceHeader.Options.UseFont = true;
            this.AccOpening.Caption = "Opening";
            this.AccOpening.FieldName = "OpeningBalance";
            this.AccOpening.Name = "AccOpening";
            this.AccOpening.OptionsColumn.ReadOnly = true;
            this.AccOpening.Visible = true;
            this.AccOpening.VisibleIndex = 2;
            this.AccOpening.Width = 263;
            // 
            // AccType
            // 
            this.AccType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccType.AppearanceHeader.Options.UseFont = true;
            this.AccType.Caption = "Account Type";
            this.AccType.FieldName = "Type_";
            this.AccType.Name = "AccType";
            this.AccType.OptionsColumn.ReadOnly = true;
            this.AccType.Visible = true;
            this.AccType.VisibleIndex = 3;
            this.AccType.Width = 138;
            // 
            // colAccNature
            // 
            this.colAccNature.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAccNature.AppearanceHeader.Options.UseFont = true;
            this.colAccNature.Caption = "Account Nature";
            this.colAccNature.FieldName = "Nature";
            this.colAccNature.Name = "colAccNature";
            this.colAccNature.Visible = true;
            this.colAccNature.VisibleIndex = 4;
            this.colAccNature.Width = 141;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 549);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Accounts";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccOpening.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton radioCapital;
        private System.Windows.Forms.RadioButton radioExpense;
        private System.Windows.Forms.RadioButton radioLiabilities;
        private System.Windows.Forms.RadioButton radioIncome;
        private System.Windows.Forms.RadioButton radioAssets;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAccOpening;
        private DevExpress.XtraEditors.TextEdit txtAccTitle;
        private DevExpress.XtraEditors.TextEdit txtAccCode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridAccounts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn AccTitle;
        private DevExpress.XtraGrid.Columns.GridColumn AccOpening;
        private DevExpress.XtraGrid.Columns.GridColumn AccType;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RadioButton radioCompany;
        private System.Windows.Forms.RadioButton radioParty;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colAccNature;
        private System.Windows.Forms.RadioButton rbOwn;
    }
}