using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //寻找最小的k个数
            //输入n个整数，输入其中最小的k个
            //算法1:1.先快速排序，2.然后去k个数
            int[] SortInt = { 6, 1, 5, 4, 8, 3, 9, 12, 51, 11, 15, 14, 13, 25, 69, 47, 56, 74, 26, 78 };
            Console.WriteLine("排序以前：");
            Show(SortInt);
            SortQuick(SortInt, 0, SortInt.Length - 1);

            Console.WriteLine("排序以后：");
            Show(SortInt, 5);

            //算法2:1.选k个数取最大值 跟最大值比较的数替换，然后取最大值，2.然后去k个数
            //int[] SortInt = { 78, 51, 15, 74, 8, 3, 9, 12, 1, 11, 5, 14, 13, 25, 69, 47, 56, 4, 26, 6 };
            //Console.WriteLine("排序以前：");
            //Show(SortInt);
            //var selectNumber = SelectNumber(SortInt, 0, SortInt.Length - 1, 5);
            //Console.WriteLine("排序以后：");
            //Show(selectNumber);

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }

        static int[] SelectNumber(int[] SortInt, int lo, int hi, int k)
        {
            int[] selectNumbers = new int[k];

            for (int i = 0; i < k; i++)
            {
                selectNumbers[i] = SortInt[i];
            }
            var number = Max(selectNumbers, 0, k);

            for (int i = k; i <= hi; i++)
            {
                if (SortInt[i] < number.Max)
                {
                    selectNumbers[number.index] = SortInt[i];
                    number = Max(selectNumbers, 0, k);
                }
            }

            return selectNumbers;
        }

        static (int Max, int index) Max(int[] sortInt, int lo, int hi)
        {
            int max = sortInt[lo];
            int index = lo;
            for (int i = 0; i < hi; i++)
            {
                if (max < sortInt[i])
                {
                    max = sortInt[i];
                    index = i;
                }
            }
            return (max, index);
        }

        static void SortQuick(int[] SortInt, int lo, int hi)
        {
            if (hi > lo)
            {
                int lt = lo;
                int i = lo + 1, gt = hi;
                int v = SortInt[lo];
                while (i <= gt)
                {
                    int cmp = SortInt[i].CompareTo(v);
                    if (cmp < 0) Chang(lt++, i++, SortInt);
                    else if (cmp > 0) Chang(i, gt--, SortInt);
                    else i++;
                }
                SortQuick(SortInt, lo, lt - 1);
                SortQuick(SortInt, gt + 1, hi);
            }
        }

        static void Chang(int i, int j, int[] SortInt)
        {
            if (i != j)
            {
                int empty = SortInt[i];
                SortInt[i] = SortInt[j];
                SortInt[j] = empty;
            }
        }
        static void Show(int[] SortInt, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(SortInt[i] + " ");
            }
            Console.WriteLine();
        }
        static void Show(int[] SortInt)
        {
            Show(SortInt, SortInt.Length);
        }
    }
}
