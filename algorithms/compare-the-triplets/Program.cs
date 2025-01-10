/*
    URL: https://www.hackerrank.com/challenges/compare-the-triplets
    Author: @otegecmis
*/

namespace compare_the_triplets;

class Program
{
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int size = a.Count;
        int aScore = 0;
        int bScore = 0;

        for (int i = 0; i < size; i++)
        {
            if (a[i] > b[i])
            {
                aScore += 1;
            }
            else if (a[i] < b[i])
            {
                bScore += 1;
            }
        }

        List<int> result = new List<int> { aScore, bScore };

        return result;
    }

    static void Main(string[] args)
    {
        List<int> a = new List<int> { 5, 6, 7 };
        List<int> b = new List<int> { 3, 6, 10 };
        List<int> result = Result.compareTriplets(a, b);

        System.Console.WriteLine("{0} {1}", result[0], result[1]);
    }
}