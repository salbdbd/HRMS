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
    public class ShiftAllowanceAuto
    {
        public static bool SaveUpdate(AutoMenualModel auto)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
            {
                auto.ID,
                auto.EmpCode,
                auto.PeriodID,
                auto.SalaryHeadID,
                auto.Amount,
                auto.OTPP,
                auto.BonusType,
                auto.Date,
                auto.CompanyID,
                auto.DepertmentID
            };
            int rowAffect = conn.Execute("sp_InsertOTAmount", param: param,
                commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }

        public static List<AutoMenualModel> GetAll()
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var dataset = conn.Query<AutoMenualModel>("SELECT * FROM OtherPayment").ToList();
            return dataset;
        }
        public static AutoMenualModel GetById(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var payment = conn.QuerySingle<AutoMenualModel>("SELECT * FROM OtherPayment WHERE ID="+id);
            return payment;
        }
        public static bool Delete(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            int result = conn.Execute("DELETE OtherPayment WHERE ID=" + id);
            return result>0;
        }
    }
}
