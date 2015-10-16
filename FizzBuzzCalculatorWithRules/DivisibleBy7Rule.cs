namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class DivisibleBy7Rule : IRules
    {
        public string GetReplacementWord(string number)
        {
            try
            {
                return int.Parse(number) % 7 == 0 ? "Whizz" : number;
            }
            catch
            {
                return number;
            }
        }
    }
}