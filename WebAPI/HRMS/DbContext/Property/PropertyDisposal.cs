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
    public class PropertyDisposal
    {
        public static bool saveUpdate(PropertyDisposalModel propertyDisposal)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
            {
                propertyDisposal.ID,
                propertyDisposal.EmpCode,
                propertyDisposal.PropertyId,
                propertyDisposal.ModelID,
                propertyDisposal.DisposeDate,
                propertyDisposal.DisType,
                propertyDisposal.Note,
                propertyDisposal.CompanyID
            };
            var rowAffect = conn.Execute("INSertAssetDispose", param: param, commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }
        public static List<PropertyDisposalModel> GetAll()
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var dataset = conn.Query<PropertyDisposalModel>("SELECT * FROM AssetDispose").ToList();
            return (dataset);
        }

        public static PropertyDisposalModel GetById(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var catagory = conn.QuerySingle<PropertyDisposalModel>("SELECT * FROM AssetDispose WHERE ID=" + id);
            return catagory;
        }

        public static bool Delete(int id)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var rowAffect = conn.Execute("DELETE AssetDispose WHERE ID=" + id);
            return rowAffect > 0;
        }

    }
}
