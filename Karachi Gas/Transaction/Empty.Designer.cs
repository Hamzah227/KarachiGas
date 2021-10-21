namespace Karachi_Gas.Transaction
{
    partial class Empty
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddnew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpParty = new DevExpress.XtraEditors.LookUpEdit();
            this.txtqtySmall = new DevExpress.XtraEditors.TextEdit();
            this.txtqtyDom = new DevExpress.XtraEditors.TextEdit();
            this.txtqtyCommercial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyCom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyDom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtySmall = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpParty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtySmall.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtyDom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtyCommercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(936, 146);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.save1;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save And Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.saveandclose;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Update";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.actions_reload;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Delete";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.delete;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Reset";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.resetview;
            this.barButtonItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Close";
            this.barButtonItem6.Id = 6;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lookUpCompany);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(12, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(912, 63);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "INFORMATION";
            // 
            // lookUpCompany
            // 
            this.lookUpCompany.Location = new System.Drawing.Point(78, 28);
            this.lookUpCompany.MenuManager = this.ribbonControl1;
            this.lookUpCompany.Name = "lookUpCompany";
            this.lookUpCompany.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lookUpCompany.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.lookUpCompany.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lookUpCompany.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lookUpCompany.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.lookUpCompany.Properties.AppearanceFocused.Options.UseFont = true;
            this.lookUpCompany.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpCompany.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCompany.Properties.NullText = "Select Company";
            this.lookUpCompany.Size = new System.Drawing.Size(137, 20);
            this.lookUpCompany.TabIndex = 1;
            this.lookUpCompany.EditValueChanged += new System.EventHandler(this.lookUpCompany_EditValueChanged);
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(309, 28);
            this.date.MenuManager = this.ribbonControl1;
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date.Size = new System.Drawing.Size(136, 20);
            this.date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnAddnew);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.lookUpParty);
            this.groupControl2.Controls.Add(this.txtqtySmall);
            this.groupControl2.Controls.Add(this.txtqtyDom);
            this.groupControl2.Controls.Add(this.txtqtyCommercial);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 221);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(912, 228);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Data List";
            // 
            // btnAddnew
            // 
            this.btnAddnew.Appearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddnew.Appearance.Options.UseBorderColor = true;
            this.btnAddnew.Location = new System.Drawing.Point(798, 22);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(99, 23);
            this.btnAddnew.TabIndex = 7;
            this.btnAddnew.Text = "Add";
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(617, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Qty Small";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 27);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "Party";
            // 
            // lookUpParty
            // 
            this.lookUpParty.Location = new System.Drawing.Point(78, 24);
            this.lookUpParty.MenuManager = this.ribbonControl1;
            this.lookUpParty.Name = "lookUpParty";
            this.lookUpParty.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lookUpParty.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.lookUpParty.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lookUpParty.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lookUpParty.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.lookUpParty.Properties.AppearanceFocused.Options.UseFont = true;
            this.lookUpParty.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpParty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpParty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpParty.Properties.NullText = "Select Party";
            this.lookUpParty.Size = new System.Drawing.Size(137, 20);
            this.lookUpParty.TabIndex = 3;
            this.lookUpParty.EditValueChanged += new System.EventHandler(this.lookUpParty_EditValueChanged);
            // 
            // txtqtySmall
            // 
            this.txtqtySmall.Location = new System.Drawing.Point(671, 24);
            this.txtqtySmall.MenuManager = this.ribbonControl1;
            this.txtqtySmall.Name = "txtqtySmall";
            this.txtqtySmall.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtqtySmall.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtqtySmall.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtqtySmall.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtqtySmall.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtqtySmall.Size = new System.Drawing.Size(100, 20);
            this.txtqtySmall.TabIndex = 6;
            this.txtqtySmall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtyCommercial_KeyPress);
            // 
            // txtqtyDom
            // 
            this.txtqtyDom.Location = new System.Drawing.Point(499, 24);
            this.txtqtyDom.MenuManager = this.ribbonControl1;
            this.txtqtyDom.Name = "txtqtyDom";
            this.txtqtyDom.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtqtyDom.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtqtyDom.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtqtyDom.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtqtyDom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtqtyDom.Size = new System.Drawing.Size(100, 20);
            this.txtqtyDom.TabIndex = 5;
            this.txtqtyDom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtyCommercial_KeyPress);
            // 
            // txtqtyCommercial
            // 
            this.txtqtyCommercial.Location = new System.Drawing.Point(309, 24);
            this.txtqtyCommercial.MenuManager = this.ribbonControl1;
            this.txtqtyCommercial.Name = "txtqtyCommercial";
            this.txtqtyCommercial.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtqtyCommercial.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtqtyCommercial.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtqtyCommercial.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtqtyCommercial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtqtyCommercial.Size = new System.Drawing.Size(100, 20);
            this.txtqtyCommercial.TabIndex = 4;
            this.txtqtyCommercial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtyCommercial_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(429, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 13);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Qty Domestic";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(233, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "Qty Commecial";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(5, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(902, 172);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartyId,
            this.colPartyName,
            this.colQtyCom,
            this.colQtyDom,
            this.colQtySmall,
            this.colID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPartyId
            // 
            this.colPartyId.Caption = "Party ID";
            this.colPartyId.FieldName = "partyID";
            this.colPartyId.Name = "colPartyId";
            this.colPartyId.Visible = true;
            this.colPartyId.VisibleIndex = 0;
            // 
            // colPartyName
            // 
            this.colPartyName.Caption = "Party Name";
            this.colPartyName.FieldName = "partyName";
            this.colPartyName.Name = "colPartyName";
            this.colPartyName.Visible = true;
            this.colPartyName.VisibleIndex = 1;
            // 
            // colQtyCom
            // 
            this.colQtyCom.Caption = "Qty Commercial";
            this.colQtyCom.FieldName = "qtyCom";
            this.colQtyCom.Name = "colQtyCom";
            this.colQtyCom.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qtyCommerical", "SUM={0:0.##}")});
            this.colQtyCom.Visible = true;
            this.colQtyCom.VisibleIndex = 2;
            // 
            // colQtyDom
            // 
            this.colQtyDom.Caption = "Qty Domestic";
            this.colQtyDom.FieldName = "qtyDom";
            this.colQtyDom.Name = "colQtyDom";
            this.colQtyDom.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qtyDomestic", "SUM={0:0.##}")});
            this.colQtyDom.Visible = true;
            this.colQtyDom.VisibleIndex = 3;
            // 
            // colQtySmall
            // 
            this.colQtySmall.Caption = "Qty Small";
            this.colQtySmall.FieldName = "qtySmall";
            this.colQtySmall.Name = "colQtySmall";
            this.colQtySmall.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qtySmall", "SUM={0:0.##}")});
            this.colQtySmall.Visible = true;
            this.colQtySmall.VisibleIndex = 4;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "AutoID";
            this.colID.Name = "colID";
            // 
            // Empty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 480);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Empty";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Empty";
            this.Load += new System.EventHandler(this.Empty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpParty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtySmall.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtyDom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtyCommercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lookUpCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyName;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyCom;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyDom;
        private DevExpress.XtraGrid.Columns.GridColumn colQtySmall;
        private DevExpress.XtraEditors.SimpleButton btnAddnew;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpParty;
        private DevExpress.XtraEditors.TextEdit txtqtySmall;
        private DevExpress.XtraEditors.TextEdit txtqtyDom;
        private DevExpress.XtraEditors.TextEdit txtqtyCommercial;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}