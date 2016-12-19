using NUnit.Framework;
using System;
namespace RomanNumerals_CS
{
	[TestFixture]
	public class RomanNumeralsTest
	{
		[TestCase("I", "I", "II")]
		[TestCase("I", "II", "III")]
		[TestCase("II", "II", "IV")]
		[TestCase("IIII", "I", "V")]
		[TestCase("V", "I", "VI")]
		[TestCase("V", "V", "X")]
		[TestCase("XVI", "XVI", "XXXII")]
		[TestCase("XX", "XXX", "L")]
		[TestCase("L", "L", "C")]
		[TestCase("CLI", "CCCV", "CCCCLVI")]
		[TestCase("CCC", "CC", "D")]
		[TestCase("D", "D", "M")]
		[TestCase("MD", "DXVI", "MMXVI")]
		public void Should_ReturnCorrectValue(string value1, string value2, string result)
		{
			Assert.That(RomanNumerals.Add(value1, value2), Is.EqualTo(result));
		}
	}
}
