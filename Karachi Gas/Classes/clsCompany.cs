using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class clsCompany : AbstractMembers
    {
        public DataTable GetCompany(int id)
        {
            DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetCompany " + id + "");
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
                XtraMessageBox.Show(ae.Message, "COMPANY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        int accCode; string compName; string compAddress; string phone; string fax; Int64 userid = UserAuthentication.userId;
        int compId; int id;
        public void SaveCompany(int accCode, string compName, string compAddress, string phone, string fax, Int64 userid)
        {
            this.accCode = accCode;
            this.compName = compName;
            this.compAddress = compAddress;
            this.phone = phone;
            this.fax = fax;
            InsertSql();
        }

        public void UpdateCompany(int accCode, int compId, string compName, string compAddress, string phone, string fax)
        {
            this.accCode = accCode;
            this.compId = compId;
            this.compName = compName;
            this.compAddress = compAddress;
            this.phone = phone;
            this.fax = fax;
            UpdateSql();
        }

        public void DeleteCompany(int id)
        {
            this.compId = id;
            DeleteSql();
        }

        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameter = { new SqlParameter {ParameterName = "@AccID" , Value = accCode },
                                                new SqlParameter {ParameterName = "@Name", Value = compName },
                                                new SqlParameter {ParameterName = "@Address", Value = compAddress },
                                                new SqlParameter {ParameterName = "@Phone", Value = phone },
                                                new SqlParameter {ParameterName = "@Fax", Value = fax }
                                                //new SqlParameter {ParameterName = "@userId",Value = userid }

                };

                DBService.ExecuteSP("AddCompany", parameter, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Company Saved", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            { XtraMessageBox.Show(ae.Message, "COMPANY", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public override void UpdateSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@ID", Value =accCode }, //CompID
                                                new SqlParameter { ParameterName = "@Name", Value =compName },
                                                new SqlParameter { ParameterName = "@Address_", Value =compAddress },
                                                new SqlParameter { ParameterName = "@Phone", Value =phone },
                                                new SqlParameter { ParameterName = "@Fax", Value =fax },
                };
                DBService.ExecuteSP("UpdateCompany", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Company Updated", Color.FromArgb(0, 200, 81));
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
                XtraMessageBox.Show(ae.Message, "COMPANY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void DeleteSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@CompID", Value = id } };
                DBService.ExecuteSP("DeleteCompany", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Company Deleted", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            { XtraMessageBox.Show(ae.Message, "COMPANY", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

    }
}
