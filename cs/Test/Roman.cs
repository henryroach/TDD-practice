using System;
using Xunit;

public class RomanTest
{
	[Fact]
	public void TestShouldBeWorking()
	{
		Assert.Equal(1, 1);
	}

	// [Fact]
	// public void ShouldNotAcceptNonNumbers()
	// {
	// 	var exception = Assert.Throws<ArgumentException>(() => Roman.toRoman("Not a number"));
	// 	Assert.Contains("Not a number", exception.Message);
	// }

	// [Fact]
	// public void ShouldNotAcceptNumbersBelowOne()
	// {
	// 	var exception = Assert.Throws<ArgumentException>(() => Roman.toRoman("0"));
	// 	Assert.Contains("Too small", exception.Message);
	// }

	// [Fact]
	// public void ShouldConvertSmallNumberToRoman()
	// {
	// 	var romanValue = Roman.toRoman("1");
	// 	Assert.Equal("I", romanValue);
	// }

	// [Fact]
	// public void ShouldConvertNumberThatRequiresAdditionToRoman()
	// {
	// 	var romanValue = Roman.toRoman("15");
	// 	Assert.Equal("XV", romanValue);
	// }

	// [Fact]
	// public void ShouldConvertNumberThatRequiresSubtractionToRoman()
	// {
	// 	var romanValue = Roman.toRoman("4");
	// 	Assert.Equal("IV", romanValue);
	// }

	// [Fact]
	// public void ShouldConvertLargeNumberToRoman()
	// {
	// 	var romanValue = Roman.toRoman("1776");
	// 	Assert.Equal("MDCCLXXVI", romanValue);
	// }

	// [Fact]
	// public void ShoudHandleShortHand()
	// {
	// 	var romanValue = Roman.toRoman("94");
	// 	Assert.Equal("XCIV", romanValue);
	// }

	// [Fact]
	// public void ShouldConvertSmallRomanValueToDecimal()
	// {
	// 	var decimalValue = Roman.toDecimal("I");
	// 	Assert.Equal(1, decimalValue);
	// }

	// [Fact]
	// public void ShouldHandleDecimalConversionThatNeedsAddition()
	// {
	// 	var decimalValue = Roman.toDecimal("XV");
	// 	Assert.Equal(15, decimalValue);
	// }

	// [Fact]
	// public void ShouldHandleDecimalConversionThatNeedsSubtraction()
	// {
	// 	var decimalValue = Roman.toDecimal("IV");
	// 	Assert.Equal(4, decimalValue);
	// }

	// [Fact]
	// public void ShouldConvertLargeNumberToDecimal()
	// {
	// 	var decimalValue = Roman.toDecimal("MDCCLXXVI");
	// 	Assert.Equal(1776, decimalValue);
	// }

	// [Fact]
	// public void ShouldHandleRandomNumber()
	// {
	// 	var decimalValue = new Random().Next();
	// 	var romanValue = Roman.toRoman($"{decimalValue}");

	// 	Assert.Equal(Roman.toDecimal(romanValue), decimalValue);
	// }
}


