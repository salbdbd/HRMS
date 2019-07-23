using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models.Leave
{
    public class LeaveBalenceModel
    {
        public string EmpCode { get; set; }
        public int LType { get; set; }
        public int YearID { get; set; }
        public string Qty { get; set; }
        public DateTime DATE { get; set; }
        public string Note { get; set; }
        public int CompanyID { get; set; }
    }
}