using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper.Framework;
using HRMSModelDbCotext.Attendance.Model;


namespace HRMSModelDbCotext.Attendance.DbContext
{
  class ShiftSetup:Connection
  {
    public static bool ShiftSetupSave(ShiftSetupModel shiftSetup )
    {
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("sp_ShiftInfo_New", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", shiftSetup.Id);
            cmd.Parameters.AddWithValue("@ShfitName", shiftSetup.ShfitName);
            cmd.Parameters.AddWithValue("@ShiftStartHour", shiftSetup.ShiftStartHour);
            cmd.Parameters.AddWithValue("@ShiftStartMin", shiftSetup.ShiftStartMin);
            cmd.Parameters.AddWithValue("@ShiftEndtHour", shiftSetup.ShiftEndtHour);
            cmd.Parameters.AddWithValue("@ShiftEndMin", shiftSetup.ShiftEndMin);
            cmd.Parameters.AddWithValue("@MinLogout", shiftSetup.MinLogout);
            cmd.Parameters.AddWithValue("@MaxLogout", shiftSetup.MaxLogout);
            cmd.Parameters.AddWithValue("@MinIntime", shiftSetup.MinIntime);
            cmd.Parameters.AddWithValue("@MaxIntime", shiftSetup.MaxIntime);
            cmd.Parameters.AddWithValue("@Out", shiftSetup.Out);
            cmd.Parameters.AddWithValue("@NextDate", shiftSetup.NextDate);
            cmd.Parameters.AddWithValue("@CompanyID", shiftSetup.CompanyID);
            cmd.Parameters.AddWithValue("@NextShiftID", shiftSetup.NextShiftID);
            cmd.Parameters.AddWithValue("@DutyHours", shiftSetup.DutyHours);
            cmd.Parameters.AddWithValue("@DutyMinute", shiftSetup.DutyMinute);
            cmd.Parameters.AddWithValue("@Msg", shiftSetup.Msg);
            cmd.Parameters.AddWithValue("@pOptions", shiftSetup.pOptions);
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
