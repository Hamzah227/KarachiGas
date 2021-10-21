using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class GetData
    {
        public static DataTable GetAccount()
        {
           
            DataTable dt = new DataTable();
            dt = DBService.FetchTable("EXEC GetAccounts 0");
            return dt;
        }

        public static DataTable GetCompany(int id)
        {
            DataTable dt = new DataTable();
            dt = DBService.FetchTable("EXEC GetCompany " + id);
            return dt;
        }

        public static DataTable GetSalesman(int id)
        {
            DataTable dt = new DataTable();
            dt = DBService.FetchTable("EXEC GetSalesman " + id + "");
            return dt;
        }

        public static DataTable GetEmpty(int id)
        {
            DataTable dt = new DataTable();
            dt = DBService.FetchTable("EXEC GetEmpty " + id + "");
            return dt;
        }

        public static DataTable GetSales(int id)
        {
            DataTable dt = new DataTable();
            dt = DBService.FetchTable("EXEC GetSales " + id + "");
            return dt;
        }

        public static DataTable GetParty(int id)
        {
            DataTable dt = new DataTable();
            dt = DBService.FetchTable("EXEC GetParty " + id + "");
            return dt;
        }

        public static DataTable GetAccountsWRTAccType(int accType)
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetAccountsWRTAcctype " + accType + "");
                if (!response.Error)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static DataTable GetAllAccounts()
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetAccounts 0");
                if (!response.Error)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static DataTable GetPurhcase(int id)
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@ID", Value = id } };
                dt = DBService.FetchTable("EXEC GetPurchase " + id + "");
                if (!response.Error)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "PURCHASE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static DataTable GetPurchaseDetail(int PurchaseID)
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@PurchaseID", Value = PurchaseID } };
                dt = DBService.FetchTable("EXEC GetPurchaseDetail " + PurchaseID + "");
                if (!response.Error)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "PURCHASE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;

            }
        }

        public static DataTable GetStockEmpty()
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetStockEmpty");
                if (!response.Error)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "STOCK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static DataTable GetSaleDetails()
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetSaleDetails 45");
                if (!response.Error)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "Error Getting Sales");
                return null;
            }
        }

    }


}
