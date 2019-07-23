using System.Collections.Generic;

namespace Hrms.Models
{
   public class NoticeDayModel
   {
      public int ID { get;set; }
      public int Grade { get;set; }
      public int EmpDay { get;set; }
      public int Day { get;set; }
      public DateTime SDate { get;set; }
      public string Note { get;set; }
      public int CompanyID { get;set; }
   }
}