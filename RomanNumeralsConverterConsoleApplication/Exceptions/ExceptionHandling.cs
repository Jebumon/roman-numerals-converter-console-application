/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumeralsConverterConsoleApplication.PredefinedValues;
using RomanNumeralsConverterConsoleApplication.Modules;

namespace RomanNumeralsConverterConsoleApplication.Exceptions
{
    public class ExceptionHandling
    {
        public string RomanNumber { get; set; }
        public ExceptionHandling(string romanNumber) 
        {
            RomanNumber = romanNumber;

        }

        public List<ConversionBox> Exceptions(string romanNumber) 
        {
            if (romanNumber == null || romanNumber == "")
            {
                Console.WriteLine("Roman number can't be null");
            }
            else
            {
                char[] romanDigits = romanNumber.ToCharArray();
                List<int> digitValues = new List<int>();
                digitValues.Add(0);

                foreach (char romanDigit in romanDigits)
                {
                    try
                    {
                        int decimalValue = (int)Enum.Parse(typeof(RomanNumeralSymbols), romanDigit.ToString());
                        digitValues.Add(decimalValue);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid Roman number");
                        romanDigits = null;
                        digitValues.Clear();
                        break;
                    }
                }
            }

               return  ConversionBox; 
        }
    }
}
*/