using System;
using System.Data;

namespace Karachi_Gas.Classes
{
    class UserAuthentication
    {
        public static string UserName;
        public static string Password;
        public static Int64 userId = 0;
        static DataTable dt = new DataTable();
        public static bool LoginAuthenticate(string username, string password)
        {


            dt = DBService.FetchTable("EXEC GetUsers " + "'0'" + "");
            if (DataHelper.HasRows(dt))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (username == dt.Rows[0]["Username"].ToString())
                    {
                        if (password == dt.Rows[0]["Password_"].ToString())
                        {
                            //int UserID = DataHelper.intParse(dt.Rows[0]["ID"]);
                            //return UserID;
                            UserName = username;
                            Password = password;
                            userId = (Int64)dt.Rows[0]["UserID"];
                            return true;

                        }
                        return false;
                    }
                }
            }
            return false;
        }

        public static int ReturnUserID()
        {
            try
            {
                if (LoginAuthenticate(UserName, Password))
                {
                    int userID = DataHelper.intParse(dt.Rows[0]["UserID"]);
                    return userID;
                }
                return 0;
            }
            catch (Exception) { return 0; }   
        }
    }
}
