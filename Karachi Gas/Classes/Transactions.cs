using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Karachi_Gas.Classes
{
    class Transactions
    {
        public static DataTable GenerateReportByDate(DateTime from, DateTime to)
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetAllTransactions '" + from + "','" + to + "'");
                if (!response.Error)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "Exception!");
                return null;
                throw;
            }
        }
    }
}
