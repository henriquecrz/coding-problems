namespace coding_problems.Problems
{
    public static class FizzBuzz
    {
        public static void PrintFizzBuzz(int n)
        {
            for (var i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        continue;
                    }

                    Console.WriteLine("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
