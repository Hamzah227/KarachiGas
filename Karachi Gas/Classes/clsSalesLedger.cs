using System;
using System.Data;

namespace Karachi_Gas.Classes
{
    class clsSalesLedger
    {
        public DataTable GetSalesLedger(int accId, DateTime dtFrom, DateTime DtTo)
        {
            try
            {
                string from = DataHelper.dateOnly(dtFrom);
                string to = DataHelper.dateOnly(DtTo);
                ErrorResponse response = new ErrorResponse();
                DataTable dt = DBService.FetchTable("EXEC GetSalesLedger " + accId + "," + "'" + from + "','" + to + "'");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetPurchaseLedger(int accId, DateTime dtFrom, DateTime DtTo)
        {

            try
            {
                string from = DataHelper.dateOnly(dtFrom);
                string to = DataHelper.dateOnly(DtTo);
                ErrorResponse response = new ErrorResponse();
                DataTable dt = DBService.FetchTable("EXEC GetPurchaseLedger " + accId + "," + "'" + from + "','" + to + "'");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetCombineLedger(int accCode, DateTime dtFrom, DateTime dtTo)
        {

            try
            {
                string from = DataHelper.dateOnly(dtFrom);
                string to = DataHelper.dateOnly(dtTo);
                ErrorResponse response = new ErrorResponse();
                DataTable dt = DBService.FetchTable("EXEC GetCombineTransaction " + accCode + "," + "'" + from + "','" + to + "'");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
