using System.Collections.Generic;

namespace Hrms.Models
{
   public class SerialSettingModel
   {
      public int ID { get;set; }
      public nchar VoucherType { get;set; }
      public int Vno { get;set; }
      public int Comcod { get;set; }
      public int BrId { get;set; }
      public string Vdate { get;set; }
      public int NumberType { get;set; }
   }
}