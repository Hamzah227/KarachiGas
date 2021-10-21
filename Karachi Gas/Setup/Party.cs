using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Karachi_Gas.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Setup
{
    public partial class Party : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public Party()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        bool saveAndClose = false;
        bool isUpdate = false;
        string selectedPartyID;
        int userID, partyID, accCode;
        clsParty objParty = new clsParty();
        private void Party_Load(object sender, EventArgs e)
        {
            userID = UserAuthentication.ReturnUserID();
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            gridControl1.DataSource = objParty.GetParty(0);

            lookUpEdit1.Properties.DataSource = GetData.GetAccountsWRTAccType(2);
            lookUpEdit1.Properties.ValueMember = "AccID";
            lookUpEdit1.Properties.DisplayMember = "Title";
        }

        private DataTable GetParty(int id)
        {
            return objParty.GetParty(id);
        }

        public void DeleteData()
        {
            partyID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPartyID));
            objParty.DeleteParty(partyID);
            gridControl1.DataSource = objParty.GetParty(0);
        }

        public void SaveData()
        {
            objParty.SaveParty(accCode, txtParty.Text, txtAddress.Text, txtPhone.Text, txtMobile.Text, txtCnic.Text, txtNtn.Text);
            gridControl1.DataSource = objParty.GetParty(0);
            ClearAll();
        }

        public void UpdateData()
        {
            objParty.UpdateParty(DataHelper.intParse(txtPartyID.Text), accCode, txtParty.Text, txtAddress.Text, txtPhone.Text, txtMobile.Text, txtCnic.Text, txtNtn.Text);
            gridControl1.DataSource = objParty.GetParty(0);
            ClearAll();
        }

        public void Reset()
        { 
        }

        private void ClearAll()
        {
            lookUpEdit1.EditValue = null;
            txtPartyID.Text = "";
            txtParty.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtMobile.Text = "";
            txtCnic.Text = "";
            txtNtn.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveAndClose = true;
            SaveData();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
        }

        private void bbiClearAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearAll();
        }

        private void bbiUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
        }

        private void FillTextBoxes()
        {
            isUpdate = true;
            int partyID = DataHelper.intParse(selectedPartyID);
            partyID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPartyID));

            //DataTable dt = new DataTable();
            dt = GetParty(partyID);

            txtPartyID.Text = dt.Rows[0]["ID"].ToString();
            lookUpEdit1.Properties.GetDisplayText(accCode);
            lookUpEdit1.ItemIndex = lookUpEdit1.Properties.GetDataSourceRowIndex("AccID", accCode);
            txtParty.Text = dt.Rows[0]["Name"].ToString();
            txtAddress.Text = dt.Rows[0]["Address_"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtCnic.Text = dt.Rows[0]["Cnic"].ToString();
            txtNtn.Text = dt.Rows[0]["Ntn"].ToString();

        }

        private void FillTextBoxes(int partyId)
        {
            //isUpdate = true;
            //int partyID = DataHelper.intParse(selectedPartyID);


            //DataTable dt = new DataTable();
            dt = GetParty(partyID);

            txtPartyID.Text = dt.Rows[0]["PartyID"].ToString();
            lookUpEdit1.Properties.GetDisplayText(accCode);
            lookUpEdit1.ItemIndex = lookUpEdit1.Properties.GetDataSourceRowIndex("AccountCode", accCode);
            txtParty.Text = dt.Rows[0]["PartyName"].ToString();
            txtAddress.Text = dt.Rows[0]["PartyAddress"].ToString();
            txtMobile.Text = dt.Rows[0]["PartyMobile"].ToString();
            txtPhone.Text = dt.Rows[0]["PartyPhone"].ToString();
            txtCnic.Text = dt.Rows[0]["CNIC_No"].ToString();
            txtNtn.Text = dt.Rows[0]["NTN_No"].ToString();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            accCode = DataHelper.intParse(lookUpEdit1.EditValue);
        }

        private void txtParty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '-'))
            {
                e.Handled = true;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            accCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAccount));
            FillTextBoxes();
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.FocusedView as GridView;
            bool shouldSelectRow = false;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {

                //shouldSelectRow = view.GetSelectedCells(view.FocusedRowHandle).Count() == view.VisibleColumns.Count && view.GetSelectedRows().Count() == 1;
            }
            BeginInvoke(new Action(() =>
            {
                partyID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPartyID));
                accCode = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAccount));
                FillTextBoxes(partyID);
                if (shouldSelectRow)
                    view.SelectRow(view.FocusedRowHandle);
            }));
        }
    }
}