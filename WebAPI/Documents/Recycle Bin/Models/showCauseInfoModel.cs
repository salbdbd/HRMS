using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSModelDBContext.Diciplinary_Action.Model
{
    class showCauseInfoModel
    {
        public int ID { get; set; }
        public string EmpCode { get; set; }
        public int Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ShowcaseDate { get; set; }
        public int Action { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public string Remarks { get; set; }
    }
}
