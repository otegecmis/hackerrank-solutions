/*
    Question: Grading Students
    URL: https://www.hackerrank.com/challenges/grading
    Author: @otegecmis
*/
namespace grading;

class Program
{
    public static int RoundUpToNextMultipleOf5(int number)
    {
        return ((number / 5) + 1) * 5;
    }

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> adjustedGrades = new List<int>();

        foreach (var grade in grades)
        {
            if (grade < 38)
            {
                adjustedGrades.Add(grade);
            }
            else
            {
                int nextMultipleOf5 = RoundUpToNextMultipleOf5(grade);

                if (nextMultipleOf5 - grade < 3)
                {
                    adjustedGrades.Add(nextMultipleOf5);
                }
                else
                {
                    adjustedGrades.Add(grade);
                }
            }
        }

        return adjustedGrades;
    }

    static void Main(string[] args)
    {
        List<int> grades = new List<int>();

        grades.Add(73);
        grades.Add(67);
        grades.Add(38);
        grades.Add(33);

        List<int> results = gradingStudents(grades);

        foreach (var num in results)
        {
            System.Console.WriteLine(num);
        }
    }
}
