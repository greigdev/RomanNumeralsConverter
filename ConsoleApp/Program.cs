using NumericRomanConverter;

namespace RomanNumeralsConverter.ConsoleApp;

internal class Program
{
    internal static void Main()
    {
        Console.WriteLine("Start App");

        // allow multiple conversions, end when console is closed
        while (true)
        {
            Run();
        }
    }

    private static void Run()
    {
        Console.WriteLine("\r\nConvert Number to Roman Numeral (enter 1) or Roman Numeral to Number (enter 2)?");

        var conversionChoice = Console.ReadLine();

        if (conversionChoice == "1")
        {
            var number = GetValidNumberToConvertFromUserInput();
            var romanNumeral = ConvertNumberToRomanNumeral(number);

            DisplayRomanNumeral(number, romanNumeral);
        }
        else if (conversionChoice == "2")
        {
            var romanNumeral = GetValidRomanNumeralToConvertFromUserInput();
            var number = ConvertRomanNumeralToNumber(romanNumeral);

            Console.WriteLine("\r\nThe number represented by {0} is: {1}", romanNumeral, number);
        }
        else
        {
            Console.WriteLine("\r\nIncorrect input, please enter either 1 or 2.");
        }
    }

    private static int GetValidNumberToConvertFromUserInput()
    {
        var isValid = false;
        var numberToConvert = 0;

        while (!isValid)
        {
            Console.WriteLine("\r\nType the number you want to convert (1 - 3999):");

            var inputNumber = Console.ReadLine();

            if (!int.TryParse(inputNumber, out numberToConvert))
            {
                Console.WriteLine("\r\nEnter a whole (non-decimal) number.");
            }
            else if (numberToConvert < 1 || numberToConvert > 3999)
            {
                Console.WriteLine("\r\nEnter a number between 1 & 3999.");
            }
            else
            {
                isValid = true;
            }
        }

        return numberToConvert;
    }

    private static string ConvertNumberToRomanNumeral(int number)
    {
        var converter = new ConvertNumberToRoman();

        return converter.CalculateRomanNumeral(number);
    }

    private static void DisplayRomanNumeral(int number, string romanNumeral)
    {
        Console.WriteLine("\r\nThe Roman Numeral for {0} is: {1}", number, romanNumeral);
    }

    private static string GetValidRomanNumeralToConvertFromUserInput()
    {
        var isValid = false;
        var numeralToConvert = string.Empty;

        while (!isValid)
        {
            Console.WriteLine("\r\nType the Roman Numeral you want to convert: ");

            numeralToConvert = Console.ReadLine().ToUpper();

            isValid = numeralToConvert.IsValidRomanNumeral();

            if (!isValid)
            {
                Console.WriteLine("\r\nPlease write a valid Roman Numeral");
            }
            else
            {
                isValid = true;
            }
        }

        return numeralToConvert;
    }

    private static int ConvertRomanNumeralToNumber(string romanNumeral)
    {
        var converter = new ConvertRomanToNumber();

        return converter.CalculateNumber(romanNumeral);
    }
}
