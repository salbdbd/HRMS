using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper.Framework;
using HRMS.Models.ShiftAllowance;

namespace HRMS.DbContext.ShiftAllowance
{
    public class AssignShiftAllowance
    {
        public static bool Save(AssignShiftAllowanceModel assignShift)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
            {
                assignShift.EmpCode,
                assignShift.CreateUser,
                assignShift.ActiveType,
                assignShift.CompanyID
            };
            int rowAffect = conn.Execute("sp_ShiftAllowanceAssain_Insert", param: param,
                commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }

        public static bool Update(AssignShiftAllowanceModel assignShift)
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            string sql = "UPDATE ShiftAllowanceAssain Set EmpCode='"+assignShift.EmpCode+ "',ActiveType='"+assignShift.ActiveType+"',CreateUser='"+assignShift.CreateUser+"',SystemDate='"+assignShift.SystemDate+"',CompanyID='"+assignShift.CompanyID+"'WHERE ID="+assignShift.ID;
            int rowAffect = conn.Execute(sql);
            return rowAffect > 0;
        }

        public static List<AssignShiftAllowanceModel> GetAll()
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            var dataset = conn.Query<AssignShiftAllowanceModel>("SELECT * FROM ShiftAllowanceAssain ").ToList();
            return dataset;
        }

        public static AssignShiftAllowanceModel GetById(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var dataset = conn.QuerySingle<AssignShiftAllowanceModel>("SELECT * FROM ShiftAllowanceAssain WHERE ID="+id);
            return dataset;
        }

        public static bool Delete(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            int rowAffect = conn.Execute("DELETE ShiftAllowanceAssain WHERE ID = "+id);
            return rowAffect > 0;
        }
    }
}
