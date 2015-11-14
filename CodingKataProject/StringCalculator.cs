using System;

namespace CodingKataProject
{
    class StringCalculator
    {
        static void Main(string[] args)
        {
        }

        public int Add(string input)
        {
            int sumOfNumbers = 0;
            if (string.IsNullOrEmpty(input))
                return 0;
            return ReturnSumIfInputNotEmpty(input);
        }

        private static int ReturnSumIfInputNotEmpty(string input)
        {
            int sum = 0;
            string[] inputs = input.Split(',');
            foreach (var number in inputs)
            {
                sum += Convert.ToInt32(number);
            }
            return sum;
        }
    }
}
