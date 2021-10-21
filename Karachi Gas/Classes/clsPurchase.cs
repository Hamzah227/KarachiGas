using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class clsPurchase : AbstractMembers
    {
        DataTable dt;
        int id;
        Int64 compId; string purType; Int64 qtyC; Int64 qtyD; Int64 qtyS; Int64 qtyBozer; decimal weightBozer; decimal ratePerTon;
        decimal rateC; decimal rateD; decimal rateS; decimal totalAmount; Int64 userId = UserAuthentication.userId;
        public DataTable GetPurchase(int id)
        {
            this.id = id;
            GetSql();
            return dt;
        }
        
        public void SavePurchaseNew(Int64 compId, string purType, Int64 qtyC, Int64 qtyD, Int64 qtyS, Int64 qtyBozer, decimal weightBozer, decimal ratePerTon,
            decimal rateC, decimal rateD, decimal rateS, decimal totalAmount)
        {
            this.compId = compId;
            this.purType = purType;
            this.qtyC = qtyC;
            this.qtyD = qtyD;
            this.qtyS = qtyS;
            this.qtyBozer = qtyBozer;
            this.weightBozer = weightBozer;
            this.ratePerTon = ratePerTon;
            this.rateC = rateC;
            this.rateD = rateD;
            this.rateS = rateS;
            this.totalAmount = totalAmount;

            InsertSql();
        }

        public void UpdatePurchase(Int64 purchaseId, int compId, int purchaseType, decimal totalAmount, Int64 qtyBozer, decimal weightBozer, decimal rateBozer,
             Int64 qtyCom, Int64 qtyDom, Int64 qtySmall, decimal rateCom, decimal rateDom, decimal rateSmall)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@PurchaseID", Value = purchaseId },
                                                new SqlParameter {ParameterName = "@CompID", Value = compId},
                                                new SqlParameter {ParameterName = "@PurchaseType",Value = purchaseType},
                                                new SqlParameter {ParameterName = "@TotalAmount" ,Value = totalAmount},
                                                new SqlParameter {ParameterName = "@UserID",Value = UserAuthentication.userId},
                                                new SqlParameter {ParameterName = "@QtyBozer",Value = qtyBozer},
                                                new SqlParameter {ParameterName = "@WeightBozer",Value = weightBozer},
                                                new SqlParameter {ParameterName = "@RateBozer",Value = rateBozer},
                                                new SqlParameter {ParameterName = "@QtyCom",Value = qtyCom},
                                                new SqlParameter {ParameterName = "@QtyDom",Value = qtyDom},
                                                new SqlParameter {ParameterName = "@QtySmall",Value = qtySmall},
                                                new SqlParameter {ParameterName = "@RateCom",Value = rateCom},
                                                new SqlParameter {ParameterName = "@RateDom",Value = rateDom},
                                                new SqlParameter {ParameterName = "@RateSmall",Value = rateSmall}
                };
                DBService.ExecuteSP("UpdatePurchase", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notification = new ToastNotification("Success", Color.Green);
                    notification.Show();
                }
                else
                {
                    ToastNotification notification = new ToastNotification("Error Occurred", Color.Red);
                    notification.Show();
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "PURCHASE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void DeletePurchase(int id)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@ID", Value = id } };
                DBService.ExecuteSP("DeletePurchase", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notification = new ToastNotification("Success", Color.Green);
                    notification.Show();
                }
                else
                {
                    ToastNotification notification = new ToastNotification("Error Occurred", Color.Red);
                    notification.Show();
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "PURCHASE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@CompAccID", Value = compId},
                                                new SqlParameter { ParameterName = "@Type", Value = purType},
                                                new SqlParameter { ParameterName = "@QtyC", Value = qtyC},
                                                new SqlParameter { ParameterName = "@QtyD", Value = qtyD},
                                                new SqlParameter { ParameterName = "@QtyS", Value = qtyS},
                                                //new SqlParameter { ParameterName = "@qtyBozer", Value = qtyBozer},
                                                //new SqlParameter { ParameterName = "@weightBozer", Value = weightBozer},
                                                //new SqlParameter { ParameterName = "@ratePerTon", Value = ratePerTon},
                                                new SqlParameter { ParameterName = "@RateC", Value = rateC},
                                                new SqlParameter { ParameterName = "@RateD", Value = rateD},
                                                new SqlParameter { ParameterName = "@RateS", Value = rateS},
                                                new SqlParameter { ParameterName = "@Total", Value = totalAmount}
                                                //new SqlParameter { ParameterName = "@userId", Value = userId}
                };
                DBService.ExecuteSP("AddPurchase", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notification = new ToastNotification("Success", Color.Green);
                    notification.Show();
                }
                else
                {
                    ToastNotification notification = new ToastNotification("Error Occurred", Color.Red);
                    notification.Show();
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("PURCHASE", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void GetSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@ID", Value = id } };
                dt = DBService.FetchTable("EXEC GetPurhcase " + id + "");
                if (!response.Error)
                {
                    ToastNotification notification = new ToastNotification("Data Fetched!", Color.Green);
                    notification.Show();
                }
                else
                {
                    ToastNotification notification = new ToastNotification("Error Fetching Data!", Color.Red);
                    notification.Show();
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "PURCHASE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
