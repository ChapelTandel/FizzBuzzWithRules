using System.Collections.Generic;

namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class DivisibleBy3Rule : IRules
    {
        public string GetReplacementWord(string number)
        {
            try
            {
                return int.Parse(number) % 3 == 0 ? "Fizz" : number;
            }
            catch
            {
                return number;
            }
        }
    }
}