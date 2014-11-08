using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>(){7,8,12,343,2,1,5,7,19};
            intList.MyInsertSort();
            //intList.InsertSort();
            //var r =intList.MergeSort();
            intList.Print();
            Console.WriteLine("end a program");
            Console.ReadLine();
        }
    }

    public static class SortingExtension
    {
        public static void Print(this IList<int> lst)
        {
            foreach (var i in lst)
            {
                Console.WriteLine(i);
            }
        }
        public static void InsertSort(this IList<int> lst)
        {
            var length = lst.Count();

            for (var i = 1; i < length; i++)
            {
                var k = i;

                var val = lst[i];

                for (var j = k - 1; j >= 0; j--)
                {
                    if (val < lst[j])
                    {
                        lst[j + 1] = lst[j];
                        k = k - 1;
                    }
                    else
                    {
                        break;
                    }
                }

                lst[k] = val;
            }
        }

        public static void MyInsertSort(this IList<int> lst)
        {
            var length = lst.Count;

            for (int i = 1; i < length; i++)
            {
                var k = i;
                var val = lst[i];
                for (var j = k - 1; j >= 0; j--)
                {
                    if (val < lst[j])
                    {
                        lst[j + 1] = lst[j];
                        k = k - 1;
                    }
                    {
                        break;
                    }

                    lst[k] = val;
                }
            }
        }

        private static List<int> Merge(List<int> a, List<int> b)
        {
            var c = new List<int>();
            int s1 = 0;
            int s2 = 0;

            int e1 = a.Count ;
            int e2 = b.Count ;

            for (int i = 0; i < a.Count + b.Count; i++)
            {
                if (s1 == e1)
                {
                    c.Add(b[s2]);
                    s2++;
                    continue;
                }

                if (s2 == e2)
                {
                    c.Add(a[s1]);
                    s1++;
                    continue;
                }

                if (a[s1] < b[s2])
                {
                    c.Add(a[s1]);
                    s1++;
                }
                else
                {
                    c.Add(b[s2]);
                    s2++;
                }
            }

            return c;
        }

        public static List<int> MergeSort(this List<int> lst )
        {
            if (lst.Count <= 1)
            {
                return lst;
            }

            List<int> b = new List<int>();
            List<int> c = new List<int>();
            var halfSize = lst.Count/2;
            b = lst.GetRange(0, halfSize);
            c = lst.GetRange(halfSize, lst.Count - halfSize);
            return Merge(MergeSort(b), MergeSort(c));
        }



        public static void MergeSort(this IList<int> lst)
        {
            
        }

    }

}
