using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class VehicleModel
    {
        public int ID { get; set; }
        public string EmpCode { get; set; }
        public DateTime AssainDate { get; set; }
        public int Type{ get; set; }
        public int Active { get; set; }
        public int CompanyID { get; set; }
    }
}
