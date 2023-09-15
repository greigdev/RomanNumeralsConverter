namespace NumericRomanConverter;

public struct RomanNumeralMapper
{
    public static string GetRomanOnes(int number)
    {
        return number switch
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            _ => string.Empty
        };
    }

    public static string GetRomanTens(int number)
    {
        // 10 - 90
        return number switch
        {
            1 => "X",
            2 => "XX",
            3 => "XXX",
            4 => "XL",
            5 => "L",
            6 => "LX",
            7 => "LXX",
            8 => "LXXX",
            9 => "XC",
            _ => string.Empty
        };
    }

    public static string GetRomanHundreds(int number)
    {
        // 100 - 900
        return number switch
        {
            1 => "C",
            2 => "CC",
            3 => "CCC",
            4 => "CD",
            5 => "D",
            6 => "DC",
            7 => "DCC",
            8 => "DCCC",
            9 => "CM",
            _ => string.Empty
        };
    }

    public static string GetRomanThousands(int number)
    {
        // 1000 - 3000
        return number switch
        {
            1 => "M",
            2 => "MM",
            3 => "MMM",
            _ => string.Empty
        };
    }
}
