using System.Collections.Generic;

namespace Hrms.Models
{
   public class BasicDetailsModel
   {
      public int Id { get;set; }
      public int BasicTbleID { get;set; }
      public int IDbyBasicTble { get;set; }
      public string Description { get;set; }
      public int Tag { get;set; }
   }
}