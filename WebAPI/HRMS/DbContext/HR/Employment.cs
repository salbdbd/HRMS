using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper.Framework;
using HRMS.Models;
using HRMS.Models.HR;
using HRMS.ViewModels;

namespace HRMS.DbContext.HR
{
  public class Employment
  {
    public static EmploymentViewModel GetEmployment(string empCode,int companyID)
    {
      var conn = new SqlConnection(Connection.ConnectionString());
      var paramObj = new
      {
        EmpCode=empCode,
        CompanyID=companyID
      };
      var dateset = conn.QuerySingle<EmploymentViewModel>("sp_GetEmployment",param:paramObj,commandType:CommandType.StoredProcedure);
      return dateset;
    }
  }
}
