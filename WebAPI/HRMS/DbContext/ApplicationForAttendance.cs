using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper.Framework;
using HRMSModelDbCotext.Attendance.Model;


namespace HRMSModelDbCotext.Attendance.DbContext
{
  class ApplicationForAttendance:Connection
  {
    public static bool SaveAttendance(ApplicationForAttendanceModel afAttendance )
    {
     
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("sp_AttendanceApplication_New", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@ID", afAttendance.ID);
            cmd.Parameters.AddWithValue("@EmpCode", afAttendance.EmpCode);
            cmd.Parameters.AddWithValue("@Reason", afAttendance.Reason);
            cmd.Parameters.AddWithValue("@AttnDate", afAttendance.AttnDate);
            cmd.Parameters.AddWithValue("@InTime", afAttendance.InTime);
            cmd.Parameters.AddWithValue("@OutTime", afAttendance.OutTime);
            cmd.Parameters.AddWithValue("@ApproveType", afAttendance.ApproveType);
            cmd.Parameters.AddWithValue("@UserID", afAttendance.UserID);
            cmd.Parameters.AddWithValue("@CompanyID", afAttendance.CompanyID);
            cmd.Parameters.AddWithValue("@AttendanceID", afAttendance.AttendanceID);
            cmd.Parameters.AddWithValue("@ReqFrom", afAttendance.ReqFrom);
            cmd.Parameters.AddWithValue("@ReqTo", afAttendance.ReqTo);
            cmd.Parameters.AddWithValue("@Msg", afAttendance.Msg);
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

    public static bool UpdateAttendance(ApplicationForAttendanceModel afAttendance )
    {
     
      using (var conn = new SqlConnection(Connection.ConnectionString()))
      {
        conn.Open();
        using (var cmd = new SqlCommand("sp_AttendanceApplication_New", conn))
        {
          try
          {
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@ID", afAttendance.ID);
            cmd.Parameters.AddWithValue("@EmpCode", afAttendance.EmpCode);
            cmd.Parameters.AddWithValue("@Reason", afAttendance.Reason);
            cmd.Parameters.AddWithValue("@AttnDate", afAttendance.AttnDate);
            cmd.Parameters.AddWithValue("@InTime", afAttendance.InTime);
            cmd.Parameters.AddWithValue("@OutTime", afAttendance.OutTime);
            cmd.Parameters.AddWithValue("@ApproveType", afAttendance.ApproveType);
            cmd.Parameters.AddWithValue("@UserID", afAttendance.UserID);
            cmd.Parameters.AddWithValue("@CompanyID", afAttendance.CompanyID);
            cmd.Parameters.AddWithValue("@AttendanceID", afAttendance.AttendanceID);
            cmd.Parameters.AddWithValue("@ReqFrom", afAttendance.ReqFrom);
            cmd.Parameters.AddWithValue("@ReqTo", afAttendance.ReqTo);
            cmd.Parameters.AddWithValue("@Msg", afAttendance.Msg);
            cmd.Parameters.AddWithValue("@pOptions", 2);
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
            var rowAffect = conn.Execute("DELETE AttendanceApplication WHERE ID=" + id);
            return rowAffect > 0;
        }
        
    }

    public static List<ApplicationForAttendanceModel> Get()
    {
        using (var conn=new SqlConnection(Connection.ConnectionString()))
        {
            var employee = conn.Query<ApplicationForAttendanceModel>("SELECT * from AttendanceApplication WHERE CompanyID=@CompanyID AND EmpCode=@EmpCode;").ToList();
            
            return employee ;
        }
    }
  }
}
