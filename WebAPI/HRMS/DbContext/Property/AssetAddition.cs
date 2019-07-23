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
    public class AssetAddition
    {
        public static bool Saveupdate(AssetAdditionModel additionModel)
        {
            var conn = new SqlConnection(Connection.ConnectionString());
            var param = new
            {
                additionModel.ID,
                additionModel.AssetID,
                additionModel.Model,
                additionModel.Serial,
                additionModel.PurchesPrice,
                additionModel.Confiruration,
                additionModel.WarrentyType,
                additionModel.Purchesate,
                additionModel.Warrentydate,
                additionModel.Note,
                additionModel.Isactive,
                additionModel.CompanyID
            };
            int rowAffect = conn.Execute("INSertAssetSetup", param: param,
                commandType: CommandType.StoredProcedure);
            return rowAffect > 0;
        }

        public static List<AssetAdditionModel> getAll()
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            var dataset = conn.Query<AssetAdditionModel>("SELECT * FROM AssetSetup ORDER BY ID DESC").ToList();
            return (dataset);
        }

        public static AssetAdditionModel getById(int id)
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            var rowAffect = conn.QuerySingle<AssetAdditionModel>("SELECT * FROM view_get_asset WHERE ID=" + id);
            return rowAffect;
        }

        public static bool delete(int id)
        {
            var conn=new SqlConnection(Connection.ConnectionString());
            int varAffect = conn.Execute("DELETE AssetSetup WHERE ID="+id);
            return varAffect > 0;
        }
    }
}
