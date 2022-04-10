using System;
using System.Collections.Generic;
namespace ConsoleAppForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 52, 64, 75, 95, 15 };
            List<int> newList = new List<int>();
            Predicate<int> pred = x => x > 50;

            int[] newArray = new int[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                newList.Add(numbers[i]);
            }

            foreach (var item in newList)
            {
                if (pred(item))
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    newArray[newArray.Length - 1] = item;
                }
            }
            foreach (var list in newList)
            {
                foreach (var array in newArray)
                {
                    if (list == array)
                    {
                        newList.Remove(list);
                        break;
                    }
                }
            }
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
