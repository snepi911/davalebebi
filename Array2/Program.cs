namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3 };
            int[] secondArray = { 4, 5, 6, };

            int[] resultArray = new int[firstArray.Length + secondArray.Length];

            for(int i=0; i < firstArray.Length; i++)
            {
                resultArray[i] = firstArray[i];

            }

            for(int i=0; i<secondArray.Length; i++)
            {
                resultArray[firstArray.Length + i] = secondArray[i];
            }

            Console.Write("resultArray = [");
            for(int i=0; i<resultArray.Length; i++)
            {
                Console.Write(resultArray[i]);
                if(i< resultArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");



            int[] numbers = { 3, 5, -4, 8, 11, 1, -1, 6 };

            Console.Write("Enter targetSum: ");
            int targetSum = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == targetSum)
                    {
                        count++;
                    }
                }
            }

            int[][] PairArray = new int[count][];
            int index = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == targetSum)
                    {
                        PairArray[index] = new int[] { numbers[i], numbers[j] };
                        index++;
                    }
                }
            }

            Console.Write("pairArray=[ ");
            for(int i=0; i< PairArray.Length; i++)
            {
                Console.Write($"[{PairArray[i][0]}, {PairArray[i][1]}]");
                if(i<PairArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");



        }
    }
}
