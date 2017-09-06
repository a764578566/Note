using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.一般查询方法
            int[] content = new int[] { 1, 2, 3, 4, 21, 5, 41, 22, 12, 8, 23, 9, 7, 4 };
            Show(content);
            Console.Write("请输入要查询的数字:");
            var findStr = Console.ReadLine();
            var result = Find(content, findStr);
            Console.WriteLine("要查询的数字为：" + result.value + " 查询的数字index为：" + result.index);
            //2.二分法查询方法 1.先排序 2.二分法
            SortQuick(content, 0, content.Length - 1);

            var result1 = BinarySearch(content, 0, content.Length - 1, int.Parse(findStr));

            Console.WriteLine("要查询的数字为：" + result1.value + " 查询的数字index为：" + result1.index);
            Console.ReadKey();
        }

        static (int value, int index) BinarySearch(int[] SortInt, int lo, int hi, int result)
        {
            int mid = (hi - lo) / 2 + lo;
            if (SortInt[mid] > result)
            {
                return BinarySearch(SortInt, lo, mid, result);
            }
            else if (SortInt[mid] < result)
            {
                return BinarySearch(SortInt, mid, hi, result);
            }
            else if (SortInt[mid] == result)
            {
                return (result, mid);
            }
            return (result, -1);
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

        static (string value, int index) Find(int[] str, string result)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == result)
                {
                    return (result, i);
                }
            }
            return (result, -1);
        }

        static void Show(int[] str)
        {
            var leng = str.Length;
            for (int i = 0; i < leng - 1; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
