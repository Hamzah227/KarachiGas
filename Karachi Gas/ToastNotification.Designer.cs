namespace Karachi_Gas
{
    partial class ToastNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbMessage = new DevExpress.XtraEditors.LabelControl();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Appearance.Options.UseFont = true;
            this.lbMessage.Appearance.Options.UseForeColor = true;
            this.lbMessage.Appearance.Options.UseTextOptions = true;
            this.lbMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbMessage.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbMessage.Location = new System.Drawing.Point(41, 27);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 16);
            this.lbMessage.TabIndex = 0;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1500;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // ToastNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(283, 69);
            this.ControlBox = false;
            this.Controls.Add(this.lbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastNotification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToastNotification";
            this.Load += new System.EventHandler(this.ToastNotification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMessage;
        private System.Windows.Forms.Timer timerClose;
    }
}