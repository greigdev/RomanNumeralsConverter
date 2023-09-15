namespace NumericRomanConverter;

public  record NumericValueUnits
{
    public int Thousands { get; init; }
    public int Hundreds { get; init; }
    public int Tens { get; init; }
    public int Ones { get; init; }
}
