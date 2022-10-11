namespace AlgorytmyLab1
{
    public class Lab1
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 23, 1, 56, 345, 1, 5, 67, 11 };
            int index = FindTwoDigItMin(arr1);
            if (index == 7)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            int[] arr2 = { };
            index = FindTwoDigItMin(arr2);
            if (index == -1)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            int[] arr3 = { 1, 3, 4, 123, 1234 };
            index = FindTwoDigItMin(arr3);
            if (index == -1)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static int FindTwoDigItMin(int[] arr)
        {

            return 0;
        }
    }
}