using System.Collections.Generic;

namespace Hrms.Models
{
   public class AccountGroupLowerModel
   {
      public int ID { get;set; }
      public int MidGrpId { get;set; }
      public string GroupName { get;set; }
      public string GroupCode { get;set; }
      public string AliasGroupNameB { get;set; }
      public decimal Amount { get;set; }
      public bit IsPreDefined { get;set; }
      public int PrintOrder { get;set; }
      public int UserID { get;set; }
      public bit iSBankCash { get;set; }
      public string BalancesheetCaption { get;set; }
      public string PLCaption { get;set; }
      public string ManuCation { get;set; }
      public string IncomeCation { get;set; }
      public string FundFlowCaption { get;set; }
      public string CasFlowCaption { get;set; }
      public int CashFGroup { get;set; }
      public int AcTyp { get;set; }
      public int Comcod { get;set; }
      public string Notes { get;set; }
      public decimal UptoConversion { get;set; }
      public string SheduleCaption { get;set; }
      public int AutoID { get;set; }
      public string IncomeMainGroup { get;set; }
      public int IncomePrintOder { get;set; }
      public int IncomeAction { get;set; }
      public int PLGPFunction { get;set; }
      public int PLGPFunction1 { get;set; }
      public string TradingCap1 { get;set; }
      public string TradingCAP2 { get;set; }
      public int TradingPOrder { get;set; }
      public int autoInt { get;set; }
      public int isBalancesheet { get;set; }
   }
}