using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace PrimeFactorsKata
{
    public class PrimeFactorsKataTests
    {
        private static IEnumerable<object[]> PrimeFactorsTestCases
        {
            get
            {
                yield return new object[] { 2, new List<int> { 2 } };
                yield return new object[] { 3, new List<int> { 3 } };
                yield return new object[] { 4, new List<int> { 2, 2 } };
                yield return new object[] { 5, new List<int> { 5 } };
                yield return new object[] { 6, new List<int> { 2, 3 } };
                yield return new object[] { 8, new List<int> { 2, 2, 2 } };
                yield return new object[] { 9, new List<int> { 3, 3 } };
                yield return new object[] { 10, new List<int> { 2, 5 } };
                yield return new object[] { 12, new List<int> { 2, 2, 3 } };
                yield return new object[] { 20, new List<int> { 2, 2, 5 } };
                yield return new object[] { 35, new List<int> { 5, 7 } };
            }
        }

        private const string primeFactorsTestCases = "PrimeFactorsTestCases";


        [Test, TestCaseSource(primeFactorsTestCases)]
        public void should_retrun_primes_numbers_given_input(int number, List<int> primeNumbers)
        {
            var actual = PrimeFactors.Generate(number);
            Check.That(actual).ContainsExactly(primeNumbers);
        }

        [Test, TestCaseSource(primeFactorsTestCases)]
        public void should_retrun_primes_numbers_given_input_method2(int number, List<int> primeNumbers)
        {
            var actual = PrimeFactors.GenerateMethod2(number);
            Check.That(actual).ContainsExactly(primeNumbers);
        }

        [Test]
        public void should_return_throw_exception_when_input_less_than_1()
        {
            Check.ThatCode(() => PrimeFactors.GenerateMethod2(-1)).Throws<Exception>().WithMessage("The number should be greater or equal to 2");
        }

    }
}
