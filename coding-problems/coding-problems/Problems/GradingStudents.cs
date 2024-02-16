namespace coding_problems.Problems;

class GradingStudents
{
    public static List<int> gradingStudents(List<int> grades)
    {
        var newList = new List<int>();

        for (int i = 0; i < grades.Count; i++)
        {
            var grade = grades[i];

            if (grade >= 38)
            {
                var nextNumber = GetNextMultiple5Number(grade);

                if (nextNumber - grade < 3)
                {
                    newList.Add(nextNumber);

                    continue;
                }
            }

            newList.Add(grade);
        }

        return newList;
    }

    private static int GetNextMultiple5Number(int number)
    {
        return (number / 5 + 1) * 5;
    }
}
