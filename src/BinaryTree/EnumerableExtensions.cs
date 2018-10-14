using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public static class EnumerableExtensions
    {
        public static void PrintToConsole<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.Write($"{item} ");
            }
        }

        public static void Print<T>(this IEnumerable<T> source)
        {
            var list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            int rows = Convert.ToInt32(Math.Ceiling(Math.Log(list.Count + 1, 2))); ;
            int columns = Convert.ToInt32(Math.Pow(2, rows - 1));
            var str = new string[rows, columns];
            int listElementIterator = 0;

            for (int i = 1; i <= rows; i++)
            {
                int noOfElementsInALevel = Convert.ToInt32(Math.Pow(2, i - 1));
                for (int j = 0; j < noOfElementsInALevel; j++)
                {
                    if (listElementIterator < list.Count)
                    {
                        str[i - 1, j] = list[listElementIterator].ToString();
                        listElementIterator++;
                    }
                }
            }

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[i - 1, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}