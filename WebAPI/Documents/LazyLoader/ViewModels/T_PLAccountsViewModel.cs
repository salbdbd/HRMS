using System.Collections.Generic;

namespace Hrms.ViewModels
{
   public class T_PLAccountsViewModel
   {
      public int AccountID { get;set; }
      public string AccountName { get;set; }
      public string AliasName { get;set; }
      public int AccType { get;set; }
      public string Expr1 { get;set; }
      public int PrintOrderTrad { get;set; }
      public int PrintOrderPL { get;set; }
      public string GroupName { get;set; }
      public int PrintOrder { get;set; }
      public string MidGrp { get;set; }
      public int PLGPFunction1 { get;set; }
      public int PLGPFunction { get;set; }
      public int Comcod { get;set; }
      public int IsBalanceSheetItem { get;set; }
   }
}