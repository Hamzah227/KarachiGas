using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class clsParty : AbstractMembers
    {
        public System.Data.DataTable GetParty(int id)
        {
            System.Data.DataTable dt;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetParty " + id + "");
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
                XtraMessageBox.Show(ae.Message, "PARTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        int partID; int id;
        int accCode; string partyname; string partyAddress; string partyPhone; string partyMobile; string cnic; string ntn; Int64 userID = UserAuthentication.userId;
        public void SaveParty(int accCode, string partyname, string partyAddress, string partyPhone, string partyMobile, string cnic, string ntn)
        {
            this.accCode = accCode;
            this.partyname = partyname;
            this.partyAddress = partyAddress;
            this.partyPhone = partyPhone;
            this.partyMobile = partyMobile;
            this.cnic = cnic;
            this.ntn = ntn;
            InsertSql();
        }

        public void UpdateParty(int partID, int accCode, string partyname, string partyAddress, string partyPhone, string partyMobile, string cnic, string ntn)
        {
            this.partID = partID;
            this.accCode = accCode;
            this.partyname = partyname;
            this.partyAddress = partyAddress;
            this.partyPhone = partyPhone;
            this.partyMobile = partyMobile;
            this.cnic = cnic;
            this.ntn = ntn;
            UpdateSql();
        }

        public void DeleteParty(int id)
        {
            this.id = id;
            DeleteSql();
        }

        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@AccID",Value= accCode},
                                                new SqlParameter {ParameterName = "@Name",Value= partyname},
                                                new SqlParameter {ParameterName = "@Address",Value= partyAddress },
                                                new SqlParameter {ParameterName = "@Phone",Value= partyPhone},
                                                new SqlParameter {ParameterName = "@Mobile",Value= partyMobile},
                                                new SqlParameter {ParameterName = "@Cnic",Value= cnic},
                                                new SqlParameter {ParameterName = "@Ntn",Value= ntn}
                                                //new SqlParameter {ParameterName = "@userId",Value= userID},
                };
                DBService.ExecuteSP("AddParty", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notify = new ToastNotification("Party Saved", Color.FromArgb(0, 200, 81));
                    notify.Show();
                }
                else
                {
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                    notify.Show();
                }
            }
            catch (Exception ae)
            { XtraMessageBox.Show(ae.Message, "PARTY", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public override void UpdateSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@ID",Value = partID},
                                                //new SqlParameter {ParameterName = "@AccCode",Value =accCode},
                                                new SqlParameter {ParameterName = "@Name",Value =partyname},
                                                new SqlParameter {ParameterName = "@Address_",Value = partyAddress},
                                                new SqlParameter {ParameterName = "@Phone",Value =partyPhone},
                                                new SqlParameter {ParameterName = "@Mobile",Value = partyMobile},
                                                new SqlParameter {ParameterName = "@Cnic",Value =cnic},
                                                new SqlParameter {ParameterName = "@Ntn",Value =ntn}
                                                //new SqlParameter {ParameterName = "@UserID",Value =userID},

                };
                DBService.ExecuteSP("UpdateParty", parameters, ref response);
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
            { XtraMessageBox.Show(ae.Message, "PARTY", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public override void DeleteSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@ID", Value = id } };
                DBService.ExecuteSP("DeleteParty", parameters, ref response);
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
            {
                XtraMessageBox.Show(ae.Message, "PARTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
