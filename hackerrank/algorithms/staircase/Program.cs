/*
   URL: https://www.hackerrank.com/challenges/staircase
   Author: @otegecmis
*/
namespace staircase;

class Result
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
}

class Program
{
    static void Main(string[] args)
    {
        Result.staircase(6);
    }
}
