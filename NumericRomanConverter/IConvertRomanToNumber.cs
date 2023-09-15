namespace NumericRomanConverter;

public interface IConvertRomanToNumber
{
    int CalculateNumber(string romanNumeral);
    Dictionary<char, int> GetRomanNumeralValues();
}
