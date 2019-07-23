using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSModelDBContext.HR_Menu.Model
{
    class CasualJoiningModel
    {
        public string EmpCode { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime CasualJoining { get; set; }
        public DateTime Date { get; set; }
        public int CompanyID { get; set; }
    }
}
