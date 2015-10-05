using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Given_I_Have_Fizz_Buzz_Calculator
{
    [TestFixture]
    public class When_I_Pass_A_Range_And_A_Rule
    {
        [Test]
        public void Then_The_Result_Is_Correct()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var rules = new List<Rules>
            {
                new Rules {Divisor = 15, Word = "FizzBuzz"},
                new Rules {Divisor = 3, Word = "Fizz"},
                new Rules {Divisor = 5, Word = "Buzz"},
                new Rules {Divisor = 7, Word = "Whizz"}
            };

            var actual = fizzBuzzCalculator.GetFizzBuzzResult(Enumerable.Range(1, 7), rules);

            var expected = new List<string> {"1", "2", "Fizz", "4", "Buzz", "Fizz", "Whizz"};

            foreach (var item in actual)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}