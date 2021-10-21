using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class clsSales : AbstractMembers
    {
        string userId = string.Empty;
        bool isSaved = false;

        int compid; int partyId; int qtyCom; int qtyDom; int qtySmall;
        double rateCom; double discount; double totalAmount; double taxApplied; double taxPayable; double totalAmountWithTax; double rateDom; double rateSmall;
        public bool SaveSalesNew(int compid, double rateCom, double rateDom, double rateSmall, int partyId, int qtyCom, int qtyDom, int qtySmall,
                                    double discount, double totalAmount, double taxApplied, double taxPayable, double totalAmountWithTax)
        {
            this.compid = compid; this.partyId = partyId; this.qtyCom = qtyCom; this.qtyDom = qtyDom; this.qtySmall = qtySmall;
            this.rateCom = rateCom; this.discount = discount; this.totalAmount = totalAmount; this.taxApplied = taxApplied;
            this.taxPayable = taxPayable; this.totalAmountWithTax = totalAmountWithTax; this.rateDom = rateDom; this.rateSmall = rateSmall;

            InsertSql();
            if (isSaved)
            {
                return true;
            }
            return false;
        }

        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@PartyAccID", Value = partyId},
                                                new SqlParameter {ParameterName = "@CompAccID", Value =  compid},
                                                //new SqlParameter {ParameterName = "@TxID", Value =  ""},
                                                new SqlParameter {ParameterName = "@QtyC", Value = qtyCom},
                                                new SqlParameter {ParameterName = "@QtyD", Value = qtyDom},
                                                new SqlParameter {ParameterName = "@QtyS", Value =  qtySmall},
                                                new SqlParameter {ParameterName = "@RateC", Value =  rateCom},
                                                new SqlParameter {ParameterName = "@RateD", Value =  rateDom},
                                                new SqlParameter {ParameterName = "@RateS", Value = rateSmall},
                                                new SqlParameter {ParameterName = "@TotalWOTax", Value = totalAmount},
                                                new SqlParameter {ParameterName = "@Tax", Value = taxApplied},
                                                new SqlParameter {ParameterName = "@TaxPayable", Value = taxPayable},
                                                new SqlParameter {ParameterName = "@TotalWithTax", Value = totalAmountWithTax},
                                                new SqlParameter {ParameterName = "@Discount", Value = discount}
                };

                DBService.ExecuteSP("AddSaleTransaction", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification toastNotification = new ToastNotification("Success", Color.Green);
                    toastNotification.Show();
                    isSaved = true;
                }
                else
                {
                    XtraMessageBox.Show("SALES", response.getErrorMessage());
                    isSaved = false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "SALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSaved = false;
            }
        }
    }
}
