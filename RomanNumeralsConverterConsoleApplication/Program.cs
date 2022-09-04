// See https://aka.ms/new-console-template for more information

using RomanNumeralsConverterConsoleApplication;

Console.WriteLine("Enter a Roman Number");
String romanNum = Console.ReadLine().ToUpper();
RomanNumeralsConverter romanNumeralsConverter = new RomanNumeralsConverter(romanNum);
romanNumeralsConverter.ConvertRomanNumber(romanNum);