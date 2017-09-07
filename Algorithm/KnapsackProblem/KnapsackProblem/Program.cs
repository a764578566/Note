using System;
using System.Collections.Generic;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //有n个数，输出期中所有和为s的2个数的组合。
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 3, 12, 33, 5, 23, 41, 5, 6, 3, 6, 8 };
            var sum = Console.ReadLine();
            var list1 = FindN(Distinct<int>(numbers), int.Parse(sum));

            var list = Distinct<(int a, int b)>(list1);

            foreach (var item in list)
            {
                Console.Write("{" + item.a + " " + item.b + "} ");
            }

            //有n个数，输出期中所有和为s的k个数的组合。
            //1. 一个数=s   二个数=s   k个数=s

            Console.WriteLine();
            Console.ReadKey();
        }


        static (int a, int b)[] FindN(int[] numbers, int sum)
        {
            (int a, int b)[] list = new(int a, int b)[1000];
            int t = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] + numbers[j] == sum)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            list[t++] = (numbers[j], numbers[i]);
                        }
                        else
                        {
                            list[t++] = (numbers[i], numbers[j]);
                        }
                    }
                }
            }
            return list;
        }

        static T[] Distinct<T>(T[] list)
        {
            T[] temp = new T[list.Length];
            int count = 0;
            for (int i = 0, j = 0; i < list.Length; i++)
            {
                bool isAdd = true;
                for (int k = 0; k < temp.Length; k++)
                {
                    if (temp[k].Equals(list[i]))
                    {
                        isAdd = false;
                    }
                }
                if (isAdd)
                {
                    count++;
                    temp[j++] = list[i];
                }
            }
            T[] result = new T[count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }
    }
}
