using System.Diagnostics.CodeAnalysis;

namespace HW_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            double average = sum / numbers.Length;
            Console.WriteLine(average);


            int[][] jagged = [
                [34,50,80,43],
                [30,60,78],
                [12,27,8]                
                ];

            for (int i = 0; i< jagged.Length; i++) {
                int max = jagged[i][0];
                for(int j=1; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j] > max)
                    {
                        max = jagged[i][j];
                    }

                }
                Console.WriteLine(max);
            }



            int[][] jagged2 = [
                [20,25,30,45],
                [20,30,60],
                [78,95,32],
                [12,65,32,78]
                ];

            int sum2 = 0;
            int count = 0;

            foreach(var arr in jagged2)
            {
                foreach(var item in arr)
                {
                    sum += item;
                    count++;
                }
            }

            Console.WriteLine(sum/count);
        }
    }
}
