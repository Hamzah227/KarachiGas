using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Drawing;

namespace Karachi_Gas.Classes
{
    class clsTransactions: AbstractMembers
    {
        bool isSaved = true;
        Int64 compAcc; int tranType; Int64 debitAccId; Int64 creditAccId; decimal amount; string narration; bool isPaidToCompany;
        public bool SaveTransactionNew(Int64 compAcc, int tranType, Int64 debitAccId, Int64 creditAccId, decimal amount, string narration, bool isPaidToCompany)
        {
            this.compAcc = compAcc; this.tranType = tranType; this.debitAccId = debitAccId; this.creditAccId = creditAccId; 
            this.amount = amount; this.narration = narration; this.isPaidToCompany = isPaidToCompany;

            InsertSql();
            if (isSaved)
            {
                return true;
            }
            return false;
        }


        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter { ParameterName = "@Narration", Value = narration },
                                                new SqlParameter { ParameterName = "@DebitID", Value = debitAccId },
                                                new SqlParameter { ParameterName = "@CreditID", Value = creditAccId },
                                                new SqlParameter { ParameterName = "@Amount", Value = amount }
                                                //new SqlParameter { ParameterName = "@tranType", Value = 1}
                };
                DBService.ExecuteSP("AddTransfer", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification toastNotification = new ToastNotification("Success", Color.Green);
                    toastNotification.Show();
                    isSaved = true;
                }
                else
                {
                    XtraMessageBox.Show(response.getErrorMessage(), "Transactions");
                    isSaved = false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("TRANSACTIONS", e.Message);
                isSaved = false;
            }
        }
    }
}
