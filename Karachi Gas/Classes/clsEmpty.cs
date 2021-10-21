using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Drawing;

namespace Karachi_Gas.Classes
{
    class clsEmpty : AbstractMembers
    {
        int compId; int partyId; int qtyCom; int qtyDom; int qtySmall; bool isSave = false;
        public bool Save(int compId, int partyId, int qtyCom, int qtyDom, int qtySmall)
        {
            this.compId = compId;
            this.partyId = partyId;
            this.qtyCom = qtyCom;
            this.qtyDom = qtyDom;
            this.qtySmall = qtySmall;
            InsertSql();
            return isSave;
        }

        public override void InsertSql()
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                SqlParameter[] parameters = { new SqlParameter {ParameterName = "@CompAccID", Value = compId },
                                                new SqlParameter {ParameterName = "@PartyAccID", Value = partyId},
                                                new SqlParameter {ParameterName = "@QtyC", Value = qtyCom},
                                                new SqlParameter {ParameterName = "@QtyD", Value = qtyDom},
                                                new SqlParameter {ParameterName = "@QtyS", Value = qtySmall},
                                                new SqlParameter {ParameterName = "@Type", Value = "EMP"}
                };
                DBService.ExecuteSP("AddStockDetail", parameters, ref response);
                if (!response.Error)
                {
                    ToastNotification notification = new ToastNotification("Record Saved", Color.Green);
                    notification.Show();
                    isSave = true;
                }
                else
                {
                    XtraMessageBox.Show("EMPTY", response.getErrorMessage());
                    isSave = false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Empty Received", e.Message);
                isSave = false;
            }
        }
    }
}
