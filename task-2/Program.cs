using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int Num = Convert.ToInt32(Console.ReadLine());
            //int a = 0;
            //if (Num != 0)
            //{
            //    while (Num > 0)
            //    {
            //        Num /= 10;
            //        a++;
            //    }
            //    if (Num < 1)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter positive numbers!");
            //}
            #endregion

            #region task2
            string txt = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'a' || txt[i] == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            #endregion

            #region task3

            //int[] arr = { 4, 7, 9, 14, 15, 19, 21 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 == 0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            #endregion
        }
    }
}
