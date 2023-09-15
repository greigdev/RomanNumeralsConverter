using FluentAssertions;

namespace NumericRomanConverter.Test;

public class ConvertRomanToNumberTest
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VI", 6)]
    [InlineData("VII", 7)]
    [InlineData("VIII", 8)]
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    [InlineData("XX", 20)]
    [InlineData("XXX", 30)]
    [InlineData("XL", 40)]
    [InlineData("L", 50)]
    [InlineData("LX", 60)]
    [InlineData("LXX", 70)]
    [InlineData("LXXX", 80)]
    [InlineData("XC", 90)]
    [InlineData("C", 100)]
    [InlineData("CL", 150)]
    [InlineData("CCCXXX", 330)]
    [InlineData("CD", 400)]
    [InlineData("D", 500)]
    [InlineData("DC", 600)]
    [InlineData("DCX", 610)]
    [InlineData("DCC", 700)]
    [InlineData("DCCX", 710)]
    [InlineData("DCXL", 640)]
    [InlineData("DCL", 650)]
    [InlineData("CM", 900)]
    [InlineData("CMLXXX", 980)]
    [InlineData("MCMLXX", 1970)]
    [InlineData("MCMLXXV", 1975)]
    [InlineData("MCMLXXXIV", 1984)]
    [InlineData("MCMLXXXIX", 1989)]
    [InlineData("MMCD", 2400)]
    [InlineData("MMDIII", 2503)]
    [InlineData("MMDXXX", 2530)]
    [InlineData("MMDCLXX", 2670)]
    [InlineData("MMDXCI", 2591)]
    [InlineData("MMMCDIII", 3403)]
    [InlineData("MMMCMXCIX", 3999)]
    public void GivenRomanNumeral_WhenCalculateNumber_ThenOutputNumberShouldMatchExpected(string romanNumeral, int expectedResult)
    {
        ConvertRomanToNumber converterUnderTest = new();

        var result = converterUnderTest.CalculateNumber(romanNumeral);

        result.Should().Be(expectedResult);
    }
}
