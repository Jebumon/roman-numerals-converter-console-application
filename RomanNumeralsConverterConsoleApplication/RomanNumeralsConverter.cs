using RomanNumeralsConverterConsoleApplication.PredefinedValues;
namespace RomanNumeralsConverterConsoleApplication
{
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
                        int decimalValue = (int)Enum.Parse(typeof(RomanNumeralSymbols), romanDigit.ToString());
                        digitValues.Add(decimalValue);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid Roman number");
                        romanDigits= null;
                        digitValues.Clear();
                        break;
                    }
                }
                digitValues.Add(0);
                    for (int i = 0; i < digitValues.Count - 1; i++)
                    {
                        int leftDigit = digitValues[i];
                        rightDigit = digitValues[i+1];
                        if (leftDigit == rightDigit || leftDigit > rightDigit)
                        {
                            OutPutNumber = OutPutNumber + leftDigit;
                        }
                        else
                        {
                            OutPutNumber = OutPutNumber - leftDigit;
                        }
                    }
                    OutPutNumber = OutPutNumber + rightDigit;
            }
            Console.WriteLine("You converted the Roman Numeral '" +  romanNumber + "' to the number '" + OutPutNumber + "'");
            return OutPutNumber;
        }
    }
}
