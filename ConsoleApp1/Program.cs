﻿using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {-7, 5, -9, 8, 4, 0};
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    c += array[i];
            }
            Console.WriteLine(c);
       }
    }
}
