using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper.Framework;
using HRMSModelDbCotext.Attendance.Model;


namespace HRMSModelDbCotext.Attendance.DbContext
{
  class MonthlyAttendance:Connection

  {
    public static bool Get(MonthlyAttendanceModel monthlyAttendance)
    {
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("spGetAttendenceSummary", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StrDate", monthlyAttendance.StrDate);
            cmd.Parameters.AddWithValue("@EndDate", monthlyAttendance.EndDate);
            cmd.Parameters.AddWithValue("@CompanyID", monthlyAttendance.CompanyID);
            cmd.Parameters.AddWithValue("@Grade", monthlyAttendance.Grade);
            cmd.Parameters.AddWithValue("@Depertment", monthlyAttendance.Depertment);
            cmd.Parameters.AddWithValue("@Branch", monthlyAttendance.Branch);
            cmd.Parameters.AddWithValue("@Project", monthlyAttendance.Project);
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
