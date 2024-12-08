/*
    Question: A Very Big Sum
    URL: https://www.hackerrank.com/challenges/a-very-big-sum
    Author: @otegecmis
*/
namespace a_very_big_sum;

class Program
{
    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;

        foreach (var num in ar)
        {
            sum += num;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        List<long> numbers = new List<long>();

        numbers.Add(1000000001);
        numbers.Add(1000000002);
        numbers.Add(1000000003);
        numbers.Add(1000000004);
        numbers.Add(1000000005);

        long result = aVeryBigSum(numbers);
        System.Console.WriteLine(result);
    }
}
