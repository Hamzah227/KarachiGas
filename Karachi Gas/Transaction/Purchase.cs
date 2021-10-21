using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Karachi_Gas.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Transaction
{
    public partial class Purchase : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        public Purchase()
        {
            InitializeComponent();
        }
        int selectedID = 0;
        bool isbozer = false;
        DataTable dt = new DataTable();
        int userID, accCode;
        clsPurchase objPurchase = new clsPurchase();
        RadioButton[] rbArray;
        GetPurchaseLedger purchaseLedger = new GetPurchaseLedger();


        Int64 purchaseId;
        int compId; string purchaseType;
        Int64 qtyCom; Int64 qtyDom; Int64 qtySmall; Int64 qtyBozer; decimal wBozer; decimal ratePrTon; decimal rateC; decimal rateD; decimal rateS; decimal totalAmount;
        private void Purchase_Load(object sender, EventArgs e)
        {
            userID = UserAuthentication.ReturnUserID();
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            dtPurchase.DateTime = DateTime.Now.Date;
            LoadGrid();
            FillLookUpEdit();
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            rbArray = new RadioButton[3] { rbCylinder, rbBozer, rbEmpty };
        }
        void FillLookUpEdit()
        {
            lookupCompany.Properties.DataSource = GetData.GetCompany(0);
            lookupCompany.Properties.DisplayMember = "Name";
            lookupCompany.Properties.ValueMember = "AccID";
            lookupCompany.Properties.PopulateColumns();
            lookupCompany.Properties.Columns["ID"].Visible = false; //Comp ID
            lookupCompany.Properties.Columns["AccID"].Visible = false;
            lookupCompany.Properties.Columns["Address_"].Visible = false;
            lookupCompany.Properties.Columns["Phone"].Visible = false;
            lookupCompany.Properties.Columns["Fax"].Visible = false;
            lookupCompany.Properties.Columns["DTStamp"].Visible = false;
        }
        void LoadGrid()
        {
            gridControl1.DataSource = GetData.GetPurhcase(0);
        }

        void ClearAll()
        {
            lookupCompany.EditValue = null;
            txtComRate.Text = "0";
            txtQtyComCyl.Text = "0";
            txtQtyDomCyl.Text = "0";
            txtDomRate.Text = "0";
            txtQtySmallCyl.Text = "0";
            txtSmallRate.Text = "0";

            txtRateBozer.Text = "0";
            txtQtyBozer.Text = "0";
            txtWeightBozer.Text = "0";

            txtQtyComEmpty.Text = "0";
            txtQtyDomEmpty.Text = "0";
            txtQtySmallEmpty.Text = "0";
            txtRateComEmpty.Text = "0";
            txtRateDomEmpty.Text = "0";
            txtRateSmallEmpty.Text = "0";

            txtTotalAmount.Text = "0";
            dtPurchase.DateTime = DateTime.Now.Date;
            LoadGrid();
            lookupCompany.Properties.NullText = "Select Company";
            
            rbBozer.Checked = false;
            rbEmpty.Checked = false;
            rbCylinder.Checked = false;
        }

        void CalculateTotalForGasCylinder()
        {
            long total, tempTotal = 0;
            int qtyComCyl = DataHelper.intParse(txtQtyComCyl.Text), qtyDomCyl = DataHelper.intParse(txtQtyDomCyl.Text), qtySmallCyl = DataHelper.intParse(txtQtySmallCyl.Text);
            int rateComCyl = DataHelper.intParse(txtComRate.Text), rateDomCyl = DataHelper.intParse(txtDomRate.Text), rateSmallCyl = DataHelper.intParse(txtSmallRate.Text);
            tempTotal += qtyComCyl * rateComCyl;
            tempTotal += qtyDomCyl * rateDomCyl;
            tempTotal += qtySmallCyl * rateSmallCyl;
            total = tempTotal;
            txtTotalAmount.Text = total.ToString();
        }

        void CalculateTotalForEmptyCylinder()
        {
            long total, tempTotal = 0;
            int qtyEmptyCom = DataHelper.intParse(txtQtyComEmpty.Text), qtyEmptyDom = DataHelper.intParse(txtQtyDomEmpty.Text), qtyEmptySmall = DataHelper.intParse(txtQtySmallEmpty.Text);
            int rateEmptyCom = DataHelper.intParse(txtRateComEmpty.Text), rateEmptyDom = DataHelper.intParse(txtRateDomEmpty.Text), rateEmptySmall = DataHelper.intParse(txtRateSmallEmpty.Text);
            tempTotal += qtyEmptyCom * rateEmptyCom;
            tempTotal += qtyEmptyDom * rateEmptyDom;
            tempTotal += qtyEmptySmall * rateEmptySmall;
            total = tempTotal;
            txtTotalAmount.Text = total.ToString();
        }

        void CalculateTotalForBozer()
        {
            float total;
            //float qtyBozer = DataHelper.intParse(txtQtyBozer.Text); //
            float rateBozer = DataHelper.floatParse(txtRateBozer.Text);
            float weightBozer = DataHelper.floatParse(txtWeightBozer.Text);
            int qtyBozer = DataHelper.intParse(txtQtyBozer.Text);
            total = (weightBozer * rateBozer) * qtyBozer;
            txtTotalAmount.Text = total.ToString();

        }
        enum PurchaseType
        {
            Cylinder = 1,
            Bozer = 2,
            Empty = 3
        }



        private void GetPurchaseDetail(int id)
        {
            DataTable dt = GetData.GetPurchaseDetail(id);

            //if ((int)(dt.Rows[0]["PurchaseType"]) == 1)
            //{
            //    rbCylinder.Checked = true;
            //}
            //else if ((int)(dt.Rows[0]["PurchaseType"]) == 3)
            //{
            //    rbEmpty.Checked = true;
            //}
            if (rbCylinder.Checked)
            {
                txtQtyComCyl.Text = dt.Rows[0]["QtyCommercial"].ToString();
                txtQtyDomCyl.Text = dt.Rows[0]["QtyDomestic"].ToString();
                txtQtySmallCyl.Text = dt.Rows[0]["QtySmall"].ToString();
                txtComRate.Text = dt.Rows[0]["RateCommercial"].ToString();
                txtDomRate.Text = dt.Rows[0]["RateDomestic"].ToString();
                txtSmallRate.Text = dt.Rows[0]["RateSmall"].ToString();
            }
            else if (rbEmpty.Checked)
            {
                txtQtyComEmpty.Text = dt.Rows[0]["QtyCommercial"].ToString();
                txtQtyDomEmpty.Text = dt.Rows[0]["QtyDomestic"].ToString();
                txtQtySmallEmpty.Text = dt.Rows[0]["QtySmall"].ToString();
                txtRateComEmpty.Text = dt.Rows[0]["RateCommercial"].ToString();
                txtRateDomEmpty.Text = dt.Rows[0]["RateDomestic"].ToString();
                txtRateSmallEmpty.Text = dt.Rows[0]["RateSmall"].ToString();

            }



            //txtQtyBozer.Text = dt.Rows[0]["QtyBozer"].ToString();
            //txtWeightBozer.Text = dt.Rows[0]["WeightBozer"].ToString();
            //txtRateBozer.Text = dt.Rows[0]["RateBozer"].ToString();
        }

        public void SaveData()
        {
            objPurchase.SavePurchaseNew(compId, purchaseType, qtyCom, qtyDom, qtySmall, qtyBozer, wBozer, ratePrTon, rateC, rateD, rateS, totalAmount);
        }

        public void UpdateData()
        {
            //objPurchase.UpdatePurchase(purchaseId, compId, purchaseType, totalAmount, qtyBozer, wBozer, ratePrTon, qtyCom, qtyDom, qtySmall, rateC, rateD, rateS);
        }

        public void DeleteData()
        {
            int id = 0;
            objPurchase.DeletePurchase(id);
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            void Save()
            {
                try
                {
                    compId = DataHelper.intParse(lookupCompany.EditValue);
                    foreach (PurchaseType type in Enum.GetValues(typeof(PurchaseType)))
                    {
                        for (int i = 0; i < rbArray.Length; i++)
                        {
                            if (rbArray[i].Checked && rbArray[i].Text == type.ToString())
                            {
                                purchaseType = type.ToString();
                                break;
                            }
                        }
                    }

                    totalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    qtyBozer = Convert.ToInt64(txtQtyBozer.Text);
                    wBozer = Convert.ToDecimal(txtWeightBozer.Text);
                    ratePrTon = Convert.ToDecimal(txtRateBozer.Text);
                    qtyCom = Convert.ToInt64(txtQtyComCyl.Text);
                    qtyDom = Convert.ToInt64(txtQtyDomCyl.Text);
                    qtySmall = Convert.ToInt64(txtQtySmallCyl.Text);
                    rateC = Convert.ToDecimal(txtComRate.Text);
                    rateD = Convert.ToDecimal(txtDomRate.Text);
                    rateS = Convert.ToDecimal(txtSmallRate.Text);


                }
                catch (Exception ae)
                { XtraMessageBox.Show(ae.Message, "PURHCASE"); }
            }

            Save();
            SaveData();
            LoadGrid();
            Reset();
        }

        private void bbiClearAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
            gridControl1.DataSource = GetData.GetPurhcase(0);
            Reset();
        }

        private void bbiUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int purchaseId = selectedID;
            int compId = DataHelper.intParse(lookupCompany.EditValue);
            foreach (PurchaseType type in Enum.GetValues(typeof(PurchaseType)))
            {
                for (int i = 0; i < rbArray.Length; i++)
                {
                    if (rbArray[i].Text == type.ToString())
                    {
                        purchaseType = type.ToString();
                    }
                }
            }

            totalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            qtyBozer = Convert.ToInt64(txtQtyBozer.Text);
            wBozer = Convert.ToDecimal(txtWeightBozer.Text);
            ratePrTon = Convert.ToDecimal(txtRateBozer.Text);
            qtyCom = Convert.ToInt64(txtQtyComCyl.Text);
            qtyDom = Convert.ToInt64(txtQtyDomCyl.Text);
            qtySmall = Convert.ToInt64(txtQtySmallCyl.Text);
            rateC = Convert.ToDecimal(txtComRate.Text);
            rateD = Convert.ToDecimal(txtDomRate.Text);
            rateS = Convert.ToDecimal(txtSmallRate.Text);

            UpdateData();
        }

        private void lookUpCompany_QueryPopUp(object sender, CancelEventArgs e)
        {
            //lookupCompany.Properties.PopulateColumns();
            // lookupCompany.Properties.Columns["GLCode"].Visible = false;
            //lookupCompany.Properties.Columns["Fax"].Visible = false;
            //lookupCompany.Properties.Columns["CompID"].Visible = false;
            //lookupCompany.Properties.Columns["CompAddress"].Visible = false;
            //lookupCompany.Properties.Columns["Phone"].Visible = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            selectedID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPurId));
            int compId = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCompany));
            dt = GetData.GetPurhcase(selectedID);
            lookupCompany.Properties.GetDisplayText(compId);
            //lookUpEdit1.EditValue = accCode;
            lookupCompany.ItemIndex = lookupCompany.Properties.GetDataSourceRowIndex("CompID", compId);

            //txtPurID.Text = dt.Rows[0]["PurchaseID"].ToString();
            dtPurchase.EditValue = DataHelper.dateOnly(dt.Rows[0]["PurchaseDate"]);
            lookupCompany.Text = dt.Rows[0]["CompID"].ToString();

            foreach (PurchaseType type in Enum.GetValues(typeof(PurchaseType)))
            {
                if (DataHelper.intParse(dt.Rows[0]["PurchaseType"]) == (int)type)
                {
                    for (int i = 0; i < rbArray.Length; i++)
                    {
                        if (rbArray[i].Text == type.ToString())
                        {
                            rbArray[i].Checked = true;
                        }
                    }
                }
            }

            txtTotalAmount.Text = dt.Rows[0]["TotalAmount"].ToString();
            GetPurchaseDetail(selectedID);

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.FocusedView as GridView;
            bool shouldSelectRow = false;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
            }
            BeginInvoke(new Action(() =>
            {
                int selectedID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPurId));
                int compId = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCompany));

                FillTextBoxes(selectedID, compId);
                GetPurchaseDetail(selectedID);
                if (shouldSelectRow)
                    view.SelectRow(view.FocusedRowHandle);
            }));
        }

        void FillTextBoxes(int selectedId, int compId)
        {
            dt = GetData.GetPurhcase(selectedId);
            lookupCompany.Properties.GetDisplayText(compId);
            //lookUpEdit1.EditValue = accCode;
            lookupCompany.ItemIndex = compId;

            //txtPurID.Text = dt.Rows[0]["PurchaseID"].ToString();
            dtPurchase.EditValue = DataHelper.dateOnly(dt.Rows[0]["PurchaseDate"]);
            //lookupCompany.Text = dt.Rows[0]["CompID"].ToString();

            foreach (PurchaseType type in Enum.GetValues(typeof(PurchaseType)))
            {
                if (DataHelper.intParse(dt.Rows[0]["PurchaseType"]) == (int)type)
                {
                    for (int i = 0; i < rbArray.Length; i++)
                    {
                        if (rbArray[i].Text == type.ToString())
                        {
                            rbArray[i].Checked = true;
                            break;
                        }
                    }
                }
            }

            txtTotalAmount.Text = dt.Rows[0]["TotalAmount"].ToString();

            //GetPurchaseDetail(selectedID);

        }
        private void rbCylinder_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbCylinder.Checked)
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
                xtraTabPage1.Show();
            }
        }

        private void rbBozer_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbBozer.Checked)
            {
                panel2.Enabled = false;
            }
            else
            {
                panel2.Enabled = true;
                xtraTabPage1.Show();
                isbozer = true;
            }
        }

        private void rbEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbEmpty.Checked)
            {
                panel3.Enabled = false;
            }
            else
            {
                panel3.Enabled = true;
                xtraTabPage2.Show();
            }
        }

        private void txtQtyComCyl_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForGasCylinder();
        }

        private void txtComRate_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForGasCylinder();
        }

        private void txtQtyDomCyl_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForGasCylinder();
        }

        private void txtDomRate_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForGasCylinder();
        }

        private void txtQtySmallCyl_EditValueChanged_1(object sender, EventArgs e)
        {
            CalculateTotalForGasCylinder();
        }

        private void txtSmallRate_EditValueChanged_1(object sender, EventArgs e)
        {
            CalculateTotalForGasCylinder();
        }

        private void txtQtyComEmpty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForEmptyCylinder();
        }

        private void txtRateComEmpty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForEmptyCylinder();
        }

        private void txtQtyDomEmpty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForEmptyCylinder();
        }

        private void txtRateDomEmpty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForEmptyCylinder();
        }

        private void txtQtySmallEmpty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForEmptyCylinder();
        }

        private void txtRateSmallEmpty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForEmptyCylinder();
        }

        private void txtQtyBozer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForBozer();
        }

        private void txtRateBozer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForBozer();
        }

        private void txtQtyComCyl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void txtWeightBozer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotalForBozer();
        }

        private void lookupCompany_EditValueChanged(object sender, EventArgs e)
        {
            accCode = DataHelper.intParse(lookupCompany.GetColumnValue("AccountCode"));
        }

        public void Reset()
        {
            ClearAll();
        }
    }
}