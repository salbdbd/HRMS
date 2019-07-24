using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class PropertyDisposalModel
    {
        public int ID { get; set; }
        public string  EmpCode { get; set; }
        public int PropertyId { get; set; }
        public int ModelID { get; set; }
        public DateTime DisposeDate { get; set; }
        public string DisType { get; set; }
        public string Note { get; set; }
        public int CompanyID { get; set; }
    }
}