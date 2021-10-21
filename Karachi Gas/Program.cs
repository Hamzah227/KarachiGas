using System;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private delegate bool GetFromData(int i);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GetFromData getData = GetData;
            if (getData(0))
            {
                Application.Run(new Systematics.UserLogin());
            }
            else { Application.Run(new Systematics.NewUser()); }
        }

        static bool GetData(int id)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                DataTable dt = DBService.FetchTable($"EXEC GetUsers {id}");
                if (!response.Error && DataHelper.HasRows(dt))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"No User Registered: {response.Error}");
                    return false;
                }
            }
            catch (Exception ae)
            {
                Console.WriteLine($"Error: {ae.Message}");
                return false;
            }
        }
    }
}
