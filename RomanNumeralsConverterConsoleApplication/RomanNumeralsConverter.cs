using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverterConsoleApplication
{
    public enum RomanNumbers
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
    public class RomanNumeralsConverter
    {
        public string RomanNumber { get; set; }
        public int OutPutNumber;
        public int rightDigit;

        public RomanNumeralsConverter(string romanNumber) 
        {
            RomanNumber = romanNumber;
        }
        

        public int ConvertRomanNumber(string romanNumber) 
        {
            if (romanNumber == null|| romanNumber == "")
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
                        int decimalValue = (int)Enum.Parse(typeof(RomanNumbers), romanDigit.ToString());
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
                digitValues.Add(0);
                //int a = (int)Enum.Parse(typeof(RomanNumbers), romanNumber);
                Console.WriteLine(digitValues.Count);
                if (digitValues.Count > 1)
                {
                    for (int i = 0; i < digitValues.Count - 1; i++)
                    {
                        //Console.WriteLine(digitValues[i]); 
                        int leftDigit = digitValues[i];
                        Console.WriteLine("leftDigit =" + leftDigit);
                        rightDigit = digitValues[i+1];
                        Console.WriteLine("RightDigit =" + rightDigit);
                        if (leftDigit == rightDigit || leftDigit > rightDigit)
                        {
                            OutPutNumber = OutPutNumber + leftDigit;
                            Console.WriteLine("OutPut +left = " + OutPutNumber);
                        }
                        else
                        {
                            OutPutNumber = OutPutNumber - leftDigit;
                            Console.WriteLine("OutPut -left = " + OutPutNumber);
                        }

                    }
                    OutPutNumber = OutPutNumber + rightDigit;
                }
                else 
                { 
                    OutPutNumber = digitValues[0]; 
                }
                

            }
            Console.WriteLine("OutPut ="+OutPutNumber);
            return OutPutNumber;
        }
    }
}
