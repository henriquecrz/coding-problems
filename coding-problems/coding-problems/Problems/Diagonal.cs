namespace coding_problems.Problems
{
    public static class Diagonal
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            var rows = arr.Count;
            var dia1 = 0;
            var dia2 = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i == j)
                    {
                        dia1 += arr[i][j];
                    }

                    if (rows - 1 - i == j)
                    {
                        dia2 += arr[i][j];
                    }
                }
            }

            return Math.Abs(dia1 - dia2);
        }
    }
}
