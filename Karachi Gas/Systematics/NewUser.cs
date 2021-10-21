using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Karachi_Gas.Systematics
{
    public partial class NewUser : DevExpress.XtraBars.Ribbon.RibbonForm, IMembers
    {
        bool saveAndClose = false;
        int selectedID;
        public NewUser()
        {
            InitializeComponent();
            GetUsers(0);
        }

        private DataTable GetUsers(int id)
        {
            string ID = DataHelper.stringParse(id);
            try
            {
                if (id == 0)
                {
                    DataTable dt = new DataTable();
                    ErrorResponse response = new ErrorResponse();
                    dt = DBService.FetchTable("EXEC GetUsers " + ID + "");
                    if (response.Error)
                    {
                        XtraMessageBox.Show("Error Occurred", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    else
                    {
                        gridUsers.DataSource = dt;
                        return null;
                    }
                }
                else
                {
                    DataTable dt = new DataTable();
                    ErrorResponse response = new ErrorResponse();
                    dt = DBService.FetchTable("EXEC GetUsers " + ID + "");
                    return dt;
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "USERS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public void SaveData()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter{ParameterName = "@Username",Value = txtUsername.Text},
                                                new SqlParameter{ParameterName = "@Password",Value = txtPassword.Text },
                                                new SqlParameter{ParameterName = "@Firstname",Value = txtFirstName.Text },
                                                new SqlParameter{ParameterName = "@Lastname",Value = txtLastName.Text },
                                                new SqlParameter{ParameterName = "@Contact1",Value = txtPhone1.Text },
                                                new SqlParameter{ParameterName = "@Contact2",Value = txtPhone2.Text },
                                                //new SqlParameter{ParameterName = "@PhoneNo3",Value = txtPhone3.Text },
                                                new SqlParameter{ParameterName = "@Address",Value = txtAddress.Text }
                                                //new SqlParameter{ParameterName = "@Email",Value = txtEmail.Text }
                };
                DBService.ExecuteSP("AddUser", parameters, ref response);
                if (!response.Error)
                {
                    GetUsers(0);
                    Reset();
                    XtraMessageBox.Show("Record Saved", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (saveAndClose) { this.Close(); }
                }
                else
                {
                    XtraMessageBox.Show("Error Occurred", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "USERS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateData()
        {
            //selectedID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID));
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName="@userId",Value = selectedID },
                                                new SqlParameter { ParameterName="@FirstName",Value= txtFirstName.Text },
                                                new SqlParameter { ParameterName="@LastName",Value= txtLastName.Text },
                                                new SqlParameter { ParameterName="@UserName",Value= txtUsername.Text },
                                                new SqlParameter { ParameterName="@UserPassword",Value= txtPassword.Text },
                                                new SqlParameter { ParameterName="@PhoneNo1",Value= txtPhone1.Text },
                                                new SqlParameter { ParameterName="@PhoneNo2",Value= txtPhone2.Text },
                                                new SqlParameter { ParameterName="@PhoneNo3",Value= txtPhone3.Text },
                                                new SqlParameter { ParameterName="@UserAddress",Value= txtAddress.Text },
                                                new SqlParameter { ParameterName="@Email",Value= txtEmail.Text }
                };
                DBService.ExecuteSP("UpdateUsers", parameters, ref response);
                if (!response.Error)
                {
                    XtraMessageBox.Show("User Updated", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    GetUsers(0);
                }
                else
                {
                    XtraMessageBox.Show("Error Occurred", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "USERS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeleteData()
        {
            selectedID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID));
            try
            {
                string id = DataHelper.stringParse(selectedID);
                ErrorResponse response = new ErrorResponse();
                DBService.ExecutrQuery("EXEC DeleteUser " + id + "");
                if (!response.Error)
                {
                    //XtraMessageBox.Show("User Deleted", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToastNotification notify = new ToastNotification("User Deleted", Color.FromArgb(0, 200, 81));
                    notify.Show();
                    GetUsers(0);
                    Reset();
                }
                else
                {
                    XtraMessageBox.Show("Error Occurred", "USERS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ToastNotification notify = new ToastNotification("Error Occurred", Color.FromArgb(255, 53, 71));
                }
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "USERS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Reset()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtPhone3.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveAndClose = true;
            SaveData();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
        }

        private void gridUsers_Click(object sender, EventArgs e)
        {
            selectedID = DataHelper.intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID));

            DataTable dt = new DataTable();
            dt = GetUsers(selectedID);
            txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[0]["LastName"].ToString();
            txtUsername.Text = dt.Rows[0]["UserName"].ToString();
            txtPassword.Text = dt.Rows[0]["UserPassword"].ToString();
            txtPhone1.Text = dt.Rows[0]["PhoneNo1"].ToString();
            txtPhone2.Text = dt.Rows[0]["PhoneNo2"].ToString();
            txtPhone3.Text = dt.Rows[0]["PhoneNo3"].ToString();
            txtAddress.Text = dt.Rows[0]["UserAddress"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}