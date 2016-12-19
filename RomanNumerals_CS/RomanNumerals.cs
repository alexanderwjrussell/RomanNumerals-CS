using System;

namespace RomanNumerals_CS
{
	public static class RomanNumerals
	{
		public static string Add(string value1, string value2)
		{
			var answer = AddIs(value1, value2);
			return ConvertFromIs(answer);
		}

		public static string AddIs(string value1, string value2)
		{
			var total = ConvertToIs(value1) + ConvertToIs(value2);
			return total;
		}

		public static string ConvertToIs(string number)
		{
			number = number.Replace("V", "IIIII");
			return number;
		}

		public static string ConvertFromIs(string number)
		{
			number = number.Replace("IIIII", "V");
			return number;
		}
	}
}