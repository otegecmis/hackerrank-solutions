/*
    URL: https://www.hackerrank.com/challenges/arrays-ds
    Author: @otegecmis
*/

class Result
{
    public static List<int> reverseArray(List<int> a)
    {
        List<int> myReverseList = new List<int>();

        for (int i = a.Count - 1; i >= 0 ; i--)
        {
            myReverseList.Add(a[i]);
        }

        return myReverseList;
    }
}
