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
    class Punishment:Connection

    {
    public static bool PunishmentSave(PunishmentModel punishment)
    {
        using (var conn = new SqlConnection(Connection.ConnectionString()))
        {
            conn.Open();
            using (var cmd = new SqlCommand("sp_Punishment", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", punishment.ID);
                    cmd.Parameters.AddWithValue("@EmpCode", punishment.EmpCode);
                    cmd.Parameters.AddWithValue("@DateOfLetterIssue", punishment.DateOfLetterIssue);
                    cmd.Parameters.AddWithValue("@NatureOfPunishmentID", punishment.NatureOfPunishmentID);
                    cmd.Parameters.AddWithValue("@ActionID", punishment.ActionID);
                    cmd.Parameters.AddWithValue("@StartDate", punishment.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", punishment.EndDate);
                    cmd.Parameters.AddWithValue("@sDays", punishment.sDays);
                    cmd.Parameters.AddWithValue("@UserID", punishment.UserID);
                    cmd.Parameters.AddWithValue("@CompanyID", punishment.CompanyID);
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
