namespace coding_problems.Problems;

public static class MiniMaxSum
{
    public static void PrintMiniMaxSum(List<int> arr)
    {
        var sum = 0L;
        var min = long.MaxValue;
        var max = 0L;

        for (var i = 0; i < 5; i++)
        {
            sum += arr[i];

            if (arr[i] < min)
            {
                min = arr[i];
            }

            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        var sumMin = sum - max;
        var sumMax = sum - min;

        Console.WriteLine($"{sumMin} {sumMax}");
    }
}
