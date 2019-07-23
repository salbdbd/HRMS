using System.Collections.Generic;

namespace Hrms.Models
{
   public class TransMasterModel
   {
      public int ID { get;set; }
      public int TransNO { get;set; }
      public string vdate { get;set; }
      public string vtype { get;set; }
      public string vno { get;set; }
      public decimal CRate { get;set; }
      public int AccID { get;set; }
      public decimal Amount { get;set; }
      public int RefAccID { get;set; }
      public string SubID { get;set; }
      public int AdSubID { get;set; }
      public int ComCod { get;set; }
      public int BrID { get;set; }
      public int UserID { get;set; }
      public int isPosted { get;set; }
      public int TaxID { get;set; }
      public int VoucherTypeId { get;set; }
      public int MoneyReceiptId { get;set; }
      public int BillModeID { get;set; }
      public decimal BillAmount { get;set; }
      public int IsNormalVoucher { get;set; }
      public string RefNo { get;set; }
      public string Narration { get;set; }
      public int ChqNo { get;set; }
      public string ChqDat { get;set; }
      public int SubAccID { get;set; }
      public DateTime entrydate { get;set; }
   }
}