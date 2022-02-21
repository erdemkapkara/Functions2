using System;

namespace Function
{
    class Program
    {
        static int maxTrailing(int arr_count, int[] arr)
        {

            int maxDifference = int.MinValue;

            for (int i = 0; i < arr_count; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (maxDifference < arr[i] - arr[j])
                    {
                        maxDifference = arr[i] - arr[j];
                    }
                }
            }

            if (maxDifference == int.MinValue)
            {
                return -1;
            }
            else
            {
                return maxDifference;
            }
        }
        public static void Main(string[] args)
        {
            int count = 10;
            int[] array = { 1, 2, 3, 4, 15,6,7,8,9,10 };
            
            Console.WriteLine(Program.maxTrailing(count, array));
        }

       
    }
}
