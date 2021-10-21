using DevExpress.XtraGrid;
using Karachi_Gas.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Setup
{
    public partial class Company : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public Company()
        {
            InitializeComponent();
        }

        bool isUpdate = false;
        public DataTable dt = new DataTable();
        string selectedCompID = string.Empty;
        Int64 userID = UserAuthentication.userId;
        int compID, accCode;
        clsCompany objComp = new clsCompany();
        private void Company_Load(object sender, EventArgs e)
        {
            userID = UserAuthentication.ReturnUserID();
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            gridControl1.DataSource = objComp.GetCompany(0);


            lookUpEdit1.Properties.DataSource = GetData.GetAccountsWRTAccType(1);
            lookUpEdit1.Properties.DisplayMember = "Title";
            lookUpEdit1.Properties.ValueMember = "AccID";
        }

        public DataTable GetCompany(int id)
        {
            return objComp.GetCompany(id);
        }

        public void SaveData()
        {
            objComp.SaveCompany(accCode, txtCompany.Text, txtAddress.Text, txtFax.Text, txtPhone.Text, userID);
            gridControl1.DataSource = objComp.GetCompany(0);
            Reset();
        }

        public void UpdateData()
        {
            objComp.UpdateCompany(accCode, accCode, txtCompany.Text, txtAddress.Text, txtPhone.Text, txtFax.Text);
        }

        public void DeleteData()
        {
            compID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCompId));
            objComp.DeleteCompany(compID);
            gridControl1.DataSource = objComp.GetCompany(0);
            Reset();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
            gridControl1.DataSource = objComp.GetCompany(0);
            Reset();
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DevExpress.XtraGrid.Views.Grid.GridView view = grid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
            int CompID = DataHelper.intParse(selectedCompID);
            bool shouldSelectRow = false;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                isUpdate = true;
            }
            BeginInvoke(new Action(() =>
            {
                CompID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCompId));
                GetDataFromGridToTextBox(CompID);
                if (shouldSelectRow)
                    view.SelectRow(view.FocusedRowHandle);
            }));
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            compID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCompId1));
            accCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAccount));
            GetDataFromGridToTextBox(compID);
        }

        void GetDataFromGridToTextBox(int compId)
        {
            dt = GetCompany(compId);
            txtCompany.Text = dt.Rows[0]["Name"].ToString();
            txtAddress.Text = dt.Rows[0]["Address_"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtFax.Text = dt.Rows[0]["Fax"].ToString();
            accCode = DataHelper.intParse(dt.Rows[0]["AccID"]);
            lookUpEdit1.Properties.GetDisplayText(accCode);
            lookUpEdit1.ItemIndex = lookUpEdit1.Properties.GetDataSourceRowIndex("AccID", accCode);
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            accCode = DataHelper.intParse(lookUpEdit1.EditValue);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
        }
        public void Reset()
        {
            lookUpEdit1.EditValue = null;
            txtCompany.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtFax.Text = string.Empty;
        }

        private void txtCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '-'))
            {
                e.Handled = true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
    }
}