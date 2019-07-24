using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSModelDBContext.HR_Menu.Model
{
    class EmployeePromotionModel
    {
        public string EmpCode { get; set; }
        public int PreCompanyID { get; set; }
        public int PreDepartmentID { get; set; }
        public int PreProjectID { get; set; }
        public int PreDesignationID { get; set; }
        public int PreDivisionID { get; set; }
        public int PreBranchID { get; set; }
        public int PreUnit { get; set; }
        public int PreLocation { get; set; }
        public int PreGrade { get; set; }
        public int PrePayscaleGrade { get; set; }
        public string PasCompanyID { get; set; }
        public string PasDepartmentID { get; set; }
        public string PasProjectID { get; set; }
        public string PasDesignationID { get; set; }
        public string PasDivisionID { get; set; }
        public string PasBranchID { get; set; }
        public int PasUnit { get; set; }
        public int PasLocation { get; set; }
        public int PasGrade { get; set; }
        public int PasPayscaleGrade { get; set; }
        public string Note { get; set; }
        public DateTime TransferDate { get; set; }
        public int TPType { get; set; }
        public int CompanyID { get; set; }
        public string jobresponsibilities { get; set; }
    }
}
