using System.Data;
using System.Data.SqlClient;


namespace Karachi_Gas
{
    class DBService
    {
        public static DataTable FetchTable(string Query)
        {
            DBLayer DBS = new DBLayer();
            return DBS.FetchData(Query);
        }


        public static string DLookupDB(string StrQuery)
        {
            DBLayer DBLOOK = new DBLayer();
            return DBLOOK.DLookupDB(StrQuery);
        }

        public static void ExecutrQuery(string strQuery)
        {
            DBLayer ExecuteQuery = new DBLayer();
            ExecuteQuery.ExecuteQuery(strQuery);
        }
        public static DataTableCollection ExecuteSP(string StoredProcedure, SqlParameter[] param, ref ErrorResponse strError)
        {
            DBLayer layer = new DBLayer();
            return layer.ExecuteSP(StoredProcedure, param, ref strError);
        }
        public static DataTableCollection ExecuteSP(string StoredProcedure, ref ErrorResponse strError)
        {
            DBLayer layer = new DBLayer();
            return layer.ExecuteSP(StoredProcedure, ref strError);
        }


    }
}
