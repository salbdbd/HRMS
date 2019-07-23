using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Framework;
using HRMSModelDBContext.Diciplinary_Action.Model;

namespace HRMSModelDBContext.Diciplinary_Action.DBContext
{
    class showCauseResult :Connection
    {
        public static bool showCauseResultSave(showCauseResultModel showCauseResult)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_ShowCauseResult", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", showCauseResult.ID);
                        cmd.Parameters.AddWithValue("@EmpCode", showCauseResult.EmpCode);
                        cmd.Parameters.AddWithValue("@ShowCauseTypeID", showCauseResult.ShowCauseTypeID);
                        cmd.Parameters.AddWithValue("@ShowCauseResultID", showCauseResult.ShowCauseResultID);
                        cmd.Parameters.AddWithValue("@StartDate", showCauseResult.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", showCauseResult.EndDate);
                        cmd.Parameters.AddWithValue("@Date", showCauseResult.Date);
                        cmd.Parameters.AddWithValue("@Note", showCauseResult.Note);
                        cmd.Parameters.AddWithValue("@UserID", showCauseResult.UserID);
                        cmd.Parameters.AddWithValue("@CompanyID", showCauseResult.CompanyID);
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
