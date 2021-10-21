
namespace Karachi_Gas.Transaction
{
    partial class AddTransactions
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
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chkToCompany = new System.Windows.Forms.CheckBox();
            this.txtNarration = new DevExpress.XtraEditors.TextEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.btnAddnew = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpcredit = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpdebit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDebitAcc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditAcc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutotId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpcredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpdebit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.bbiClose,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1046, 146);
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
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 2;
            this.bbiClose.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.clearheaderandfooter;
            this.bbiClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Reset";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.actions_reload;
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.barButtonItem2.Name = "barButtonItem2";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.chkToCompany);
            this.groupControl2.Controls.Add(this.txtNarration);
            this.groupControl2.Controls.Add(this.txtAmount);
            this.groupControl2.Controls.Add(this.btnAddnew);
            this.groupControl2.Controls.Add(this.dateEdit);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.lookUpcredit);
            this.groupControl2.Controls.Add(this.lookUpdebit);
            this.groupControl2.Location = new System.Drawing.Point(12, 152);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1022, 98);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Details";
            // 
            // chkToCompany
            // 
            this.chkToCompany.AutoSize = true;
            this.chkToCompany.Location = new System.Drawing.Point(274, 20);
            this.chkToCompany.Name = "chkToCompany";
            this.chkToCompany.Size = new System.Drawing.Size(86, 17);
            this.chkToCompany.TabIndex = 13;
            this.chkToCompany.Text = "To Company";
            this.chkToCompany.UseVisualStyleBackColor = true;
            this.chkToCompany.CheckedChanged += new System.EventHandler(this.chkToCompany_CheckedChanged);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(274, 71);
            this.txtNarration.MenuManager = this.ribbonControl1;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNarration.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtNarration.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNarration.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtNarration.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNarration.Size = new System.Drawing.Size(355, 20);
            this.txtNarration.TabIndex = 4;
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(71, 71);
            this.txtAmount.MenuManager = this.ribbonControl1;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAmount.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.txtAmount.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAmount.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAmount.Size = new System.Drawing.Size(129, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Appearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddnew.Appearance.Options.UseBorderColor = true;
            this.btnAddnew.Location = new System.Drawing.Point(636, 70);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(99, 23);
            this.btnAddnew.TabIndex = 5;
            this.btnAddnew.Text = "Add";
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click_1);
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Enabled = false;
            this.dateEdit.Location = new System.Drawing.Point(71, 18);
            this.dateEdit.MenuManager = this.ribbonControl1;
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit.Size = new System.Drawing.Size(129, 20);
            this.dateEdit.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Narrration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Debit";
            // 
            // lookUpcredit
            // 
            this.lookUpcredit.Location = new System.Drawing.Point(274, 45);
            this.lookUpcredit.MenuManager = this.ribbonControl1;
            this.lookUpcredit.Name = "lookUpcredit";
            this.lookUpcredit.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lookUpcredit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.lookUpcredit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lookUpcredit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lookUpcredit.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.lookUpcredit.Properties.AppearanceFocused.Options.UseFont = true;
            this.lookUpcredit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpcredit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpcredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpcredit.Properties.NullText = "Select Credit Account";
            this.lookUpcredit.Size = new System.Drawing.Size(129, 20);
            this.lookUpcredit.TabIndex = 1;
            this.lookUpcredit.EditValueChanged += new System.EventHandler(this.lookUpcredit_EditValueChanged);
            // 
            // lookUpdebit
            // 
            this.lookUpdebit.Location = new System.Drawing.Point(71, 45);
            this.lookUpdebit.MenuManager = this.ribbonControl1;
            this.lookUpdebit.Name = "lookUpdebit";
            this.lookUpdebit.Properties.AppearanceFocused.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lookUpdebit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Green;
            this.lookUpdebit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lookUpdebit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.lookUpdebit.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.lookUpdebit.Properties.AppearanceFocused.Options.UseFont = true;
            this.lookUpdebit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpdebit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpdebit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpdebit.Properties.NullText = "Select Debit Account";
            this.lookUpdebit.Size = new System.Drawing.Size(129, 20);
            this.lookUpdebit.TabIndex = 2;
            this.lookUpdebit.EditValueChanged += new System.EventHandler(this.lookUpdebit_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 256);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1024, 246);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Details";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 223);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDebitAcc,
            this.colCreditAcc,
            this.colAmount,
            this.colNarration,
            this.colAutotId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDebitAcc
            // 
            this.colDebitAcc.Caption = "Debit Account";
            this.colDebitAcc.FieldName = "debitAcc";
            this.colDebitAcc.Name = "colDebitAcc";
            this.colDebitAcc.Visible = true;
            this.colDebitAcc.VisibleIndex = 0;
            // 
            // colCreditAcc
            // 
            this.colCreditAcc.Caption = "Credit Account";
            this.colCreditAcc.FieldName = "creditAcc";
            this.colCreditAcc.Name = "colCreditAcc";
            this.colCreditAcc.Visible = true;
            this.colCreditAcc.VisibleIndex = 1;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.FieldName = "amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colNarration
            // 
            this.colNarration.Caption = "Narration";
            this.colNarration.FieldName = "narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 3;
            // 
            // colAutotId
            // 
            this.colAutotId.Caption = "Auto ID";
            this.colAutotId.FieldName = "AutoID";
            this.colAutotId.Name = "colAutotId";
            this.colAutotId.Visible = true;
            this.colAutotId.VisibleIndex = 4;
            // 
            // AddTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 514);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "AddTransactions";
            this.Ribbon = this.ribbonControl1;
            this.Text = "AddTransactions";
            this.Load += new System.EventHandler(this.AddTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpcredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpdebit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddnew;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpcredit;
        private DevExpress.XtraEditors.LookUpEdit lookUpdebit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitAcc;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAcc;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colAutotId;
        private DevExpress.XtraEditors.TextEdit txtNarration;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private System.Windows.Forms.CheckBox chkToCompany;
    }
}