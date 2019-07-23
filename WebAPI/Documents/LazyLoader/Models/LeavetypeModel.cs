using System.Collections.Generic;

namespace Hrms.Models
{
   public class LeavetypeModel
   {
      public int ID { get;set; }
      public string TypeName { get;set; }
      public int MaxDays { get;set; }
      public int Typeee { get;set; }
      public string Shortn { get;set; }
      public int GradeValue { get;set; }
      public int SortOrder { get;set; }
      public int ApplyMax { get;set; }
      public int UserID { get;set; }
      public int ISActive { get;set; }
   }
}