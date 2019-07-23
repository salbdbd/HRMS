using System.Collections.Generic;

namespace Hrms.Models
{
   public class AccChartModel
   {
      public int ID { get;set; }
      public int LowergroupID { get;set; }
      public int AccountID { get;set; }
      public string AccountName { get;set; }
      public string AliasName { get;set; }
      public decimal OpenningBalance { get;set; }
      public int CurID { get;set; }
      public decimal ConRate { get;set; }
      public int AccType { get;set; }
      public int Comcod { get;set; }
      public bit isBranch { get;set; }
      public int BranchID { get;set; }
      public bit isSubledger { get;set; }
      public bit isBillbyBill { get;set; }
      public bit isInventory { get;set; }
      public bit isPersonal { get;set; }
      public int BalancType { get;set; }
      public bit isActive { get;set; }
      public int NotetoHead { get;set; }
      public bit isPredefined { get;set; }
      public int PrintPrder { get;set; }
      public string Xparameter { get;set; }
      public DateTime EntryTime { get;set; }
      public decimal DepriciationRate { get;set; }
   }
}