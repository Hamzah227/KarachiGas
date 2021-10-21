using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Transaction
{
    public partial class NewSales : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public NewSales()
        {
            InitializeComponent();
        }

        bool isSaved = false;
        DataTable dt;
        Classes.clsSales sales = new Classes.clsSales();

        private void NewSales_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            CreateVirtualTable();
            PopulateLookupEdits();

            dateEdit1.DateTime = DateTime.Now;
            LoadGrid();
            CheckSelection();
        }

        void LoadGrid()
        {
            gridControl1.DataSource = dt;
        }

        void ResetSaleTexts()
        {
            lookUpParty.EditValue = null;
            qtyCommercial.Text = "";
            qtyDom.Text = "";
            qtySmall.Text = "";
            discount.Text = "";
        }

        void CreateVirtualTable()
        {
            dt = new DataTable("Sales");
            DataColumn column = new DataColumn();
            column.ColumnName = "AutoID";
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 0;
            column.AutoIncrementStep = 1;

            dt.Columns.Add(column);
            dt.Columns.Add("partyID", typeof(int));
            dt.Columns.Add("accCode", typeof(int));
            dt.Columns.Add("partyName", typeof(string));
            dt.Columns.Add("qtyCom", typeof(int));
            dt.Columns.Add("qtyDom", typeof(int));
            dt.Columns.Add("qtySmall", typeof(int));
            dt.Columns.Add("rateCom", typeof(double));
            dt.Columns.Add("rateDom", typeof(double));
            dt.Columns.Add("rateSmall", typeof(double));
            dt.Columns.Add("discount", typeof(double));
            dt.Columns.Add("totalAmount", typeof(double));
            dt.Columns.Add("taxApplied", typeof(double));
            dt.Columns.Add("taxPayable", typeof(double));
            dt.Columns.Add("totalAmountTax", typeof(double));
        }

        void AddIntoVirtualTable()
        {
            double discount = DataHelper.DoubleParse(this.discount.Text);
            double totalAmount = 0.0, totalAmountWithTax = 0.0;
            double rateCom = 0.0, rateDom, rateSmall, totalCom, totalDom, totalSmall;
            int accCode = DataHelper.intParse(lookUpParty.GetColumnValue("AccountCode"));

            if (discount != 0)
            {
                double discountforCom = (((DataHelper.DoubleParse(this.rateCommercial.Text)) / 100) * discount);
                double discountforDom = (((DataHelper.DoubleParse(this.rateDomestic.Text)) / 100) * discount);
                double discountforSmall = (((DataHelper.DoubleParse(this.rateSmall.Text)) / 100) * discount);

                rateCom = DataHelper.DoubleParse(this.rateCommercial.Text) - discountforCom;
                rateDom = DataHelper.DoubleParse(this.rateDomestic.Text) - discountforDom;
                rateSmall = DataHelper.DoubleParse(this.rateSmall.Text) - discountforSmall;


            }
            else
            {
                rateCom = DataHelper.DoubleParse(this.rateCommercial.Text);
                rateDom = DataHelper.DoubleParse(this.rateDomestic.Text);
                rateSmall = DataHelper.DoubleParse(this.rateSmall.Text);
            }

            totalCom = rateCom * (DataHelper.DoubleParse(this.qtyCommercial.Text));
            totalDom = rateDom * (DataHelper.DoubleParse(this.qtyDom.Text));
            totalSmall = rateSmall * (DataHelper.DoubleParse(this.qtySmall.Text));

            totalAmount = totalCom + totalDom + totalSmall;
            double taxApplied = DataHelper.DoubleParse(txtTaxApplied.Text);
            double taxPayable = (totalAmount / 100) * taxApplied;
            totalAmountWithTax = totalAmount + taxPayable;

            dt.Rows.Add(null, DataHelper.intParse(lookUpParty.EditValue), accCode, lookUpParty.Text, DataHelper.intParse(qtyCommercial.Text), DataHelper.intParse(qtyDom.Text), DataHelper.intParse(qtySmall.Text), rateCom, rateDom, rateSmall, DataHelper.DoubleParse(this.discount.Text), totalAmount, DataHelper.DoubleParse(txtTaxApplied.Text), taxPayable, totalAmountWithTax);
            lookUpParty.Focus();
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

        void PopulateLookupEdits()
        {
            lookUpCompany.Properties.DataSource = Classes.GetData.GetCompany(0);
            lookUpCompany.Properties.PopulateColumns();
            lookUpCompany.Properties.Columns["AccID"].Visible = false;
            lookUpCompany.Properties.Columns["ID"].Visible = false;
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            AddIntoVirtualTable();
            ResetSaleTexts();
            LoadGrid();
        }

        void GetGridRow()
        {
            int rowHandle = gridView1.FocusedRowHandle;

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            GetGridRow();
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.FocusedView as GridView;
            bool shouldSelectRow = false;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                BeginInvoke(new Action(() =>
                {
                    GetGridRow();
                    if (shouldSelectRow)
                        view.SelectRow(view.FocusedRowHandle);
                }));
            }
            else if (e.KeyCode == Keys.Delete)
            {
                BeginInvoke(new Action(() =>
                {
                    int id = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID));
                    DeleteFromVirtualTable(id);
                }));
            }
        }

        public void SaveData()
        {
            int errorCount = 0;
            int compId = DataHelper.intParse(lookUpCompany.EditValue);
            double rateCom = DataHelper.DoubleParse(this.rateCommercial.Text);
            double rateDom = DataHelper.DoubleParse(this.rateDomestic.Text);
            double rateSmall = DataHelper.DoubleParse(this.rateSmall.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int partyId = DataHelper.intParse(dt.Rows[i]["partyID"]);
                int qtyCom = DataHelper.intParse(dt.Rows[i]["qtyCom"]);
                int qtyDom = DataHelper.intParse(dt.Rows[i]["qtyDom"]);
                int qtySmall = DataHelper.intParse(dt.Rows[i]["qtySmall"]);
                double discount = DataHelper.DoubleParse(dt.Rows[i]["discount"]);
                double totalAmount = DataHelper.DoubleParse(dt.Rows[i]["totalAmount"]);
                double taxApplied = DataHelper.DoubleParse(dt.Rows[i]["taxApplied"]);
                double totalAmountWithTax = DataHelper.DoubleParse(dt.Rows[i]["totalAmountTax"]);
                double taxPayable = DataHelper.DoubleParse(dt.Rows[i]["taxPayable"]);
                if (sales.SaveSalesNew(compId, rateCom, rateDom, rateSmall, partyId, qtyCom, qtyDom, qtySmall,
                    discount, totalAmount, taxApplied, taxPayable, totalAmountWithTax))
                { continue; }
                else
                { errorCount++; }
            }
            if (errorCount == 0)
            { isSaved = true; }
            else
            { isSaved = false; }
        }

        public void UpdateData()
        { }

        public void DeleteData()
        { }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            if (true)
            {
                Reset();
            }
        }

        public void Reset()
        {
            dt = null;
            lookUpCompany.EditValue = null;
            lookUpParty.EditValue = null;
            dateEdit1.DateTime = DateTime.Now;
            rateCommercial.Text = "";
            rateDomestic.Text = "";
            rateSmall.Text = "";
            txtTaxApplied.Text = "";
            qtyCommercial.Text = "";
            qtyDom.Text = "";
            qtySmall.Text = "";
            LoadGrid();
            CheckSelection();
            CreateVirtualTable();
        }

        void CheckSelection()
        {
            if (lookUpCompany.EditValue == null)
            {
                rateCommercial.Enabled = false;
                rateDomestic.Enabled = false;
                rateSmall.Enabled = false;
                lookUpParty.Enabled = false;
                txtTaxApplied.Enabled = false;
                qtyCommercial.Enabled = false;
                qtyDom.Enabled = false;
                qtySmall.Enabled = false;
                discount.Enabled = false;
            }
            else if (lookUpParty.EditValue == null)
            {
                lookUpParty.Enabled = true;
                rateCommercial.Enabled = true;
                rateDomestic.Enabled = true;
                rateSmall.Enabled = true;
                qtyCommercial.Enabled = false;
                qtyDom.Enabled = false;
                qtySmall.Enabled = false;
                discount.Enabled = false;

            }
            else
            {
                txtTaxApplied.Enabled = true;
                qtyCommercial.Enabled = true;
                qtyDom.Enabled = true;
                qtySmall.Enabled = true;
                discount.Enabled = true;
            }
        }

        private void lookUpCompany_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void lookUpCompany_EditValueChanged(object sender, EventArgs e)
        {
            CheckSelection();
        }

        private void lookUpParty_EditValueChanged(object sender, EventArgs e)
        {
            CheckSelection();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void rateCommercial_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void rateCommercial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '.'))
            {
                e.Handled = true;
            }
        }

        private void qtyCommercial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    class SaleData : List<SaleData>
    {
        public int partyID { get; set; }
        public string partyName { get; set; }
        public int qtyCom { get; set; }
        public int qtyDom { get; set; }
        public int qtySmall { get; set; }
        public decimal discount { get; set; }
    }
}