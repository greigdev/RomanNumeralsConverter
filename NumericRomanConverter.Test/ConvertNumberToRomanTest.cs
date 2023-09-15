using FluentAssertions;

namespace NumericRomanConverter.Test;

public class ConvertNumberToRomanTest
{
    private readonly ConvertNumberToRoman _converterUnderTest = new();

    [Fact]
    public void GivenInputNumber3_WhenGetNumericValueUnits_ThenNumericValueUnitsShouldBeInitialised()
    {
        var inputNumber = 3;
        var expectedUnits = new NumericValueUnits { Ones = 3 };

        var result = _converterUnderTest.GetNumericValueUnits(inputNumber);

        result.Thousands.Should().Be(0);
        result.Hundreds.Should().Be(0);
        result.Tens.Should().Be(0);
        result.Ones.Should().Be(expectedUnits.Ones);
    }

    [Fact]
    public void GivenInputNumber20_WhenGetNumericValueUnits_ThenNumericValueUnitsShouldBeInitialised()
    {
        var inputNumber = 20;
        var expectedUnits = new NumericValueUnits { Tens = 2 };

        var result = _converterUnderTest.GetNumericValueUnits(inputNumber);

        result.Thousands.Should().Be(0);
        result.Hundreds.Should().Be(0);
        result.Tens.Should().Be(expectedUnits.Tens);
        result.Ones.Should().Be(0);
    }

    [Fact]
    public void GivenInputNumber300_WhenGetNumericValueUnits_ThenNumericValueUnitsShouldBeInitialised()
    {
        var inputNumber = 300;
        var expectedUnits = new NumericValueUnits { Hundreds = 3 };

        var result = _converterUnderTest.GetNumericValueUnits(inputNumber);

        result.Thousands.Should().Be(0);
        result.Hundreds.Should().Be(expectedUnits.Hundreds);
        result.Tens.Should().Be(0);
        result.Ones.Should().Be(0);
    }

    [Fact]
    public void GivenInputNumber3000_WhenGetNumericValueUnits_ThenNumericValueUnitsShouldBeInitialised()
    {
        var inputNumber = 3000;
        var expectedUnits = new NumericValueUnits { Thousands = 3 };

        var result = _converterUnderTest.GetNumericValueUnits(inputNumber);

        result.Thousands.Should().Be(expectedUnits.Thousands);
        result.Hundreds.Should().Be(0);
        result.Tens.Should().Be(0);
        result.Ones.Should().Be(0);
    }

    [Fact]
    public void GivenInputNumber3421_WhenGetNumericValueUnits_ThenNumericValueUnitsShouldBeInitialised()
    {
        var inputNumber = 3421;
        var expectedUnits = new NumericValueUnits { Thousands = 3, Hundreds = 4, Tens = 2, Ones = 1 };

        var result = _converterUnderTest.GetNumericValueUnits(inputNumber);

        result.Thousands.Should().Be(expectedUnits.Thousands);
        result.Hundreds.Should().Be(expectedUnits.Hundreds);
        result.Tens.Should().Be(expectedUnits.Tens);
        result.Ones.Should().Be(expectedUnits.Ones);
    }

    [Fact]
    public void GivenNumericValueUnits_WhenGetRomanNumeralUnits_ThenRomanNumeralUnitsShouldBeInitialised()
    {
        var inputNumber = new NumericValueUnits { Thousands = 2, Hundreds = 8, Tens = 6, Ones = 3 };

        var expectedUnits = new RomanNumeralUnits { Thousands = "MM", Hundreds = "DCCC", Tens = "LX", Ones = "III" };

        var result = _converterUnderTest.GetRomanNumeralUnits(inputNumber);

        result.Thousands.Should().Be(expectedUnits.Thousands);
        result.Hundreds.Should().Be(expectedUnits.Hundreds);
        result.Tens.Should().Be(expectedUnits.Tens);
        result.Ones.Should().Be(expectedUnits.Ones);
    }

    [Fact]
    public void GivenInvalidNumericValueUnits_WhenGetRomanNumeralUnits_ThenRomanNumeralUnitsShouldBeInitialisedWithEmptyStrings()
    {
        var inputNumber = new NumericValueUnits { Thousands = 4, Hundreds = 15, Tens = 10, Ones = 0 };

        var expectedUnits = new RomanNumeralUnits { Thousands = string.Empty, Hundreds = string.Empty, Tens = string.Empty, Ones = string.Empty };

        var result = _converterUnderTest.GetRomanNumeralUnits(inputNumber);

        result.Thousands.Should().Be(expectedUnits.Thousands);
        result.Hundreds.Should().Be(expectedUnits.Hundreds);
        result.Tens.Should().Be(expectedUnits.Tens);
        result.Ones.Should().Be(expectedUnits.Ones);
    }

    [Fact]
    public void GivenNumber1954_WhenCalculateRomanNumeral_ThenRomanNumeralOutputShouldEqual_MCMLIV()
    {
        int numberToConvert = 1954;
        string expectedRomanNumeral = "MCMLIV";

        var result = _converterUnderTest.CalculateRomanNumeral(numberToConvert);

        Assert.Equal(expectedRomanNumeral, result);
    }

    [Fact]
    public void GivenNumber1990_WhenCalculateRomanNumeral_ThenRomanNumeralOutputShouldEqual_MCMXC()
    {
        int numberToConvert = 1990;
        string expectedRomanNumeral = "MCMXC";

        var result = _converterUnderTest.CalculateRomanNumeral(numberToConvert);

        Assert.Equal(expectedRomanNumeral, result);
    }

    [Fact]
    public void GivenNumber2014_WhenCalculateRomanNumeral_ThenRomanNumeralOutputShouldEqual_MMXIV()
    {
        int numberToConvert = 2014;
        string expectedRomanNumeral = "MMXIV";

        var result = _converterUnderTest.CalculateRomanNumeral(numberToConvert);

        Assert.Equal(expectedRomanNumeral, result);
    }

    [Fact]
    public void GivenNumber2023_WhenCalculateRomanNumeral_ThenRomanNumeralOutputShouldEqual_MMXIV()
    {
        int numberToConvert = 2014;
        string expectedRomanNumeral = "MMXXIII";

        var result = _converterUnderTest.CalculateRomanNumeral(numberToConvert);

        Assert.Equal(expectedRomanNumeral, result);
    }
}
