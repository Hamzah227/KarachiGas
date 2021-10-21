using DevExpress.XtraEditors;
using Karachi_Gas.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Karachi_Gas.Reports
{
    public partial class NewInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public NewInvoice()
        {
            InitializeComponent();

        }

        public void InnitData(List<InvoiceDetail> data)
        {
            objectDataSource1.DataSource = data;
            string isNegative = "";
            try
            {
                //Console.WriteLine("Enter a Number to convert to currency");
                string number = data[0].TotalWithTax.ToString();
                number = Convert.ToDouble(number).ToString();

                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    //Console.WriteLine("The number in currency fomat is \nZero Only");
                }
                else
                {
                    xrAmountInWords.Text = isNegative + Currency_Converter.ConvertToWords(number);
                    // Console.WriteLine("The number in currency fomat is \n{0}", isNegative + Currency_Converter.ConvertToWords(number));
                }
                //Console.ReadKey();
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "REPORT", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                //Console.WriteLine(ex.Message);
            }
        }

        private void vendorLogo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            vendorLogo.ImageUrl = Directory.GetCurrentDirectory() + @"\Assets\Asset 1.png";
        }
    }
}
