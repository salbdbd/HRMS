using System.Collections.Generic;

namespace Hrms.Models
{
   public class sysdiagramsModel
   {
      public sysname name { get;set; }
      public int principal_id { get;set; }
      public int diagram_id { get;set; }
      public int version { get;set; }
      public byte[] definition { get;set; }
   }
}