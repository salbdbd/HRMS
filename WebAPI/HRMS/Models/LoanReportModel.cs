﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSModelDBContext.Loan.Model
{
    class LoanReportModel
    {
        public int id { get; set; }
        public string EmpCode { get; set; }
        public string PaymentDate { get; set; }
        public int SalaryHeadID { get; set; }
        public decimal PrincipleAmount { get; set; }
        public decimal Interest { get; set; }
        public decimal NetPayment { get; set; }
        public string Remarks { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
    }
}
