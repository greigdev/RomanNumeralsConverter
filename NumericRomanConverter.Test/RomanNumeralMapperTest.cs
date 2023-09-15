using FluentAssertions;

namespace NumericRomanConverter.Test;

public class RomanNumeralMapperTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    public void GivenInputNumber_WhenGetRomanOnes_ThenResultShouldBeRomanNumeral(int numberToMap, string expectedRomanNumeral)
    {
        var result = RomanNumeralMapper.GetRomanOnes(numberToMap);

        result.Should().Be(expectedRomanNumeral);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(10, "")]
    public void GivenInvalidInputNumber_WhenGetRomanOnes_ThenResultShouldBeEmpty(int numberToMap, string expectedEmptyString)
    {
        var result = RomanNumeralMapper.GetRomanOnes(numberToMap);

        result.Should().Be(expectedEmptyString);
    }

    [Theory]
    [InlineData(1, "X")]
    [InlineData(2, "XX")]
    [InlineData(3, "XXX")]
    [InlineData(4, "XL")]
    [InlineData(5, "L")]
    [InlineData(6, "LX")]
    [InlineData(7, "LXX")]
    [InlineData(8, "LXXX")]
    [InlineData(9, "XC")]
    public void GivenInputNumber_WhenGetRomanTens_ThenResultShouldBeRomanNumeral(int numberToMap, string expectedRomanNumeral)
    {
        var result = RomanNumeralMapper.GetRomanTens(numberToMap);

        result.Should().Be(expectedRomanNumeral);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(10, "")]
    public void GivenInvalidInputNumber_WhenGetRomanTens_ThenResultShouldBeEmpty(int numberToMap, string expectedEmptyString)
    {
        var result = RomanNumeralMapper.GetRomanOnes(numberToMap);

        result.Should().Be(expectedEmptyString);
    }

    [Theory]
    [InlineData(1, "C")]
    [InlineData(2, "CC")]
    [InlineData(3, "CCC")]
    [InlineData(4, "CD")]
    [InlineData(5, "D")]
    [InlineData(6, "DC")]
    [InlineData(7, "DCC")]
    [InlineData(8, "DCCC")]
    [InlineData(9, "CM")]
    public void GivenInputNumber_WhenGetRomanHundreds_ThenResultShouldBeRomanNumeral(int numberToMap, string expectedRomanNumeral)
    {
        var result = RomanNumeralMapper.GetRomanHundreds(numberToMap);

        result.Should().Be(expectedRomanNumeral);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(10, "")]
    public void GivenInvalidInputNumber_WhenGetRomanHundreds_ThenResultShouldBeEmpty(int numberToMap, string expectedEmptyString)
    {
        var result = RomanNumeralMapper.GetRomanHundreds(numberToMap);

        result.Should().Be(expectedEmptyString);
    }

    [Theory]
    [InlineData(1, "M")]
    [InlineData(2, "MM")]
    [InlineData(3, "MMM")]
    public void GivenInputNumber_WhenGetRomanThousands_ThenResultShouldBeRomanNumeral(int numberToMap, string expectedRomanNumeral)
    {
        var result = RomanNumeralMapper.GetRomanThousands(numberToMap);

        result.Should().Be(expectedRomanNumeral);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(10, "")]
    public void GivenInvalidInputNumber_WhenGetRomanThousands_ThenResultShouldBeEmpty(int numberToMap, string expectedEmptyString)
    {
        var result = RomanNumeralMapper.GetRomanThousands(numberToMap);

        result.Should().Be(expectedEmptyString);
    }
}