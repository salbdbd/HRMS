using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models.ShiftAllowance
{
    public class ShiftAmountSetupModel
    {
        public int ID { get; set; }
        public int EmpType { get; set; }
        public int SHiftID { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
    }
}