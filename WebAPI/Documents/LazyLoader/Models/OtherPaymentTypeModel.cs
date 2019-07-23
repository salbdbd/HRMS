using System.Collections.Generic;

namespace Hrms.Models
{
   public class OtherPaymentTypeModel
   {
      public int ID { get;set; }
      public string PaymentType { get;set; }
      public decimal Persent { get;set; }
      public int SalaryID { get;set; }
   }
}