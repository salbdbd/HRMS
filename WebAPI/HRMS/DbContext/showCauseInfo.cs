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
    class showCauseInfo:Connection
    {
        public static bool showCauseInfoSave(showCauseInfoModel showCauseInfo)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_ShowcaseInser_Update", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", showCauseInfo.ID);
                        cmd.Parameters.AddWithValue("@EmpCode", showCauseInfo.EmpCode);
                        cmd.Parameters.AddWithValue("@Type", showCauseInfo.Type);
                        cmd.Parameters.AddWithValue("@StartDate", showCauseInfo.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", showCauseInfo.EndDate);
                        cmd.Parameters.AddWithValue("@ShowcaseDate", showCauseInfo.ShowcaseDate);
                        cmd.Parameters.AddWithValue("@Action", showCauseInfo.Action);
                        cmd.Parameters.AddWithValue("@UserID", showCauseInfo.UserID);
                        cmd.Parameters.AddWithValue("@CompanyID", showCauseInfo.CompanyID);
                        cmd.Parameters.AddWithValue("@Remarks", showCauseInfo.Remarks);
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
