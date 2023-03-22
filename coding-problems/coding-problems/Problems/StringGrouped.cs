namespace coding_problems.Problems
{
    public static class StringGrouped
    {
        public static void PrintStringsGroups(List<string> input)
        {
            var result = GetStringsGroup(input);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(Contant.COMMA_SEPARATOR, item));
            }
        }

        private static List<List<string>> GetStringsGroup(List<string> input)
        {
            var result = new List<List<string>>();
            var sorted = GetInputSorted(input);

            while (sorted.Count > 0)
            {
                var first = sorted.First();
                var group = new List<string>() { first.Key };

                if (sorted.Count > 1)
                {
                    for (var i = 1; i < sorted.Count;)
                    {
                        if (first.Value == sorted[i].Value)
                        {
                            group.Add(sorted[i].Key);
                            sorted.RemoveAt(i);
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                result.Add(group);
                sorted.Remove(first);
            }

            return result;
        }

        private static List<KeyValuePair<string, string>> GetInputSorted(List<string> input) => input
            .Select(element =>
            {
                var charArray = element.ToCharArray();
                var intArray = charArray.ToIntArray();

                Array.Sort(intArray);

                var value = string.Join(string.Empty, intArray);

                return new KeyValuePair<string, string>(element, value);
            })
            .ToList();
    }
}
