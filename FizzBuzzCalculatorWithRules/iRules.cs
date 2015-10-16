using System.Runtime.InteropServices;

namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public interface IRules
    {
        string GetReplacementWord(string number);
    }
}