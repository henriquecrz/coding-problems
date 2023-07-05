namespace coding_problems.Problems
{
    public static class MiniMaxSum
    {
        public static void PrintMiniMaxSum(List<int> arr)
        {
            var min = arr.Min();
            var max = arr.Max();
            var sum = arr.Sum();

            var sumMin = sum - max;
            var sumMax = sum - min;

            Console.WriteLine($"{sumMin} {sumMax}");
        }
    }
}
