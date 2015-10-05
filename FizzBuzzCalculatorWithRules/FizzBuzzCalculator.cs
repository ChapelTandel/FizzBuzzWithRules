using System.Collections.Generic;
using System.Linq;

namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class FizzBuzzCalculator
    {
        public List<string> GetFizzBuzzResult(IEnumerable<int> range, List<Rules> rules)
        {
            return range.Select(number => EvaluateRules(number, rules)).ToList();
        }

        private static string EvaluateRules(int number, IEnumerable<Rules> rules)
        {
            foreach (var rule in rules.Where(rule => (number%rule.Divisor) == 0))
            {
                return rule.Word;
            }

            return number.ToString();
        }
    }
}