using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Karachi_Gas.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Transaction
{
    public partial class Empty : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public Empty()
        {
            InitializeComponent();
        }

        int compID;
        bool isSaved = false;
        clsEmpty empty = new clsEmpty();
        DataTable dt = new DataTable();
        private void Empty_Load(object sender, EventArgs e)
        {
            CreateVirtualTable();
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            date.DateTime = DateTime.Now;
            PopulateLookupEdits();
            LoadGrid();
            CheckSelection();
            //GetAlls();
        }

        void PopulateLookupEdits()
        {
            lookUpCompany.Properties.DataSource = Classes.GetData.GetCompany(0);
            lookUpCompany.Properties.PopulateColumns();
            lookUpCompany.Properties.Columns["ID"].Visible = false;
            lookUpCompany.Properties.Columns["AccID"].Visible = false;
            lookUpCompany.Properties.Columns["Address_"].Visible = false;
            lookUpCompany.Properties.Columns["Phone"].Visible = false;
            lookUpCompany.Properties.Columns["Fax"].Visible = false;
            //lookUpCompany.Properties.Columns["UserID"].Visible = false;
            lookUpCompany.Properties.Columns["DTStamp"].Visible = false;
            lookUpCompany.Properties.DisplayMember = "Name";
            lookUpCompany.Properties.ValueMember = "AccID";
            lookUpCompany.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;

            lookUpParty.Properties.DataSource = Classes.GetData.GetParty(0);
            lookUpParty.Properties.PopulateColumns();
            lookUpParty.Properties.Columns["ID"].Visible = false;
            lookUpParty.Properties.Columns["AccID"].Visible = false;
            lookUpParty.Properties.Columns["Address_"].Visible = false;
            lookUpParty.Properties.Columns["Phone"].Visible = false;
            lookUpParty.Properties.Columns["Mobile"].Visible = false;
            lookUpParty.Properties.Columns["Cnic"].Visible = false;
            lookUpParty.Properties.Columns["Ntn"].Visible = false;
            //lookUpParty.Properties.Columns["UserID"].Visible = false;
            lookUpParty.Properties.Columns["DTStamp"].Visible = false;
            lookUpParty.Properties.DisplayMember = "Name";
            lookUpParty.Properties.ValueMember = "AccID";
            lookUpParty.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        public void Reset()
        {
            lookUpCompany.EditValue = null;
            lookUpParty.EditValue = null;
            date.DateTime = DateTime.Now;
            txtqtyCommercial.Text = "";
            txtqtyDom.Text = "";
            txtqtySmall.Text = "";
        }


        void CreateVirtualTable()
        {
            DataColumn column = new DataColumn();
            column.ColumnName = "AutoID";
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 0;
            column.AutoIncrementStep = 1;

            dt.Columns.Add(column);
            dt.Columns.Add("partyID", typeof(int));
            dt.Columns.Add("partyName", typeof(string));
            dt.Columns.Add("qtyCom", typeof(int));
            dt.Columns.Add("qtyDom", typeof(int));
            dt.Columns.Add("qtySmall", typeof(int));

        }

        void AddIntoVirtualTable()
        {
            dt.Rows.Add(null, DataHelper.intParse(lookUpParty.EditValue), lookUpParty.Text, DataHelper.intParse(txtqtyCommercial.Text), DataHelper.intParse(txtqtyDom.Text),
                DataHelper.intParse(txtqtySmall.Text));
        }
        void DeleteFromVirtualTable(int id)
        {
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dt.Rows[i];
                if (DataHelper.intParse(dr["AutoID"]) == id)
                {
                    dr.Delete();
                }
            }
            dt.AcceptChanges();
            LoadGrid();
        }

        void LoadGrid()
        {
            gridControl1.DataSource = dt;
        }

        public void SaveData()
        {
            int compId = DataHelper.intParse(lookUpCompany.EditValue), errorCount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int partyId = DataHelper.intParse(dt.Rows[i]["partyID"]);
                int qtyCom = DataHelper.intParse(dt.Rows[i]["qtyCom"]);
                int qtyDom = DataHelper.intParse(dt.Rows[i]["qtyDom"]);
                int qtySmall = DataHelper.intParse(dt.Rows[i]["qtySmall"]);
                if (empty.Save(compId, partyId, qtyCom, qtyDom, qtySmall))
                { continue; }
            }
            if (errorCount == 0)
            {
                CheckSelection();
                isSaved = true;
            }
            else
            { isSaved = false; }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lookUpCompany_EditValueChanged(object sender, EventArgs e)
        {
            //compID = DataHelper.intParse(GetData.GetCompany(0).Rows[0]["CompID"]);
            compID = DataHelper.intParse(lookUpCompany.EditValue);
            CheckSelection();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            if (isSaved)
            {
                lookUpCompany.EditValue = null;
                date.DateTime = DateTime.Now;
                dt.Rows.Clear();
                ResetDataTexts();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.FocusedView as GridView;
            if (e.KeyCode == Keys.Delete)
            {
                BeginInvoke(new Action(() =>
                {
                    int autoId = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID));
                    DeleteFromVirtualTable(autoId);
                }));
            }

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            AddIntoVirtualTable();
            ResetDataTexts();
            LoadGrid();
        }

        void ResetDataTexts()
        {
            lookUpParty.Focus();
            lookUpParty.EditValue = null;
            txtqtyCommercial.Text = "";
            txtqtyDom.Text = "";
            txtqtySmall.Text = "";
            gridControl1.DataSource = dt;
        }

        void CheckSelection()
        {
            if (lookUpCompany.EditValue == null)
            {
                txtqtyCommercial.Enabled = false;
                txtqtyDom.Enabled = false;
                txtqtySmall.Enabled = false;
            }
            else if (lookUpParty.EditValue == null)
            {
                txtqtyCommercial.Enabled = false;
                txtqtyDom.Enabled = false;
                txtqtySmall.Enabled = false;
            }
            else
            {
                txtqtyCommercial.Enabled = true;
                txtqtyDom.Enabled = true;
                txtqtySmall.Enabled = true;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void lookUpParty_EditValueChanged(object sender, EventArgs e)
        {
            CheckSelection();
        }

        private void txtqtyCommercial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '-'))
            {
                e.Handled = true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
            CheckSelection();
            dt.Clear();
            CreateVirtualTable();
            LoadGrid();
        }

        public void UpdateData()
        { }

        public void DeleteData()
        { }
    }
}