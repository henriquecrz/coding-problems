namespace coding_problems
{
    public static class ExtensionMethods
    {
        public static int[] ToIntArray(this char[] charArray) =>
            Array.ConvertAll(
                charArray,
                c => (int)char.GetNumericValue(c));
    }
}
