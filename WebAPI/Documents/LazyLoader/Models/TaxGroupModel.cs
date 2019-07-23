using System.Collections.Generic;

namespace Hrms.Models
{
   public class TaxGroupModel
   {
      public int ID { get;set; }
      public string GroupName { get;set; }
      public string BankName { get;set; }
      public string Branch { get;set; }
      public string Account { get;set; }
      public string Tin { get;set; }
      public string Zone { get;set; }
      public string Circle { get;set; }
      public int CompanyID { get;set; }
   }
}