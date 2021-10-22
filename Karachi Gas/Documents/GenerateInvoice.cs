using DevExpress.XtraEditors;
using Karachi_Gas.Classes;
using Karachi_Gas.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Karachi_Gas.Reports
{
    public partial class GenerateInvoice : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        GetInvoice getReports = new GetInvoice();
        public GenerateInvoice()
        {
            InitializeComponent();
        }
        public List<InvoiceDetail> list;
        public static List<InvoiceDetail> list1;
        public static int saleID;

        private void GenerateInvoice_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            dateEdit1.DateTime = DateTime.Now.Date;
            dateEdit2.DateTime = DateTime.Now.Date;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void GetData()
        {
            saleID = DataHelper.intParse(txtSaleID.Text);
            if (saleID != 0)
            {
                DataTable dt = new DataTable();
                try
                {
                    ErrorResponse response = new ErrorResponse();
                    dt = DBService.FetchTable("EXEC GetInvoiceBySaleID " + saleID + "");
                    if (!response.Error)
                    {
                        if (DataHelper.HasRows(dt))
                        {
                            gridControl1.DataSource = dt;
                        }
                        else
                        {
                            XtraMessageBox.Show("Record does not exist!", "INVOICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show(response.getErrorMessage(), "INVOICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ae)
                { XtraMessageBox.Show(ae.Message, "INVOICE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                XtraMessageBox.Show("Enter OR Select Sale ID", "INVOICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewDoc frmDoc = null;
            if (frmDoc == null || frmDoc.Text == "")
            {

                frmDoc = new Documents.ViewDoc();
                frmDoc.isInvoice = true;
                frmDoc.PrintInvoice(getReports.PrintInvoice(saleID));
                frmDoc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
                frmDoc.Dock = DockStyle.Fill;
                frmDoc.Show();
                frmDoc.BringToFront();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtSaleID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            GetDataWRTDate();
        }
        public void GetDataWRTDate()
        {
            DateTime fromDate = dateEdit1.DateTime;
            DateTime toDate = dateEdit2.DateTime;
            DataTable dt = new DataTable();
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetInvoiceWRTDate '" + fromDate + "','" + toDate + "'");
                if (!response.Error)
                {
                    gridControl1.DataSource = dt;
                }
                else
                {
                    XtraMessageBox.Show(response.ErrorList[0].Message, "Database Error");
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Exception!");
                throw;
            }
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            GetDataWRTDate();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int selectedId = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "InvoiceId"));
            txtSaleID.Text = selectedId.ToString();
        }

        public static class CommonMethod
        {
            public static List<T> ConvertToList<T>(DataTable dt)
            {
                var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();
                var properties = typeof(T).GetProperties();
                return dt.AsEnumerable().Select(row =>
                {
                    var objT = Activator.CreateInstance<T>();
                    foreach (var pro in properties)
                    {
                        if (columnNames.Contains(pro.Name))
                        {
                            try
                            {
                                pro.SetValue(objT, row[pro.Name]);
                            }
                            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Invoice Error!"); }
                        }
                    }
                    return objT;
                }).ToList();
            }
        }

        private void txtSaleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}