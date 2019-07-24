using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Framework;
using HRMSModelDBContext.Loan.Model;

namespace HRMSModelDBContext.Loan.DBContext
{
    class LoanReport:Connection
    {
        public static bool LoanReportSave(LoanReportModel loanReport)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("INSertLoanCashPayment", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("id", loanReport.id);
                        cmd.Parameters.AddWithValue("EmpCode", loanReport.EmpCode);
                        cmd.Parameters.AddWithValue("PaymentDate", loanReport.PaymentDate);
                        cmd.Parameters.AddWithValue("SalaryHeadID", loanReport.SalaryHeadID);
                        cmd.Parameters.AddWithValue("PrincipleAmount", loanReport.PrincipleAmount);
                        cmd.Parameters.AddWithValue("Interest", loanReport.Interest);
                        cmd.Parameters.AddWithValue("NetPayment", loanReport.NetPayment);
                        cmd.Parameters.AddWithValue("Remarks", loanReport.Remarks);
                        cmd.Parameters.AddWithValue("UserID", loanReport.UserID);
                        cmd.Parameters.AddWithValue("CompanyID", loanReport.CompanyID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
