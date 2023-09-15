namespace NumericRomanConverter;

public class ConvertNumberToRoman : IConvertNumberToRoman
{
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
