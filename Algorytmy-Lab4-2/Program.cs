using System;
namespace AlgorytmyLab2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatRecursive("#", 5));
            Console.WriteLine(String.Join(",",Change(14)));
            Console.WriteLine(QuickFib(45));
        }
        public static string Repeat(string s, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result = result + s; //result(i) <- Repeat(s, i-1) + s
            }
            return result;
        }
        public static string RepeatRecursive(string s, int n)
        {
            if (n <= 0)
            {
                return "";
            }
            Console.WriteLine($"Call for {n}");
            return RepeatRecursive(s, n - 1) + s;
        }
        //Napisz wersję rekurencyjną funkcji sumującej elementy tablicy od start do end
        public static int Sum(int[] arr, int start, int left)
        {
            throw new NotImplementedException();
        }

        //Wydawanie reszty w nominałach 1, 2, 5
        public static int[] Change(int amount)
        {
            int[] arr = new int[3];
            arr[2] = amount / 5;
            amount = amount - 5 * arr[2];
            arr[1] = amount / 2;
            amount = amount - 2 * arr[1];
            arr[0] = amount / 1;
            amount = amount - 1 * arr[0];

            return arr;
        }
        //Zdefiniuj wydawanie reszty dla nominałów w tablicy np. (1, 2, 5, 10, 20)
        public static int[] ChangeBis(int amount, int[] nominals)
        {
            throw new NotImplementedException();
        }

        public static int Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Fib(n - 2) + Fib(n - 1);
        }

        private static int FibMem(int n, int[] mem)
        {
            if (n < 2)
            {
                return n;
            }
            if (mem[n - 2] == 0)
            {
                mem[n - 2] = FibMem(n - 2, mem);
            }
            if (mem[n - 1] == 0)
            {
                mem[n - 1] = FibMem(n - 1, mem);
            }
            return mem[n - 2] + mem[n - 1];
        }

        public static int QuickFib(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return FibMem(n, new int[n]);
        }

        public static void BubleSort(int[] arr)
        {

        }
    }
}