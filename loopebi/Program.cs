using System;

class Program
{
    static void Main()
    {
        #region guess
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int maxAttempts = 7;
        int currentAttempt = 1;
        bool isGuessed = false;

        Console.WriteLine("Guess the number from 1-100");
        Console.WriteLine($"You have {maxAttempts} attempts.\n");

        while (currentAttempt <= maxAttempts)
        {
            Console.Write($"attempt #{currentAttempt}: enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Error. Enter an integer. Try again\n");
                continue;
            }


            if (guess < targetNumber)
            {
                Console.WriteLine("Too low!\n");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Too high!\n");
            }
            else
            {
                Console.WriteLine($"Correct! You guessed the number in {currentAttempt} attempts.");
                isGuessed = true;
                break;
            }

            currentAttempt++;
        }

        if (!isGuessed)
        {
            Console.WriteLine($"Unfortunately, attempts ran out. The answer was: {targetNumber}");
        }

        #endregion

        #region grading

        Console.WriteLine("Grading System");
        int studentCount = 0;


        while (true)
        {
            Console.Write("Enter the number of students: ");
            if (int.TryParse(Console.ReadLine(), out studentCount) && studentCount > 0)
            {
                break;
            }
            Console.WriteLine("Error, please enter a positive integer.");
        }

        int passedCount = 0;
        int failedCount = 0;


        for (int i = 1; i <= studentCount; i++)
        {
            int score = -1;

            while (true)
            {
                Console.Write($"Enter the score for #{i} student (0-100): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out score))
                {

                    if (score >= 0 && score <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: score must be from 0-100!");
                    }
                }
                else
                {
                    Console.WriteLine("Erro: enter a valid number!");
                }
            }

            string grade;
            if (score >= 90)
            {
                grade = "A";
                passedCount++;
            }
            else if (score >= 80)
            {
                grade = "B";
                passedCount++;
            }
            else if (score >= 70)
            {
                grade = "C";
                passedCount++;
            }
            else if (score >= 60)
            {
                grade = "D";
                passedCount++;
            }
            else
            {
                grade = "F";
                failedCount++;
            }

            Console.WriteLine($"-> student #{i}: score = {score}, grade = {grade}\n");

        }

        Console.WriteLine("=== Final Statistics ===");
        Console.WriteLine($"Total Students: {studentCount}");
        Console.WriteLine($"Passed: {passedCount}");
        Console.WriteLine($"Failed: {failedCount}");

        #endregion
    }


}