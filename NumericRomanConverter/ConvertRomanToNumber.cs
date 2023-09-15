using System.Text.RegularExpressions;

namespace NumericRomanConverter;

public static class RomanNumeralValidator
{
    public static bool IsValidRomanNumeral(this string? romanNumeral)
    {
        if (string.IsNullOrEmpty(romanNumeral))
        {
            return false;
        }

        var validationPattern = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";

        return Regex.IsMatch(romanNumeral, validationPattern);
    }
}

public class ConvertRomanToNumber : IConvertRomanToNumber
{
    /// <summary>
    /// Get the number equivalent of the input Roman Numeral
    /// </summary>
    /// <param name="romanNumeral"></param>
    /// <returns>number</returns>
    public int CalculateNumber(string romanNumeral)
    {
        var romanNumeralValues = GetRomanNumeralValues();

        int total = 0, previous = 0;

        // start from right-to-left (lowest values first) to simplify add/subtract checks
        foreach (Char numeral in romanNumeral.Reverse())
        {
            romanNumeralValues.TryGetValue(numeral, out int value);

            if (value < previous)
            {
                total -= value;
            }
            else
            {
                total += value;
                previous = value;
            }
        }

        return total;
    }

    private static Dictionary<char, int> GetRomanNumeralValues()
    {
        return new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
    }
}
