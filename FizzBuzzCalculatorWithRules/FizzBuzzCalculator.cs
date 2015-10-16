using System;
using System.Collections.Generic;

namespace Given_I_Have_Fizz_Buzz_Calculator
{
    public class FizzBuzzCalculator 
    {
        public List<string> Calculate(IEnumerable<int> numbers)
        {
            var resultList = new List<string>();

            foreach (var number in numbers)
            {
                var num = number.ToString();

                num = GetReplacementWord(num);

                resultList.Add(num);
            }

            resultList.ForEach(Console.WriteLine);

            return resultList;
        }


        public string GetReplacementWord(string num)
        {
            var listOfRule = new List<IRules>()
            {
                new Contains3Rule(),
                new DivisibleBy15Rule(),
                new DivisibleBy7Rule(),
                new DivisibleBy3Rule(),
                new DivisibleBy5Rule(),
            };

            foreach (var rule in listOfRule)
            {
                num = rule.GetReplacementWord(num);
            }

            return num;

            // The obove code or the code below

//            var rule5 = new Contains3Rule();
//            num = rule5.GetReplacementWord(num);
//
//            var rule4 = new DivisibleBy15Rule();
//            num = rule4.GetReplacementWord(num);
//
//            var rule3 = new DivisibleBy7Rule();
//            num = rule3.GetReplacementWord(num);
//
//            var rule2 = new DivisibleBy5Rule();
//            num = rule2.GetReplacementWord(num);
//
//            var rule1 = new DivisibleBy3Rule();
//            num = rule1.GetReplacementWord(num);
//            return num;
        }
    }
}