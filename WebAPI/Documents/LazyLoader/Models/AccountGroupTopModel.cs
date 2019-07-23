using System.Collections.Generic;

namespace Hrms.Models
{
   public class AccountGroupTopModel
   {
      public int ID { get;set; }
      public string GroupCode { get;set; }
      public string GroupName { get;set; }
      public int IsDebtors { get;set; }
      public int IsBalanceSheetItem { get;set; }
      public int PrintOrder { get;set; }
      public int IsBalanceSheet1 { get;set; }
      public nchar fff { get;set; }
   }
}