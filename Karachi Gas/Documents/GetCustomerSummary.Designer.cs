
namespace Karachi_Gas.Reports
{
    partial class GetCustomerSummary
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControlCompany = new DevExpress.XtraEditors.GroupControl();
            this.partyAll = new DevExpress.XtraEditors.CheckEdit();
            this.emptyDetails = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.compAll = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtFrom = new DevExpress.XtraEditors.DateEdit();
            this.lookUpCompany = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCompany)).BeginInit();
            this.groupControlCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.bbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(921, 143);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Generate";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.bo_document;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 2;
            this.bbiClose.ImageOptions.SvgImage = global::Karachi_Gas.Properties.Resources.clearheaderandfooter1;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // groupControlCompany
            // 
            this.groupControlCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlCompany.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControlCompany.AppearanceCaption.Options.UseFont = true;
            this.groupControlCompany.Controls.Add(this.partyAll);
            this.groupControlCompany.Controls.Add(this.emptyDetails);
            this.groupControlCompany.Controls.Add(this.labelControl4);
            this.groupControlCompany.Controls.Add(this.lookUpEdit1);
            this.groupControlCompany.Controls.Add(this.compAll);
            this.groupControlCompany.Controls.Add(this.labelControl3);
            this.groupControlCompany.Controls.Add(this.dtTo);
            this.groupControlCompany.Controls.Add(this.labelControl2);
            this.groupControlCompany.Controls.Add(this.labelControl1);
            this.groupControlCompany.Controls.Add(this.dtFrom);
            this.groupControlCompany.Controls.Add(this.lookUpCompany);
            this.groupControlCompany.Location = new System.Drawing.Point(12, 152);
            this.groupControlCompany.Name = "groupControlCompany";
            this.groupControlCompany.Size = new System.Drawing.Size(897, 145);
            this.groupControlCompany.TabIndex = 8;
            this.groupControlCompany.Text = "Range";
            this.groupControlCompany.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlCompany_Paint);
            // 
            // partyAll
            // 
            this.partyAll.Location = new System.Drawing.Point(264, 58);
            this.partyAll.MenuManager = this.ribbonControl1;
            this.partyAll.Name = "partyAll";
            this.partyAll.Properties.Caption = "All";
            this.partyAll.Size = new System.Drawing.Size(42, 19);
            this.partyAll.TabIndex = 16;
            // 
            // emptyDetails
            // 
            this.emptyDetails.Location = new System.Drawing.Point(312, 58);
            this.emptyDetails.MenuManager = this.ribbonControl1;
            this.emptyDetails.Name = "emptyDetails";
            this.emptyDetails.Properties.Caption = "Empty Details";
            this.emptyDetails.Size = new System.Drawing.Size(85, 19);
            this.emptyDetails.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Party";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(74, 57);
            this.lookUpEdit1.MenuManager = this.ribbonControl1;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Select Party";
            this.lookUpEdit1.Size = new System.Drawing.Size(173, 20);
            this.lookUpEdit1.TabIndex = 13;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // compAll
            // 
            this.compAll.Location = new System.Drawing.Point(264, 31);
            this.compAll.MenuManager = this.ribbonControl1;
            this.compAll.Name = "compAll";
            this.compAll.Properties.Caption = "All";
            this.compAll.Size = new System.Drawing.Size(75, 19);
            this.compAll.TabIndex = 12;
            this.compAll.CheckedChanged += new System.EventHandler(this.chkEditAllParty_CheckedChanged_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "To Date";
            // 
            // dtTo
            // 
            this.dtTo.EditValue = null;
            this.dtTo.Location = new System.Drawing.Point(74, 111);
            this.dtTo.MenuManager = this.ribbonControl1;
            this.dtTo.Name = "dtTo";
            this.dtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtTo.Size = new System.Drawing.Size(173, 20);
            this.dtTo.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "From Date";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Company";
            // 
            // dtFrom
            // 
            this.dtFrom.EditValue = null;
            this.dtFrom.Location = new System.Drawing.Point(74, 83);
            this.dtFrom.MenuManager = this.ribbonControl1;
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFrom.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtFrom.Size = new System.Drawing.Size(173, 20);
            this.dtFrom.TabIndex = 7;
            // 
            // lookUpCompany
            // 
            this.lookUpCompany.Location = new System.Drawing.Point(74, 31);
            this.lookUpCompany.MenuManager = this.ribbonControl1;
            this.lookUpCompany.Name = "lookUpCompany";
            this.lookUpCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCompany.Properties.NullText = "Select Company";
            this.lookUpCompany.Size = new System.Drawing.Size(173, 20);
            this.lookUpCompany.TabIndex = 6;
            this.lookUpCompany.EditValueChanged += new System.EventHandler(this.lookUpCompany_EditValueChanged);
            // 
            // GetCustomerSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 549);
            this.ControlBox = false;
            this.Controls.Add(this.groupControlCompany);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "GetCustomerSummary";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Customer Summary";
            this.Load += new System.EventHandler(this.GetCustomerSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCompany)).EndInit();
            this.groupControlCompany.ResumeLayout(false);
            this.groupControlCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompany.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.GroupControl groupControlCompany;
        private DevExpress.XtraEditors.CheckEdit compAll;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtFrom;
        private DevExpress.XtraEditors.LookUpEdit lookUpCompany;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.CheckEdit emptyDetails;
        private DevExpress.XtraEditors.CheckEdit partyAll;
    }
}