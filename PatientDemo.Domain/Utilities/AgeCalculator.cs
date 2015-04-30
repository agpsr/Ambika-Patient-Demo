using System;

namespace PatientDemo.Domain.Utilities
{
	public static class AgeCalculator
	{
		public static string Calculate(DateTime Tdate, DateTime DOB)
		{
			int year = 0;
			int month;

			if (Tdate.Month < DOB.Month)
			{
				int y1 = Tdate.Year - 1;
				year = y1 - DOB.Year;
			}

			if ((Tdate.Month == DOB.Month) || (DOB.Month < Tdate.Month))
			{
				year = Tdate.Year - DOB.Year;
			}

			int m1 = 12 - DOB.Month;
			month = m1 + Tdate.Month;

			return string.Format("Age : {0} years {1} months", year, month);
		}
	}
}
