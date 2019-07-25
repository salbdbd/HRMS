using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper.Framework;
using HRMS.Models;

namespace HRMS.DbContext
{
    public class Vehicle
    {
        public static bool Saveupdate(VehicleModel vehicle)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
                {
                  vehicle.ID,
                vehicle.EmpCode,
                vehicle.AssainDate,
                vehicle.Type,
                vehicle.Active,
                vehicle.CompanyID
            };
            int rowAffect = conn.Execute("INSertCarhouseAssain", param: param,
                commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }

        public static List<VehicleModel> getAll()
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var dateset = conn.Query<VehicleModel>("SELECT * FROM CarhouseAssain").ToList();
            return dateset;
        }

        public static VehicleModel getById(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var vehicle = conn.QuerySingle<VehicleModel>("SELECT * FROM CarhouseAssain WHERE ID="+id);
            return vehicle;
        }

        public static bool delete(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var rowAffect = conn.Execute("DELETE FROM CarhouseAssain WHERE ID="+id);
            return rowAffect > 0;
        }

    }
}
