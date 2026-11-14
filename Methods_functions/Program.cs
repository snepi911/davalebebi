namespace Methods_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double score1 = GetValidScoreInput("Enter the first exam score (0-100): ");
            double score2 = GetValidScoreInput("Enter the second exam score (0-100): ");
            double score3 = GetValidScoreInput("Enter the third exam score (0-100): ");

            double average = CalculateAverage(score1, score2, score3);
            char grade = GetGrade(average);
            bool passed = IsPassed(average);

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Average Score: {average:F2}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Status: {(passed ? "Passed" : "Failed")}");




            Console.WriteLine("\n--- Task 2: Integer Number Analyzer ---");
            int number = GetPositiveIntegerInput("Enter a positive integer: ");

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Is Even: {IsEven(number)}");
            Console.WriteLine($"Is Prime: {IsPrime(number)}");
            Console.WriteLine($"Digit Count: {CountDigits(number)}");
            Console.WriteLine($"Reversed Number: {ReverseNumber(number)}");
        }

        #region grades
        static double GetValidScoreInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double score))
                {
                    bool IsValidScore(double s)
                    {
                        return s >= 0 && s <= 100;
                    }

                    if (IsValidScore(score))
                    {
                        return score;
                    }
                }
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }


        static double CalculateAverage(double s1, double s2, double s3)
        {
            return (s1 + s2 + s3) / 3.0;
        }

        static char GetGrade(double average)
        {
            if (average >= 91) return 'A';
            if (average >= 81) return 'B';
            if (average >= 71) return 'C';
            if (average >= 61) return 'D';
            if (average >= 51) return 'E';
            return 'F';
        }

        static bool IsPassed(double average)
        {
            return average >= 51;
        }

        #endregion


        static int GetPositiveIntegerInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    bool IsPositive(int n)
                    {
                        return n > 0;
                    }

                    if (IsPositive(number))
                    {
                        return number;
                    }
                }
                Console.WriteLine("Invalid input. Please enter a valid positive integer greater than 0.");
            }
        }


        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        static int CountDigits(int n)
        {
            if (n == 0) return 1;
            int count = 0;
            while (n > 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }

        static int ReverseNumber(int n)
        {
            int reversed = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }
            return reversed;
        }

    }
}

