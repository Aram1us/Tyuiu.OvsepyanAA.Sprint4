﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.OvsepyanAA.Sprint4.Task2.V12.Lib
{
    public class DataService : ISprint4Task2V12
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}