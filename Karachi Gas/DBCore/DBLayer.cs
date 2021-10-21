using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Karachi_Gas
{
    class DBLayer : DBService
    {
        private static string connectionstring = "";

        public DBLayer()
        {

            connectionstring = ConfigurationManager.ConnectionStrings["ConnectKarachiGas"].ConnectionString.ToString();
            //connectionstring = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=KarachiGas";
            //connectionstring = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=SBTE_MIS;Data Source=.";
            //("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
        }

        public DataTableCollection ExecuteSP(string StoredProcedure, SqlParameter[] Parameters, ref ErrorResponse strError)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionstring))
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

                SqlCon.Open();
                using (SqlTransaction SqlTrans = SqlCon.BeginTransaction())
                {
                    try
                    {
                        DataSet ds = new DataSet("DataSet1");
                        using (SqlCommand cmd = new SqlCommand(StoredProcedure, SqlCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = SqlTrans;
                            if (Parameters != null)
                            {
                                foreach (SqlParameter sqlp in Parameters)
                                    cmd.Parameters.Add(sqlp);
                            }

                            using (SqlDataAdapter sdapt = new SqlDataAdapter(cmd))
                            {
                                sdapt.Fill(ds);
                            }
                        }

                        SqlTrans.Commit();
                        return ds.Tables;
                    }
                    catch (SqlException ae)
                    {
                        SqlTrans.Rollback();
                        strError.Error = true;
                        strError.ErrorList.Add(new ErrorList() { ErrorCode = ae.ErrorCode, Message = ae.Message, ErrorType = "SQL", WarningLevel = Level.Error });

                        //   Logs.WriteError("DBLayer", "FetchFromSP2(" + SPName + ")", "SQL", ae.Message);

                        return null;
                    }
                    catch (Exception ae)
                    {
                        SqlTrans.Rollback();
                        strError.Error = true;
                        strError.ErrorList.Add(new ErrorList() { ErrorCode = 999, Message = ae.Message, ErrorType = "General", WarningLevel = Level.Error });

                        //Logs.WriteError("DBLayer", "FetchFromSP2(" + SPName + ")", "General", ae.Message);
                        return null;
                    }
                }
            }
        }

        public DataTableCollection ExecuteSP(string StoredProcedure, ref ErrorResponse strError)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionstring))
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

                SqlCon.Open();
                using (SqlTransaction SqlTrans = SqlCon.BeginTransaction())
                {
                    try
                    {
                        DataSet ds = new DataSet("DataSet1");
                        using (SqlCommand cmd = new SqlCommand(StoredProcedure, SqlCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = SqlTrans;


                            using (SqlDataAdapter sdapt = new SqlDataAdapter(cmd))
                            {
                                sdapt.Fill(ds);
                            }
                        }

                        SqlTrans.Commit();
                        return ds.Tables;
                    }
                    catch (SqlException ae)
                    {
                        SqlTrans.Rollback();
                        strError.Error = true;
                        strError.ErrorList.Add(new ErrorList() { ErrorCode = ae.ErrorCode, Message = ae.Message, ErrorType = "SQL", WarningLevel = Level.Error });

                        //   Logs.WriteError("DBLayer", "FetchFromSP2(" + SPName + ")", "SQL", ae.Message);

                        return null;
                    }
                    catch (Exception ae)
                    {
                        SqlTrans.Rollback();
                        strError.Error = true;
                        strError.ErrorList.Add(new ErrorList() { ErrorCode = 999, Message = ae.Message, ErrorType = "General", WarningLevel = Level.Error });

                        //Logs.WriteError("DBLayer", "FetchFromSP2(" + SPName + ")", "General", ae.Message);
                        return null;
                    }
                }
            }
        }




        public DataTable FetchData(string query)
        {
            if (query == "") return null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionstring))
                {
                    cn.Open();
                    using (SqlDataAdapter sdapt = new SqlDataAdapter(query, cn))
                    {
                        sdapt.Fill(dt);
                    }
                }
            }
            catch (Exception ae)
            {


            }
            return dt;
        }



        public string DLookupDB(string SQL)
        {
            string Val = "";
            DataTable dt = new DataTable("Table1");
            dt = FetchData(SQL);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Val = row[0].ToString();
                }
            }

            return Val;

        }

        public void ExecuteQuery(string strQuery)
        {

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlDataAdapter sdapt = new SqlDataAdapter(strQuery, conn))
                {
                    sdapt.Fill(dt);
                }
            }





        }
    }
}

