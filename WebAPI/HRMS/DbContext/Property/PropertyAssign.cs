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
    public class PropertyAssign
    {
        public static bool saveupdate(PropertyAssignModel propertyAssign)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
            {
                propertyAssign.ID,
                propertyAssign.EmpCode,
                propertyAssign.ReciveForm,
                propertyAssign.PropertyID,
                propertyAssign.ModelID,
                propertyAssign.AssainDate,
                propertyAssign.AssainType,
                propertyAssign.Status,
                propertyAssign.CompanyID,
                propertyAssign.OwnershipDate
            };
            var rowAffect = conn.Execute("INSertAssetAssain", param: param, commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }

        public static List<PropertyCatagoryModel> getAll()
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            var dataset = conn.Query<PropertyCatagoryModel>("SELECT * FROM AssetAssain").ToList();
            return dataset;

        }

        public static PropertyCatagoryModel getById(int id)
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            var data = conn.QuerySingle<PropertyCatagoryModel>("SELECT * FROM AssetAssain WHERE ID=" + id);
            return data;
        }

        public static bool Delete(int id)
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            var rowAffect = conn.Execute("DELETE FROM AssetAssain WHERE ID=" + id);
            return rowAffect > 0;
        }
    }
}
