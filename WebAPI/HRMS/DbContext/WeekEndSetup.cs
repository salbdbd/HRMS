using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper.Framework;
using HRMSModelDbCotext.Attendance.Model;


namespace HRMSModelDbCotext.Attendance.DbContext
{
  class WeekEndSetup:Connection
  {
    public static bool SaveWeekEndSetup(WeekEndSetupModel weekEndSetup)
    {
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("sp_WeekEndSetup_New", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", weekEndSetup.ID);
            cmd.Parameters.AddWithValue("@EmpCode", weekEndSetup.EmpCode);
            cmd.Parameters.AddWithValue("@WeekEndDay", weekEndSetup.WeekEndDay);
            cmd.Parameters.AddWithValue("@UserID", weekEndSetup.UserID);
            cmd.Parameters.AddWithValue("@CompanyID", weekEndSetup.CompanyID);
            cmd.Parameters.AddWithValue("@GradeValue", weekEndSetup.GradeValue);
            cmd.Parameters.AddWithValue("@DepartmentID", weekEndSetup.DepartmentID);
            cmd.Parameters.AddWithValue("@DesignationID", weekEndSetup.DesignationID);
            cmd.Parameters.AddWithValue("@Location", weekEndSetup.Location);
            cmd.Parameters.AddWithValue("@BranchID", weekEndSetup.BranchID);
            cmd.Parameters.AddWithValue("@Msg", weekEndSetup.Msg);
            cmd.Parameters.AddWithValue("@pOptions", 1);
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
        public static bool Delete(int id)
        {
        using (var conn = new SqlConnection(Connection.ConnectionString()))
        {
            var rowAffect = conn.Execute("DELETE WeekEndSetup WHERE ID=" + id);
            return rowAffect > 0;
        }

        }
        public static bool GetAll(WeekEndSetupModel weekEndSetup)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_WeekEndSetup_New", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", weekEndSetup.ID);
                        cmd.Parameters.AddWithValue("@EmpCode", weekEndSetup.EmpCode);
                        cmd.Parameters.AddWithValue("@WeekEndDay", weekEndSetup.WeekEndDay);
                        cmd.Parameters.AddWithValue("@UserID", weekEndSetup.UserID);
                        cmd.Parameters.AddWithValue("@CompanyID", weekEndSetup.CompanyID);
                        cmd.Parameters.AddWithValue("@GradeValue", weekEndSetup.GradeValue);
                        cmd.Parameters.AddWithValue("@DepartmentID", weekEndSetup.DepartmentID);
                        cmd.Parameters.AddWithValue("@DesignationID", weekEndSetup.DesignationID);
                        cmd.Parameters.AddWithValue("@Location", weekEndSetup.Location);
                        cmd.Parameters.AddWithValue("@BranchID", weekEndSetup.BranchID);
                        cmd.Parameters.AddWithValue("@Msg", weekEndSetup.Msg);
                        cmd.Parameters.AddWithValue("@pOptions", 3);
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
