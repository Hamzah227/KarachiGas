using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Karachi_Gas.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Setup
{
    public partial class Accounts : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public Accounts()
        {
            InitializeComponent();
        }
        int selectedAccCode;
        DataTable dt1 = new DataTable();
        int userID;
        ClsAccounts Acc = new ClsAccounts();
        RadioButton[] rbarray;
        RadioButton[] rbarray1;

        private void Accounts_Load(object sender, EventArgs e)
        {
            userID = UserAuthentication.ReturnUserID();
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            //txtAccCode.Text = GetAccCode().ToString();
            this.ActiveControl = txtAccTitle;
            LoadAccounts();
            rbarray = new RadioButton[3] { radioParty, radioCompany, rbOwn };
            rbarray1 = new RadioButton[5] { radioAssets, radioIncome, radioLiabilities, radioExpense, radioCapital };
        }

        enum AccountType
        {
            Company = 1,
            Party = 2,
            Own = 3
        }

        enum AccountNature
        {
            Asset = 1,
            Income = 2,
            Liabilities = 3,
            Expense = 4,
            Capital = 5
        }
       

        public void Reset()
        { }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ClearAll()
        {
            txtAccCode.Text = "";
            txtAccOpening.Text = "";
            txtAccTitle.Text = "";
            radioAssets.Checked = false;
            radioCapital.Checked = false;
            radioExpense.Checked = false;
            radioIncome.Checked = false;
            radioParty.Checked = false;
            radioCompany.Checked = false;
            radioLiabilities.Checked = false;
            //txtAccCode.Text = GetAccCode().ToString();
            this.ActiveControl = txtAccTitle;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearAll();
        }

        public void SaveData()
        {
            double accOpening = DataHelper.DoubleParse(txtAccOpening.Text);
            int accNature = 0, accType = 0;
            //AccType
            if (radioParty.Checked)
            { accType = (int)AccountType.Party; }
            if (radioCompany.Checked)
            { accType = (int)AccountType.Company; }
            if (rbOwn.Checked)
            {
                accType = (int)AccountType.Own;
            }
            //AccNature
            if (radioAssets.Checked)
            { accNature = (int)AccountNature.Asset; }
            if (radioCapital.Checked)
            { accNature = (int)AccountNature.Capital; }
            if (radioExpense.Checked)
            { accNature = (int)AccountNature.Expense; }
            if (radioIncome.Checked)
            { accNature = (int)AccountNature.Income; }
            if (radioLiabilities.Checked)
            { accNature = (int)AccountNature.Liabilities; }


            if (txtAccTitle.Text != "" && txtAccOpening.Text != "")
            {
                if (radioParty.Checked || radioCompany.Checked || rbOwn.Checked)
                {
                    if (radioExpense.Checked || radioIncome.Checked || radioLiabilities.Checked || radioCapital.Checked || radioAssets.Checked)
                    {
                        Acc.SaveAccounts(txtAccTitle.Text, accOpening, accType, accNature);
                    }
                }
            }
            else
            {
                Acc.SaveAccounts(txtAccTitle.Text, accOpening, accType, accNature);
                this.Close();
            }
        }

        public void UpdateData()
        {
            int accCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, AccountCode));
            double accOpening = DataHelper.DoubleParse(txtAccOpening.Text);
            int accNature = 0, accType = 0;
            //AccType
            if (radioParty.Checked)
            { accType = (int)AccountType.Company; }
            if (radioCompany.Checked)
            { accType = (int)AccountType.Party; }
            if (rbOwn.Checked)
            {
                accType = (int)AccountType.Own;
            }
            //AccNature
            if (radioAssets.Checked)
            { accNature = (int)AccountNature.Asset; }
            if (radioCapital.Checked)
            { accNature = (int)AccountNature.Capital; }
            if (radioExpense.Checked)
            { accNature = (int)AccountNature.Expense; }
            if (radioIncome.Checked)
            { accNature = (int)AccountNature.Income; }
            if (radioLiabilities.Checked)
            { accNature = (int)AccountNature.Liabilities; }

            Acc.UpdateAccounts(accCode, txtAccTitle.Text, accOpening, accType, accNature);
            gridAccounts.DataSource = GetAccounts(0);

        }

        public void DeleteData()
        {
            //selectedAccCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, AccountCode));
            //Acc.DeleteAccounts(selectedAccCode);
        }

        private DataTable GetAccounts(int AccCode)
        {
            return Acc.GetAccounts(AccCode);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            gridAccounts.DataSource = GetAccounts(0);
        }

        void GetFromGrid(int accCode)
        {
            selectedAccCode = accCode;
            dt1 = GetAccounts(selectedAccCode);

            txtAccCode.Text = dt1.Rows[0]["AccID"].ToString();
            txtAccOpening.Text = dt1.Rows[0]["OpeningBalance"].ToString();
            txtAccTitle.Text = dt1.Rows[0]["Title"].ToString();
            int accType = DataHelper.intParse(dt1.Rows[0]["Type_"]);
            int accNature = DataHelper.intParse(dt1.Rows[0]["Nature"]);
            foreach (AccountType Type in Enum.GetValues(typeof(AccountType)))
            {
                if (accType == (int)Type)
                {
                    for (int i = 0; i < rbarray.Length; i++)
                    {
                        if (rbarray[i].Text == Type.ToString())
                        {
                            rbarray[i].Checked = true;
                        }
                    }
                }
            }
            foreach (AccountNature nature in Enum.GetValues(typeof(AccountNature)))
            {
                if (accNature == (int)nature)
                {
                    for (int i = 0; i < rbarray1.Length; i++)
                    {
                        if (rbarray1[i].Text == nature.ToString())
                        {
                            rbarray1[i].Checked = true;
                        }
                    }
                }
            }
        }

        void GetFromGrid()
        {
            selectedAccCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, AccountCode));
            dt1 = GetAccounts(selectedAccCode);

            txtAccCode.Text = dt1.Rows[0]["AccID"].ToString();
            txtAccOpening.Text = dt1.Rows[0]["OpeningBalance"].ToString();
            txtAccTitle.Text = dt1.Rows[0]["Title"].ToString();
            int accType = DataHelper.intParse(dt1.Rows[0]["Type_"]);
            foreach (AccountType Type in Enum.GetValues(typeof(AccountType)))
            {
                if (accType == (int)Type)
                {
                    for (int i = 0; i < rbarray.Length; i++)
                    {
                        if (rbarray[i].Text == Type.ToString())
                        {
                            rbarray[i].Checked = true;
                        }
                    }
                }
            }
        }
        private void gridAccounts_Click(object sender, EventArgs e)
        {
            GetFromGrid();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
        }

        private void LoadAccounts()
        {
            gridAccounts.DataSource = GetAccounts(0);
        }

        private void gridAccounts_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.FocusedView as GridView;
            bool shouldSelectRow = false;
            BeginInvoke(new Action(() =>
            {

                var AccCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, AccountCode));
                GetFromGrid(AccCode);
                if (shouldSelectRow)
                    view.SelectRow(view.FocusedRowHandle);
            }));
        }

        private void txtAccTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAccOpening_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '-'))
            {
                e.Handled = true;
            }
        }
    }
}