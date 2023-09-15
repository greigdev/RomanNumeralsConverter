namespace NumericRomanConverter;

/// <summary>
/// Symbols are placed in order of value, starting with the largest values.
/// When the higher numeral is placed before a lower numeral, the values of each Roman numeral are added.
/// When smaller values precede larger ones, the smaller are subtracted from the larger, & the result is added to the total.
/// Do not repeat I, X, & C more than three times in a row.
/// Symbols V, L, & D cannot appear more than once consecutively.
/// Do not subtract a number from one that is more than 10 times greater: 
/// I may only precede V & X, X may only precede L & C, & C may only precede D & M.
///     
/// For testing conversions use: https://roman-numerals.info
/// </summary>
public class ConvertNumberToRoman : IConvertNumberToRoman
{
    /// <summary>
    /// Get the Roman Numeral equivalent of the input number
    /// </summary>
    /// <param name="number">Integer value from 1 to 3999</param>
    /// <returns>Roman Numeral</returns>
    public string CalculateRomanNumeral(int number)
    {
        var numericValueUnits = GetNumericValueUnits(number);
        var romanNumeralUnits = GetRomanNumeralUnits(numericValueUnits);

        return WriteRomanNumeral(romanNumeralUnits);
    }

    public NumericValueUnits GetNumericValueUnits(int number)
    {
        return new NumericValueUnits
        {
            Thousands = number / 1000,
            Hundreds = number / 100 % 10,
            Tens = number / 10 % 10,
            Ones = number % 10
        };
    }

    public RomanNumeralUnits GetRomanNumeralUnits(NumericValueUnits numericValueUnits)
    {
        return new RomanNumeralUnits
        {
            Ones = RomanNumeralMapper.GetRomanOnes(numericValueUnits.Ones),
            Tens = RomanNumeralMapper.GetRomanTens(numericValueUnits.Tens),
            Hundreds = RomanNumeralMapper.GetRomanHundreds(numericValueUnits.Hundreds),
            Thousands = RomanNumeralMapper.GetRomanThousands(numericValueUnits.Thousands)
        };
    }

    private static string WriteRomanNumeral(RomanNumeralUnits romanNumeralUnits)
    {
        // e.g. 3,456 = MMMCDLVI
        // 3000 = MMM
        // 400 = CD
        // 50 = L
        // 6 = VI
        return $"{romanNumeralUnits.Thousands}{romanNumeralUnits.Hundreds}{romanNumeralUnits.Tens}{romanNumeralUnits.Ones}";
    }
}
