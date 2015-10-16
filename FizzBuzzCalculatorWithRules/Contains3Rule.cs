namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class Contains3Rule:IRules
    {
        public string GetReplacementWord(string number)
        {
            return number.Contains("3") ? "Fizz" : number;
        }
    }
}