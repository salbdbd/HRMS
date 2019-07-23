using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class PropertyAssignModel
    {
        public int ID { get; set; }
        public string EmpCode { get; set; }
        public string ReciveForm { get; set; }
        public int PropertyID { get; set; }
        public int ModelID { get; set; }
        public DateTime AssainDate { get; set; }
        public int AssainType { get; set; }
        public int Status { get; set; }
        public int CompanyID { get; set; }
        public DateTime OwnershipDate { get; set; }
    }
}