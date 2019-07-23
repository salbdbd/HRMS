using System.Collections.Generic;

namespace Hrms.Models
{
   public class TourDetailsModel
   {
      public int ID { get;set; }
      public int TourID { get;set; }
      public int Empcode { get;set; }
      public DateTime TourDate { get;set; }
   }
}