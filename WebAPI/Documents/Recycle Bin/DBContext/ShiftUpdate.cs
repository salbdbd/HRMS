using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper.Framework;
using HRMSModelDbCotext.Attendance.Model;


namespace HRMSModelDbCotext.Attendance.DbContext
{
  class ShiftUpdate:Connection
  {
    public static bool ShiftUpdateSave(ShiftUpdateModel shiftUpdate )
    {
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("sp_ShiftmanagementInfo_Update", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", shiftUpdate.Id);
            cmd.Parameters.AddWithValue("@ShiftID", shiftUpdate.ShiftID);
            cmd.Parameters.AddWithValue("@EmpCode", shiftUpdate.EmpCode);
            cmd.Parameters.AddWithValue("@ShiftDate", shiftUpdate.ShiftDate);
            cmd.Parameters.AddWithValue("@Note", shiftUpdate.Note);
            cmd.Parameters.AddWithValue("@DDMMYYYY", shiftUpdate.DDMMYYYY);
            cmd.Parameters.AddWithValue("@NextDate", shiftUpdate.NextDate);
            cmd.Parameters.AddWithValue("@ShiftIDRostaring", shiftUpdate.ShiftIDRostaring);
            cmd.Parameters.AddWithValue("@CompanyID", shiftUpdate.CompanyID);
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
