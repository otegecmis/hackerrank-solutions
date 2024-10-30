// https://www.hackerrank.com/challenges/staircase
namespace staircase;

class Program
{
    public static void Line(int empty, int ch)
    {
        string line = "";

        for (int i = 0; i < empty; i++)
        {
            line += " ";
        }

        for (int i = 0; i < ch; i++)
        {
            line += "#";
        }

        System.Console.WriteLine(line);
    }
    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Line(n - i, i);
        }
    }
    static void Main(string[] args)
    {
        staircase(6);
    }
}
