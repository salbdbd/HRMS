using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models.SyetemSetup
{
  public class BasicEntryModel
  {
    public int ID { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public int SortOrder { get; set; }
    public int CompanyID { get; set; }
    public int ISActive { get; set; }
    public string Address { get; set; }
  }
}
