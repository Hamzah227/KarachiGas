using System;
using System.Drawing;
using System.Windows.Forms;

namespace Karachi_Gas
{
    public partial class ToastNotification : Form
    {
        public ToastNotification(string message, Color bgColor)
        {
            InitializeComponent();

            BackColor = bgColor;
            lbMessage.Text = message;

        }

        private void ToastNotification_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
