using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Given_I_Have_Fizz_Buzz_Calculator
{
    [TestFixture]
    public class When_I_Pass_A_Number
    {
        [Test]
        public void Then_The_Result_Is_Replacement_Word_Or_Original_Number()
        {
            var range = Enumerable.Range(1, 15);
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var resultNumberOfWord = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "Whizz",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "Fizz",
                "Whizz",
                "FizzBuzz"
            };

            fizzBuzzCalculator.Calculate(range).Should().BeEquivalentTo(resultNumberOfWord);
        }
    }
}