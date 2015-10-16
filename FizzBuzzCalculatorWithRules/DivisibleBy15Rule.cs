namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class DivisibleBy15Rule : IRules
    {
        public string GetReplacementWord(string number)
        {
            try
            {
                return int.Parse(number) % 15 == 0 ? "FizzBuzz" : number;
            }
            catch
            {
                return number;
            }
        }
    }
}