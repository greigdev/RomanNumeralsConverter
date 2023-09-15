namespace NumericRomanConverter;

public interface IConvertNumberToRoman
{
    string CalculateRomanNumeral(int arabicNumber);
    NumericValueUnits GetNumericValueUnits(int number);
    RomanNumeralUnits GetRomanNumeralUnits(NumericValueUnits numericValueUnits);
}
