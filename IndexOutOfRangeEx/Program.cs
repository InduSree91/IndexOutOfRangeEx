// We encounter index out of range exception when we work with arrays

using System;

namespace IndexOutOfRangeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            try
            {
                arr[0] = 11;
                arr[1] = 12;
                arr[2] = 13;
                arr[3] = 14;

                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            //Console.WriteLine("----------------------");
            //arr[3] = 14;  // Index Out of range exception occurs when we enter the values into the array more than its range

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Arrays rang is exceeted"); // This msg will be printed when exception occurs
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("The error is not effecting the remaining lines");



            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}