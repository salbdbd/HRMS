using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Framework;
using HRMSModelDBContext.HR_Menu.Model;

namespace HRMSModelDBContext.HR_Menu.DBContext
{
    class CasualJoining:Connection
    {
        public static bool CasualJoiningSave(CasualJoiningModel casualJoining)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_EmpCasualJoining_Save", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("EmpCode", casualJoining.EmpCode);
                        cmd.Parameters.AddWithValue("JoiningDate", casualJoining.JoiningDate);
                        cmd.Parameters.AddWithValue("CasualJoining", casualJoining.CasualJoining);
                        cmd.Parameters.AddWithValue("Date", casualJoining.Date);
                        cmd.Parameters.AddWithValue("CompanyID", casualJoining.CompanyID);
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
