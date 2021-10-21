using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Transaction
{
    public partial class AddTransactions : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public AddTransactions()
        {
            InitializeComponent();
        }

        Int64 creditAcc, debitAcc;
        bool isSaved = false;
        bool isPayToCompany = false;
        private DataTable dt = new DataTable();
        private DataTable privDt = new DataTable();
        Classes.clsTransactions transactions = new Classes.clsTransactions();
        private void AddTransactions_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            dateEdit.DateTime = DateTime.Now;
            CreateVirtualTable();
            LoadGrid();
            PopulateLookUpEdits();
            dateEdit.DateTime = DateTime.Now.Date;
        }

        public void Reset()
        {
            dateEdit.DateTime = DateTime.Now;
            dateEdit.DateTime = DateTime.Now;
            privDt.Rows.Clear();
            LoadGrid();
            PopulateLookUpEdits();
            dateEdit.DateTime = DateTime.Now.Date;
        }

        void LoadGrid()
        {
            gridControl1.DataSource = privDt;
        }

        void PopulateLookUpEdits()
        {
            dt.Clear();
            //if (!isPayToCompany)
            //{
            //    dt = Classes.GetData.GetAccountsWRTAccType(1);
            //    dt.Merge(Classes.GetData.GetAccountsWRTAccType(3));
            //}
            //else
            //{
            //    dt = Classes.GetData.GetAccountsWRTAccType(2);
            //    dt.Merge(Classes.GetData.GetAccountsWRTAccType(3));
            //}
            dt = Classes.GetData.GetAllAccounts();

            lookUpcredit.Properties.DataSource = dt;
            lookUpcredit.Properties.PopulateColumns();
            lookUpcredit.Properties.DisplayMember = "Title";
            lookUpcredit.Properties.ValueMember = "AccID";
            lookUpcredit.Properties.Columns["OpeningBalance"].Visible = false;
            lookUpcredit.Properties.Columns["Type_"].Visible = false;
            lookUpcredit.Properties.Columns["Nature"].Visible = false;
            //lookUpcredit.Properties.Columns["UserID"].Visible = false;
            lookUpcredit.Properties.Columns["DTStamp"].Visible = false;
            lookUpcredit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;

            lookUpdebit.Properties.DataSource = dt;
            lookUpdebit.Properties.PopulateColumns();
            lookUpdebit.Properties.DisplayMember = "Title";
            lookUpdebit.Properties.ValueMember = "AccID";
            lookUpdebit.Properties.Columns["OpeningBalance"].Visible = false;
            lookUpdebit.Properties.Columns["Type_"].Visible = false;
            lookUpdebit.Properties.Columns["Nature"].Visible = false;
            //lookUpdebit.Properties.Columns["UserID"].Visible = false;
            lookUpdebit.Properties.Columns["DTStamp"].Visible = false;
            lookUpdebit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        void CreateVirtualTable()
        {
            DataColumn column = new DataColumn();
            column.ColumnName = "AutoID";
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 0;
            column.AutoIncrementStep = 1;

            privDt.Columns.Add(column);
            privDt.Columns.Add("debitId", typeof(Int64));
            privDt.Columns.Add("debitAcc", typeof(string));
            privDt.Columns.Add("creditId", typeof(Int64));
            privDt.Columns.Add("creditAcc", typeof(string));
            privDt.Columns.Add("amount", typeof(decimal));
            privDt.Columns.Add("narration", typeof(string));
        }

        void AddIntoVirtualTable()
        {
            privDt.Rows.Add(null, (Int64)lookUpdebit.EditValue, lookUpdebit.Text, (Int64)lookUpcredit.EditValue, lookUpcredit.Text, Convert.ToDecimal(txtAmount.Text), txtNarration.Text);
            LoadGrid();

        }

        public void SaveData()
        {
            int error = 0;
            
            for (int i = 0; i < privDt.Rows.Count; i++)
            {
                Int64 debitId = DataHelper.intParse(privDt.Rows[i]["debitId"]);
                Int64 creditId = DataHelper.intParse(privDt.Rows[i]["creditId"]);
                decimal amount = DataHelper.intParse(privDt.Rows[i]["amount"]);
                string narration = privDt.Rows[i]["narration"].ToString();
                if (transactions.SaveTransactionNew(isPayToCompany ? debitAcc : 0, (int)TransactionTypes.TRANSFER, debitId, creditId, amount, narration, isPayToCompany ? true : false))
                {
                    continue;
                }
                else
                {
                    error++;
                    XtraMessageBox.Show("Row Number " + (i - 1) + " Not Saved!!!", "TRANSACTIONS");
                    continue;
                }
            }
            if (error == 0)
            {
                isSaved = true;
            }
            else
                isSaved = false;
        }

        private void btnAddnew_Click_1(object sender, EventArgs e)
        {
            AddIntoVirtualTable();
            lookUpcredit.EditValue = null;
            lookUpdebit.EditValue = null;
            txtAmount.Text = string.Empty;
            txtNarration.Text = string.Empty;
            lookUpcredit.Focus();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            if (isSaved)
            {
                Reset();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        enum TransactionTypes
        {
            TRANSFER = 1,
            SALE = 2,
            PURCHASE = 3,
            EMPTY = 4
        }

        private void chkToCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToCompany.Checked)
            {
                isPayToCompany = true;
                PopulateLookUpEdits();
            }
            else
            {
                isPayToCompany = false;
                PopulateLookUpEdits();
            }
        }

        public void UpdateData() { }
        public void DeleteData() { }

        private void lookUpcredit_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpcredit.EditValue != null)
            {
                creditAcc = (Int64)lookUpcredit.EditValue;
            }
            
        }

        private void lookUpdebit_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpdebit.EditValue != null)
            {
                debitAcc = (Int64)lookUpdebit.EditValue;
            }
        }
    }
}
