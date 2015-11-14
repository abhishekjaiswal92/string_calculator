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
            if (string.IsNullOrEmpty(input))
                return 0;
            return ReturnSumIfInputNotEmpty(input);
        }

        private int ReturnSumIfInputNotEmpty(string input)
        {
            int sum = 0;
            string[] inputs = ExtractStringArrayFromInput(input);
            foreach (var number in inputs)
            {
                sum += Convert.ToInt32(number);
            }
            return sum;
        }

        private string[] ExtractStringArrayFromInput(string input)
        {
            return input.Split(',');   
        }
    }
}
