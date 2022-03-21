using System;
using System.Linq;
namespace cshomework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double sum = 0;
            int[] arr = new int[100];
            Random random = new Random();

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1000) + 1;
            }
            int[] arr_sort = arr.Select(x => x).OrderByDescending(x => x).ToArray();
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0:0.0000}", arr_sort[i]);
                sum += arr_sort[i];
            }
            Console.WriteLine("求和：{0}", sum);
            Console.WriteLine("平均值：{0:0.0000}", sum / 100);
        }
    }
}
