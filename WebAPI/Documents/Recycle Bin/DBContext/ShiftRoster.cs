using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper.Framework;
using HRMSModelDbCotext.Attendance.Model;
 

namespace HRMSModelDbCotext.Attendance.DbContext
{
  class ShiftRoster:Connection
  {
    public static bool ShiftRosterSave(ShiftRosterModel shiftRoster)
    {
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("sp_ShiftmanagementInfo_Insert", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShiftID", shiftRoster.ShiftID);
            cmd.Parameters.AddWithValue("@EmpCode", shiftRoster.EmpCode);
            cmd.Parameters.AddWithValue("@ShiftDate", shiftRoster.ShiftDate);
            cmd.Parameters.AddWithValue("@Note", shiftRoster.Note);
            cmd.Parameters.AddWithValue("@DDMMYYYY", shiftRoster.DDMMYYYY);
            cmd.Parameters.AddWithValue("@NextDate", shiftRoster.NextDate);
            cmd.Parameters.AddWithValue("@ShiftIDRostaring", shiftRoster.ShiftIDRostaring);
            cmd.Parameters.AddWithValue("@CompanyID", shiftRoster.CompanyID);
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
