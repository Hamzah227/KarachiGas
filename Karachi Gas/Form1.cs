using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Karachi_Gas
{
    public partial class frm_Main : XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        XtraForm frmAccounts = null;
        XtraForm frmCompany = null;
        XtraForm frmParty = null;
        XtraForm frmPurchase = null;
        XtraForm frmPurchaseLedger = null;
        XtraForm frmSales = null;
        XtraForm frmGenerateInvoice = null;
        XtraForm frmNewUser = null;
        XtraForm frmEmptyRec = null;
        XtraForm frmGetCusSummary = null;
        XtraForm frmAddTransaction = null;
        XtraForm frmAllReports = null;
        XtraForm frmSaleDetails = null;

        public static bool isOpen = false;

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            //bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                    //FormFound = true;
                }
            }
            return false;
            //if (FormFound == false)
            //{
            //    Form2 f = new Form2();
            //    f.Show();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isOpen = true;
            XtraForm frm = new Welcome();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.BringToFront();




        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void Accounts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //isOpen = true;
            //XtraForm frm = new Setup.Accounts();
            if (frmAccounts == null || frmAccounts.Text == "")
            {
                frmAccounts = new Setup.Accounts();
                frmAccounts.MdiParent = this;
                frmAccounts.Dock = DockStyle.Fill;
                frmAccounts.Show();
                frmAccounts.BringToFront();
            }
            else if (CheckOpened(frmAccounts.Name))
            {

                frmAccounts.Show();
                frmAccounts.Dock = DockStyle.Fill;
                frmAccounts.BringToFront();
                frmAccounts.Focus();
            }
            //EnabledDisable();
        }

        public void EnabledDisable()
        {
            if (isOpen)
            {
                navBarControl1.Enabled = false;
            }
            else
            {
                navBarControl1.Enabled = true;
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmCompany == null || frmCompany.Text == "")
            {
                frmCompany = new Setup.Company();
                frmCompany.MdiParent = this;
                frmCompany.Dock = DockStyle.Fill;
                frmCompany.Show();
                frmCompany.BringToFront();
            }
            else if (CheckOpened(frmCompany.Name))
            {

                frmCompany.Show();
                frmCompany.Dock = DockStyle.Fill;
                frmCompany.BringToFront();
                frmCompany.Focus();
            }

            //XtraForm frm = new Setup.Company();
            //frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
            //frm.BringToFront();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmParty == null || frmParty.Text == "")
            {
                frmParty = new Setup.Party();
                frmParty.MdiParent = this;
                frmParty.Dock = DockStyle.Fill;
                frmParty.Show();
                frmParty.BringToFront();
            }
            else if (CheckOpened(frmAccounts.Name))
            {

                frmParty.Show();
                frmParty.Dock = DockStyle.Fill;
                frmParty.BringToFront();
                frmParty.Focus();
            }
            //XtraForm frm = new Setup.Party();
            //frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
            //frm.BringToFront();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmPurchase == null || frmPurchase.Text == "")
            {
                frmPurchase = new Transaction.Purchase();
                frmPurchase.MdiParent = this;
                frmPurchase.Dock = DockStyle.Fill;
                frmPurchase.Show();
                frmPurchase.BringToFront();
            }
            else if (CheckOpened(frmPurchase.Name))
            {

                frmPurchase.Show();
                frmPurchase.Dock = DockStyle.Fill;
                frmPurchase.BringToFront();
                frmPurchase.Focus();
            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmSales == null || frmSales.Text == "")
            {
                frmSales = new Transaction.NewSales();
                frmSales.MdiParent = this;
                frmSales.Dock = DockStyle.Fill;
                frmSales.Show();
                frmSales.BringToFront();
            }
            else if (CheckOpened(frmSales.Name))
            {

                frmSales.Show();
                frmSales.Dock = DockStyle.Fill;
                frmSales.BringToFront();
                frmSales.Focus();
            }
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmAddTransaction == null || frmAddTransaction.Text == "")
            {
                frmAddTransaction = new Transaction.AddTransactions();
                frmAddTransaction.MdiParent = this;
                frmAddTransaction.Dock = DockStyle.Fill;
                frmAddTransaction.Show();
                frmAddTransaction.BringToFront();
            }
            else if (CheckOpened(frmAddTransaction.Name))
            {

                frmAddTransaction.Show();
                frmAddTransaction.Dock = DockStyle.Fill;
                frmAddTransaction.BringToFront();
                frmAddTransaction.Focus();
            }


            //if (frmTransaction == null || frmTransaction.Text == "")
            //{
            //    frmTransaction = new Transaction.Transaction();
            //    frmTransaction.MdiParent = this;
            //    frmTransaction.Dock = DockStyle.Fill;
            //    frmTransaction.Show();
            //    frmTransaction.BringToFront();
            //}
            //else if (CheckOpened(frmTransaction.Name))
            //{

            //    frmTransaction.Show();
            //    frmTransaction.Dock = DockStyle.Fill;
            //    frmTransaction.BringToFront();
            //    frmTransaction.Focus();
            //}
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmGenerateInvoice == null || frmGenerateInvoice.Text == "")
            {
                frmGenerateInvoice = new Reports.GenerateInvoice();
                frmGenerateInvoice.MdiParent = this;
                frmGenerateInvoice.Dock = DockStyle.Fill;
                frmGenerateInvoice.Show();
                frmGenerateInvoice.BringToFront();
            }
            else if (CheckOpened(frmGenerateInvoice.Name))
            {

                frmGenerateInvoice.Show();
                frmGenerateInvoice.Dock = DockStyle.Fill;
                frmGenerateInvoice.BringToFront();
                frmGenerateInvoice.Focus();
            }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmNewUser == null || frmNewUser.Text == "")
            {
                frmNewUser = new Systematics.NewUser();
                frmNewUser.MdiParent = this;
                frmNewUser.Dock = DockStyle.Fill;
                frmNewUser.Show();
                frmNewUser.BringToFront();
            }
            else if (CheckOpened(frmNewUser.Name))
            {

                frmNewUser.Show();
                frmNewUser.Dock = DockStyle.Fill;
                frmNewUser.BringToFront();
                frmNewUser.Focus();
            }
        }

        private void flyoutPanel1_Load(object sender, EventArgs e)
        {

        }


        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.Cancel == false)
            {
                e.Cancel = true;
                flyoutPanel1.ShowPopup();

            }

        }

        private void flyoutPanel1_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            bool tag = (bool)e.Button.Tag;
            switch (tag)
            {
                case false:
                    if (isOpen)
                    {
                        this.Hide();
                        Systematics.UserLogin frmLogin = new Systematics.UserLogin();
                        frmLogin.Show();
                        this.Dispose(true);
                    }
                    break;
                case true:
                    // . . .
                    (sender as DevExpress.Utils.FlyoutPanel).HidePopup();

                    break;
            }
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //if (frmViewTransactions == null || frmViewTransactions.Text == "")
            //{
            //    frmViewTransactions = new Reports.ViewTransactions();
            //    frmViewTransactions.MdiParent = this;
            //    frmViewTransactions.Dock = DockStyle.Fill;
            //    frmViewTransactions.Show();
            //    frmViewTransactions.BringToFront();
            //}
            //else if (CheckOpened(frmViewTransactions.Name))
            //{

            //    frmViewTransactions.Show();
            //    frmViewTransactions.Dock = DockStyle.Fill;
            //    frmViewTransactions.BringToFront();
            //    frmViewTransactions.Focus();
            //}
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmEmptyRec == null || frmEmptyRec.Text == "")
            {
                frmEmptyRec = new Transaction.Empty();
                frmEmptyRec.MdiParent = this;
                frmEmptyRec.Dock = DockStyle.Fill;
                frmEmptyRec.Show();
                frmEmptyRec.BringToFront();
            }
            else if (CheckOpened(frmEmptyRec.Name))
            {

                frmEmptyRec.Show();
                frmEmptyRec.Dock = DockStyle.Fill;
                frmEmptyRec.BringToFront();
                frmEmptyRec.Focus();
            }
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmGetCusSummary == null || frmGetCusSummary.Text == "")
            {
                frmGetCusSummary = new Reports.GetCustomerSummary();
                frmGetCusSummary.MdiParent = this;
                frmGetCusSummary.Dock = DockStyle.Fill;
                frmGetCusSummary.Show();
                frmGetCusSummary.BringToFront();
            }
            else if (CheckOpened(frmGetCusSummary.Name))
            {

                frmGetCusSummary.Show();
                frmGetCusSummary.Dock = DockStyle.Fill;
                frmGetCusSummary.BringToFront();
                frmGetCusSummary.Focus();
            }
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmPurchaseLedger == null || frmPurchaseLedger.Text == "")
            {
                frmPurchaseLedger = new Documents.PurchaseLedger();
                frmPurchaseLedger.MdiParent = this;
                frmPurchaseLedger.Dock = DockStyle.Fill;
                frmPurchaseLedger.Show();
                frmPurchaseLedger.BringToFront();
            }
            else if (CheckOpened(frmSaleDetails.Name))
            {

                frmPurchaseLedger.Show();
                frmPurchaseLedger.Dock = DockStyle.Fill;
                frmPurchaseLedger.BringToFront();
                frmPurchaseLedger.Focus();
            }
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmAllReports == null || frmAllReports.Text == "")
            {
                frmAllReports = new Reports.AllReports();
                frmAllReports.MdiParent = this;
                frmAllReports.Dock = DockStyle.Fill;
                frmAllReports.Show();
                frmAllReports.BringToFront();
            }
            else if (CheckOpened(frmAllReports.Name))
            {

                frmAllReports.Show();
                frmAllReports.Dock = DockStyle.Fill;
                frmAllReports.BringToFront();
                frmAllReports.Focus();
            }
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmSaleDetails == null || frmSaleDetails.Text == "")
            {
                frmSaleDetails = new Reports.SaleDetails();
                frmSaleDetails.MdiParent = this;
                frmSaleDetails.Dock = DockStyle.Fill;
                frmSaleDetails.Show();
                frmSaleDetails.BringToFront();
            }
            else if (CheckOpened(frmSaleDetails.Name))
            {

                frmSaleDetails.Show();
                frmSaleDetails.Dock = DockStyle.Fill;
                frmSaleDetails.BringToFront();
                frmSaleDetails.Focus();
            }
        }

    }
}
