#nullable enable
using System;
using System.Collections;
using System.Linq;

namespace HelloWorld
{
    internal static class Program
    {
        public static void Main()
        {
            var arr1 = new[] {1, 2, 3, 4, 5, 6};
            var arr2 = new[] {1, 3, 4, 7, 8, 10};
            
            var newArr = Union(arr1, arr2);
            foreach (var e in newArr)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            var newArr3 = Crossing(arr1, arr2);
            foreach (var e in newArr3)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            var newArr2 = Difference(arr1, arr2);
            foreach (var e in newArr2)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
        

        private static int[] Union(int[] arr1, int[] arr2)
        {
            var newArr = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, newArr, arr1.Length);
            Array.Copy(arr2, 0, newArr, arr1.Length, arr2.Length);
            Array.Sort(newArr);
            return newArr;
        }

        private static object[] Crossing(int[] arr1, int[] arr2)
        {
            var newArr = new ArrayList();
            foreach (var e in arr1)
            {
                if (arr2.Contains(e))
                {
                    newArr.Add(e);
                }
            }

            return newArr.ToArray()!;
        }

        private static object[] Difference(int[] arr1, int[] arr2)
        {
            var newArr = new ArrayList();

            foreach (var e in arr1)
            {
                if (!arr2.Contains(e))
                {
                    newArr.Add(e);
                }
            }

            foreach (var e in arr2)
            {
                if (!arr1.Contains(e))
                {
                    newArr.Add(e);
                }
            }

            return newArr.ToArray()!;
        }
    }
}