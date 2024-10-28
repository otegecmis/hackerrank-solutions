// https://www.hackerrank.com/challenges/mini-max-sum
namespace mini_max_sum;

class Program
{
    public static List<int> ReverseList(List<int> arr)
    {
        List<int> reversedList = new List<int>();
        int length = arr.Count;

        for (int i = length - 1; i >= 0; i--)
        {
            reversedList.Add(arr[i]);
        }

        return reversedList;
    }

    public static List<int> OrderList(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            int min = i;

            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }

            int temp = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = temp;
        }

        return numbers;
    }

    public static void miniMaxSum(List<int> arr)
    {
        arr = OrderList(arr);
        List<int> reversedList = ReverseList(arr);

        long min = 0;
        long max = 0;

        int length = arr.Count;

        for (int i = 0; i < length - 1; i++)
        {
            min += arr[i];
        }

        for (int i = 0; i < reversedList.Count - 1; i++)
        {
            max += reversedList[i];
        }

        System.Console.WriteLine("{0} {1}", min, max);
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        numbers.Add(793810624);
        numbers.Add(895642170);
        numbers.Add(685903712);
        numbers.Add(623789054);
        numbers.Add(468592370);

        miniMaxSum(numbers);
    }
}
