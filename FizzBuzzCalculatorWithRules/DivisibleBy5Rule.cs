namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class DivisibleBy5Rule : IRules
    {
        public string GetReplacementWord(string number)
        {
            try
            {
                return int.Parse(number) % 5 == 0 ? "Buzz" : number;
            }
            catch
            {
                return number;
            }
        }
    }
}