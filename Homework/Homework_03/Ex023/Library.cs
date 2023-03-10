public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static string SqrtsOfNumbers(int n)
    {
        string result = String.Empty;
        int index = 1;

        while (index <= n)
        {
            int sqr = index * index * index;
            result = result + "[" + index + " => " + sqr + "] ";
            index = index + 1;
        }
        return result;
    }
}