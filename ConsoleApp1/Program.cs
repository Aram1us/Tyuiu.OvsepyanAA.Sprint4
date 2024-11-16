using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {2, 4, 3, 7, 5, 1};
            int c = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) 
                    c *= array[i];
            }
            Console.WriteLine(c);
       }
    }
}
