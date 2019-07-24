using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Framework;
using HRMSModelDBContext.HR_Menu.Model;

namespace HRMSModelDBContext.HR_Menu.DBContext
{
    class EmployeePromotion :Connection
    {
        public static bool Save(EmployeePromotionModel employeePromotion)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_EmpTransfer_Save", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("EmpCode", employeePromotion.EmpCode);
                        cmd.Parameters.AddWithValue("PreCompanyID", employeePromotion.PreCompanyID);
                        cmd.Parameters.AddWithValue("PreDepartmentID", employeePromotion.PreDepartmentID);
                        cmd.Parameters.AddWithValue("PreProjectID", employeePromotion.PreProjectID);
                        cmd.Parameters.AddWithValue("PreDesignationID", employeePromotion.PreDesignationID);
                        cmd.Parameters.AddWithValue("PreDivisionID", employeePromotion.PreDivisionID);
                        cmd.Parameters.AddWithValue("PreBranchID", employeePromotion.PreBranchID);
                        cmd.Parameters.AddWithValue("PreUnit", employeePromotion.PreUnit);
                        cmd.Parameters.AddWithValue("PreLocation", employeePromotion.PreLocation);
                        cmd.Parameters.AddWithValue("PreGrade", employeePromotion.PreGrade);
                        cmd.Parameters.AddWithValue("PrePayscaleGrade", employeePromotion.PrePayscaleGrade);
                        cmd.Parameters.AddWithValue("PasCompanyID", employeePromotion.PasCompanyID);
                        cmd.Parameters.AddWithValue("PasDepartmentID", employeePromotion.PasDepartmentID);
                        cmd.Parameters.AddWithValue("PasProjectID", employeePromotion.PasProjectID);
                        cmd.Parameters.AddWithValue("PasDesignationID", employeePromotion.PasDesignationID);
                        cmd.Parameters.AddWithValue("PasDivisionID", employeePromotion.PasDivisionID);
                        cmd.Parameters.AddWithValue("PasBranchID", employeePromotion.PasBranchID);
                        cmd.Parameters.AddWithValue("PasUnit", employeePromotion.PasUnit);
                        cmd.Parameters.AddWithValue("PasLocation", employeePromotion.PasLocation);
                        cmd.Parameters.AddWithValue("PasGrade", employeePromotion.PasGrade);
                        cmd.Parameters.AddWithValue("PasPayscaleGrade", employeePromotion.PasPayscaleGrade);
                        cmd.Parameters.AddWithValue("Note", employeePromotion.Note);
                        cmd.Parameters.AddWithValue("TransferDate", employeePromotion.TransferDate);
                        cmd.Parameters.AddWithValue("TPType", employeePromotion.TPType);
                        cmd.Parameters.AddWithValue("CompanyID", employeePromotion.CompanyID);
                        cmd.Parameters.AddWithValue("jobresponsibilities", employeePromotion.jobresponsibilities);
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
