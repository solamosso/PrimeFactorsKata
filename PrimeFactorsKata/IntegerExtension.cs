namespace PrimeFactorsKata
{
    static class IntegerExtension
    {
        public static bool IsDivisibleBy(this int number, int primeNumber)
        {
            return number % primeNumber == 0;
        }
    }
}