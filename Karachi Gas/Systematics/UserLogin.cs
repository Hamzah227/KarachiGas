using DevExpress.XtraEditors;
using Karachi_Gas.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas.Systematics
{
    public partial class UserLogin : DevExpress.XtraEditors.XtraForm
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        public static string userName;
        public static string password;

        private void UserLogin_Load(object sender, EventArgs e)
        {

            lookupUsername.Properties.DisplayMember = "Username";
            lookupUsername.Properties.ValueMember = "Username";
            lookupUsername.Properties.DataSource = fillLookUp(0);
            lookupUsername.ItemIndex = 0;
        }

        private DataTable fillLookUp(int id)
        {
            string ID = id.ToString();
            try
            {
                ErrorResponse response = new ErrorResponse();
                DataTable dt = new DataTable();
                dt = DBService.FetchTable("EXEC GetUsers " + ID + "");
                return dt;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "USER LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form frm = new Systematics.NewUser();
            frm.ShowDialog();
        }

        private void lookupUsername_EditValueChanged(object sender, EventArgs e)
        {
            //lookupUsername.Text = DataHelper.stringParse(lookupUsername.GetSelectedDataRow().);
        }

        private void lookupUsername_QueryPopUp(object sender, CancelEventArgs e)
        {
            lookupUsername.Properties.PopulateColumns();
            lookupUsername.Properties.Columns["UserID"].Visible = false;
            lookupUsername.Properties.Columns["UserPassword"].Visible = false;
            lookupUsername.Properties.Columns["FirstName"].Visible = false;
            lookupUsername.Properties.Columns["LastName"].Visible = false;
            lookupUsername.Properties.Columns["Phone1"].Visible = false;
            lookupUsername.Properties.Columns["Phone2"].Visible = false;
            lookupUsername.Properties.Columns["Phone3"].Visible = false;
            lookupUsername.Properties.Columns["UserAddress"].Visible = false;
            lookupUsername.Properties.Columns["Email"].Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = lookupUsername.Text;
            password = txtPassword.Text;
            if (UserAuthentication.LoginAuthenticate(userName, password))
            {
                //XtraMessageBox.Show("User Logged In", "LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ToastNotification notify = new ToastNotification("Success", Color.FromArgb(0, 200, 81));
                notify.Show();

                newForm();
                notify.BringToFront();
            }
            else
            {
                //XtraMessageBox.Show("Error Loggin In. \nPlease Check Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToastNotification notify = new ToastNotification("Incorrect Password", Color.FromArgb(255, 53, 71));
                notify.Show();
            }
        }
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            //bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                    //FormFound = true;
                }
            }
            return false;
            //if (FormFound == false)
            //{
            //    Form2 f = new Form2();
            //    f.Show();
            //}
        }
        void newForm()
        {
            XtraForm mainForm = null;
            //this.Hide();
            //var form2 = new frm_Main();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
            if (mainForm == null || mainForm.Text == "")
            {
                this.Hide();
                mainForm = new frm_Main();
                //mainForm.MdiParent = this;
                //mainForm.Dock = DockStyle.Fill;
                mainForm.Show();
                mainForm.BringToFront();
            }
            else if (CheckOpened(mainForm.Name))
            {
                this.Hide();
                mainForm.Show();
                mainForm.Dock = DockStyle.Fill;
                mainForm.BringToFront();
                mainForm.Focus();

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //btnLogin_Click(sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}