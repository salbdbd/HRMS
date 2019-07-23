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
    public class ShiftAmountSetup
    {
        public static bool Saveupdate(ShiftAmountSetupModel shiftAmount)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
            {
                shiftAmount.ID,
                shiftAmount.UserID,
                shiftAmount.EmpType,
                shiftAmount.Amount,
                shiftAmount.SHiftID,
                shiftAmount.CompanyID
            };
            int rowAffect = conn.Execute("INSertShiftAllowanceSetup", param: param,
                commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }

        public static List<ShiftAmountSetupModel> GetAll()
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var dataset = conn.Query<ShiftAmountSetupModel>("SELECT * FROM ShiftAllowanceSetup").ToList();
            return (dataset);
        }

        public static ShiftAmountSetupModel GetById(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var setupdata = conn.QuerySingle<ShiftAmountSetupModel>("SELECT * FROM ShiftAllowanceSetup WHERE ID=" + id);
            return setupdata;
        }

        public static bool Delete(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var rowAffect = conn.Execute("DELETE FROM ShiftAllowanceSetup WHERE ID=" + id);
            return rowAffect > 0;
        }
    }
}
