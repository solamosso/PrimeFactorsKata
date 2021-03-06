﻿using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> ComputePrimeFactors(int number)
        {
            var primeFactors = new List<int>();
            while (number > 1)
            {
                for (var primeNumber = 2; primeNumber <= number; primeNumber++)
                {
                    if (!number.IsDivisibleBy(primeNumber)) continue;
                    primeFactors.Add(primeNumber);
                    number /= primeNumber;
                    break;
                }
            }
            return primeFactors;
        }


        public static List<int> Generate(int number)
        {
            if (number < 1) throw new Exception("The number should be greater or equal to 2");
            var primeFactors = new List<int>();
            for (var primeNumber = 2; primeNumber <= number; primeNumber++)
            {
                if (!number.IsDivisibleBy(primeNumber)) continue;
                primeFactors.Add(primeNumber);
                primeFactors.AddRange(Generate(number / primeNumber));
                break;
            }
            return primeFactors;
        }

    }
}