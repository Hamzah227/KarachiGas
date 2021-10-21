//using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class ClsAccounts : AbstractMembers
    {
        string accTitle; double accOpening; int accType; int accNature; Int64 userId;
        int accCode;
        DataTable dt = new DataTable();
        public void SaveAccounts(string accTitle, double accOpening, int accType, int accNature)
        {
            this.accTitle = accTitle;
            this.accOpening = accOpening;
            this.accType = accType;
            this.accNature = accNature;
            this.userId = UserAuthentication.userId;
            InsertSql();
        }

        public void UpdateAccounts(int accCode, string accTitle, double accOpening, int accType, int accNature)
        {
            this.accCode = accCode;
            this.accTitle = accTitle;
            UpdateSql();
        }

        public void DeleteAccounts(int accCode)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@AccCode", Value = accCode } };
                DBService.ExecuteSP("DeleteAccounts", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Account Updated", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable GetAccounts(int accCode)
        {
            this.accCode = accCode;
            GetSql();
            return dt;
        }

        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@Title",Value = accTitle },
                                                new SqlParameter {ParameterName = "@OpeningBalance",Value = accOpening },
                                                new SqlParameter {ParameterName = "@Type", Value = accType.ToString() },
                                                new SqlParameter {ParameterName = "@Nature", Value = accNature.ToString() }
                                                //new SqlParameter {ParameterName = "@dtStamp", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") }
                };
                DBService.ExecuteSP("AddAccount", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Account Saved", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            { XtraMessageBox.Show(ae.Message, "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        public override void UpdateSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@AccCode",Value = accCode },
                                                new SqlParameter {ParameterName = "@AccTitle",Value = accTitle }
                };
                DBService.ExecuteSP("UpdateAccounts", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Account Updated", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            { XtraMessageBox.Show(ae.Message, "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public override void GetSql()
        {
            
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetAccounts " + accCode);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Data Fetched!", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred!", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SaveAsTransaction(int accCode, int saleId, DateTime date, long saleAmount, long receive, long balance)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameter = { new SqlParameter { ParameterName = "@AccCode", Value = accCode },
                                                new SqlParameter { ParameterName = "@SaleID", Value = saleId },
                                                new SqlParameter { ParameterName = "@TranDate", Value = date },
                                                new SqlParameter { ParameterName = "@SaleAmount", Value = saleAmount },
                                                new SqlParameter { ParameterName = "@Receive", Value = receive },
                                                new SqlParameter { ParameterName = "@Balance", Value = balance }
                };
                DBService.ExecuteSP("SaveTransaction", parameter, ref response);
                if (response.Error)
                {
                    XtraMessageBox.Show("Error Occurred While adding to transaction", "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "ACCOUNTS");
            }
        }
    }
}
