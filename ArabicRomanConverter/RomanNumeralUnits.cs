namespace NumericRomanConverter;

public  record RomanNumeralUnits
{
    public string? Thousands { get; init; }
    public string? Hundreds { get; init; }
    public string? Tens { get; init; }
    public string? Ones { get; init; }
}
