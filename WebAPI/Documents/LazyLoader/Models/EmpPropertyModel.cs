using System.Collections.Generic;

namespace Hrms.Models
{
   public class EmpPropertyModel
   {
      public int ID { get;set; }
      public string EmpCode { get;set; }
      public int PropertyID { get;set; }
      public string Brand { get;set; }
      public string Model { get;set; }
      public string Number { get;set; }
      public string Accessories { get;set; }
      public DateTime Date { get;set; }
      public int Statue { get;set; }
      public int CompanyID { get;set; }
   }
}