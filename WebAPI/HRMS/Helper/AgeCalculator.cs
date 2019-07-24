using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Helper
{
  public static class AgeCalculator
  {
    public static string CalculateAge(DateTime dateOfBirth)
    {
      DateTime Now = DateTime.Now;
      int Years = new DateTime(DateTime.Now.Subtract(dateOfBirth).Ticks).Year - 1;
      DateTime PastYearDate = dateOfBirth.AddYears(Years);
      int Months = 0;
      for (int i = 1; i <= 12; i++)
      {
        if (PastYearDate.AddMonths(i) == Now)
        {
          Months = i;
          break;
        }
        else if (PastYearDate.AddMonths(i) >= Now)
        {
          Months = i - 1;
          break;
        }
      }
      int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
      int Hours = Now.Subtract(PastYearDate).Hours;
      int Minutes = Now.Subtract(PastYearDate).Minutes;
      int Seconds = Now.Subtract(PastYearDate).Seconds;
      return String.Format(" {0} Years {1} Month {2} Days",
      Years, Months, Days);
    }
  }
}
