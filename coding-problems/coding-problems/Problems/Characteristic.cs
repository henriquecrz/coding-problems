namespace coding_problems.Problems
{
    public static class Characteristic
    {
        public static void PrintIfNumberHasCharacteristic(string input)
        {
            var result = Calculate(input);

            if (result == input)
            {
                Console.WriteLine($"The number {input} has the characteristic.");
            }

            Console.WriteLine($"The number {input} does not have the characteristic.");
        }

        public static void PrintNumbersHaveCharacteristic()
        {
            var numbersWithCharacteristic = new List<string>();

            for (int i = 1000; i <= 9999; i++)
            {
                var iString = i.ToString();
                var result = Calculate(iString);

                if (result == iString)
                {
                    numbersWithCharacteristic.Add(iString);
                }
            }

            Console.WriteLine(
                "The numbers with characteristic are: {0}.",
                string.Join(Contant.COMMA_SEPARATOR, numbersWithCharacteristic));
        }

        private static string Calculate(string input)
        {
            var sum = int.Parse(input[..2]) + int.Parse(input.Substring(2, 2));

            return Math.Pow(sum, 2).ToString();
        }
    }
}
