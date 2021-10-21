namespace Karachi_Gas.Setup
{
    partial class Party
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
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClearAll = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNtn = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCnic = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParty = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartyID = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCnic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiUpdate,
            this.bbiDelete,
            this.bbiClearAll,
            this.bbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(855, 146);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.save;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 2;
            this.bbiSaveAndClose.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.saveandclose;
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiUpdate
            // 
            this.bbiUpdate.Caption = "Update";
            this.bbiUpdate.Id = 3;
            this.bbiUpdate.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.actions_reload;
            this.bbiUpdate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.bbiUpdate.Name = "bbiUpdate";
            this.bbiUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUpdate_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 4;
            this.bbiDelete.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.del;
            this.bbiDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiClearAll
            // 
            this.bbiClearAll.Caption = "Reset";
            this.bbiClearAll.Id = 5;
            this.bbiClearAll.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.resetview;
            this.bbiClearAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.bbiClearAll.Name = "bbiClearAll";
            this.bbiClearAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClearAll_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 6;
            this.bbiClose.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.clearheaderandfooter2;
            this.bbiClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClearAll);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtNtn);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtCnic);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtMobile);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtPhone);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtParty);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtPartyID);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(831, 128);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "INFORMATION";
            // 
            // txtNtn
            // 
            this.txtNtn.Location = new System.Drawing.Point(399, 101);
            this.txtNtn.MenuManager = this.ribbonControl1;
            this.txtNtn.Name = "txtNtn";
            this.txtNtn.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNtn.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtNtn.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtNtn.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNtn.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtNtn.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtNtn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNtn.Size = new System.Drawing.Size(170, 20);
            this.txtNtn.TabIndex = 7;
            this.txtNtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNtn_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "NTN";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(73, 49);
            this.lookUpEdit1.MenuManager = this.ribbonControl1;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lookUpEdit1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.lookUpEdit1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.lookUpEdit1.Properties.AppearanceFocused.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Select Account";
            this.lookUpEdit1.Size = new System.Drawing.Size(221, 20);
            this.lookUpEdit1.TabIndex = 1;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Account";
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(399, 75);
            this.txtCnic.MenuManager = this.ribbonControl1;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCnic.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtCnic.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtCnic.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCnic.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtCnic.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtCnic.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCnic.Size = new System.Drawing.Size(170, 20);
            this.txtCnic.TabIndex = 6;
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnic_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CNIC";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(399, 49);
            this.txtMobile.MenuManager = this.ribbonControl1;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMobile.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtMobile.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtMobile.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMobile.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtMobile.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMobile.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMobile.Size = new System.Drawing.Size(170, 20);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mobile";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(399, 23);
            this.txtPhone.MenuManager = this.ribbonControl1;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPhone.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtPhone.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPhone.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtPhone.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPhone.Size = new System.Drawing.Size(170, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(73, 101);
            this.txtAddress.MenuManager = this.ribbonControl1;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAddress.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtAddress.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAddress.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtAddress.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAddress.Size = new System.Drawing.Size(221, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtParty
            // 
            this.txtParty.Location = new System.Drawing.Point(73, 75);
            this.txtParty.MenuManager = this.ribbonControl1;
            this.txtParty.Name = "txtParty";
            this.txtParty.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtParty.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtParty.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtParty.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtParty.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtParty.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtParty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtParty.Size = new System.Drawing.Size(221, 20);
            this.txtParty.TabIndex = 2;
            this.txtParty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Party";
            // 
            // txtPartyID
            // 
            this.txtPartyID.Enabled = false;
            this.txtPartyID.Location = new System.Drawing.Point(73, 23);
            this.txtPartyID.MenuManager = this.ribbonControl1;
            this.txtPartyID.Name = "txtPartyID";
            this.txtPartyID.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPartyID.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtPartyID.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtPartyID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartyID.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtPartyID.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtPartyID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPartyID.Size = new System.Drawing.Size(100, 20);
            this.txtPartyID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party ID";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 286);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(831, 189);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "ALL PARTY";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(827, 166);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartyID,
            this.colPartyName,
            this.colPartyAddress,
            this.colPartyPhone,
            this.colPartyMobile,
            this.colCnic,
            this.colNtn,
            this.colCreatedOn,
            this.colAccount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPartyID
            // 
            this.colPartyID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPartyID.AppearanceHeader.Options.UseFont = true;
            this.colPartyID.Caption = "Party ID";
            this.colPartyID.FieldName = "ID";
            this.colPartyID.Name = "colPartyID";
            this.colPartyID.Visible = true;
            this.colPartyID.VisibleIndex = 0;
            // 
            // colPartyName
            // 
            this.colPartyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPartyName.AppearanceHeader.Options.UseFont = true;
            this.colPartyName.Caption = "Party";
            this.colPartyName.FieldName = "Name";
            this.colPartyName.Name = "colPartyName";
            this.colPartyName.Visible = true;
            this.colPartyName.VisibleIndex = 2;
            // 
            // colPartyAddress
            // 
            this.colPartyAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPartyAddress.AppearanceHeader.Options.UseFont = true;
            this.colPartyAddress.Caption = "Address";
            this.colPartyAddress.FieldName = "Address_";
            this.colPartyAddress.Name = "colPartyAddress";
            this.colPartyAddress.Visible = true;
            this.colPartyAddress.VisibleIndex = 3;
            // 
            // colPartyPhone
            // 
            this.colPartyPhone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPartyPhone.AppearanceHeader.Options.UseFont = true;
            this.colPartyPhone.Caption = "Phone";
            this.colPartyPhone.FieldName = "Phone";
            this.colPartyPhone.Name = "colPartyPhone";
            this.colPartyPhone.Visible = true;
            this.colPartyPhone.VisibleIndex = 4;
            // 
            // colPartyMobile
            // 
            this.colPartyMobile.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPartyMobile.AppearanceHeader.Options.UseFont = true;
            this.colPartyMobile.Caption = "Mobile";
            this.colPartyMobile.FieldName = "Mobile";
            this.colPartyMobile.Name = "colPartyMobile";
            this.colPartyMobile.Visible = true;
            this.colPartyMobile.VisibleIndex = 5;
            // 
            // colCnic
            // 
            this.colCnic.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCnic.AppearanceHeader.Options.UseFont = true;
            this.colCnic.Caption = "CNIC";
            this.colCnic.FieldName = "Cnic";
            this.colCnic.Name = "colCnic";
            this.colCnic.Visible = true;
            this.colCnic.VisibleIndex = 6;
            // 
            // colNtn
            // 
            this.colNtn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNtn.AppearanceHeader.Options.UseFont = true;
            this.colNtn.Caption = "NTN";
            this.colNtn.FieldName = "Ntn";
            this.colNtn.Name = "colNtn";
            this.colNtn.Visible = true;
            this.colNtn.VisibleIndex = 7;
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCreatedOn.AppearanceHeader.Options.UseFont = true;
            this.colCreatedOn.Caption = "Created On";
            this.colCreatedOn.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colCreatedOn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreatedOn.FieldName = "DTStamp";
            this.colCreatedOn.Name = "colCreatedOn";
            this.colCreatedOn.Visible = true;
            this.colCreatedOn.VisibleIndex = 8;
            // 
            // colAccount
            // 
            this.colAccount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAccount.AppearanceHeader.Options.UseFont = true;
            this.colAccount.Caption = "Account Code";
            this.colAccount.FieldName = "AccID";
            this.colAccount.Name = "colAccount";
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 1;
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 487);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Party";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Party";
            this.Load += new System.EventHandler(this.Party_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiUpdate;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClearAll;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCnic;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtParty;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPartyID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyID;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colCnic;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtNtn;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Columns.GridColumn colNtn;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
    }
}