using System;

namespace PatientDemo.Domain.Utilities
{
	public static class AgeCalculator
	{
		public static string Calculate(DateTime Tdate, DateTime DOB)
		{
			int year = 0;
			int month = 0;

			if (Tdate.Month < DOB.Month)
			{
				int y1 = Tdate.Year - 1;
				year = y1 - DOB.Year;
				int m1 = 12 - DOB.Month;
				month = m1 + Tdate.Month;
			}

			if (DOB.Month < Tdate.Month)
			{
				year = Tdate.Year - DOB.Year;
				month = Tdate.Month - DOB.Month;
			}

			if (Tdate.Month == DOB.Month)
			{
				year = Tdate.Year - DOB.Year;
			}

			return string.Format("Age : {0} years {1} months", year, month);
		}
	}
}
