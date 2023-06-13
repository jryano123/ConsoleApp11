using System;

class Program
{
    static void Main()
    { 
        double quiz1, quiz2, quiz3;

        Console.WriteLine("Enter the scores for 3 quizzes:");

    
        while (true)
        {
            Console.Write("Quiz 1: ");
            if (double.TryParse(Console.ReadLine(), out quiz1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

      
        while (true)
        {
            Console.Write("Quiz 2: ");
            if (double.TryParse(Console.ReadLine(), out quiz2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

       
        while (true)
        {
            Console.Write("Quiz 3: ");
            if (double.TryParse(Console.ReadLine(), out quiz3))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

       
        double total = quiz1 + quiz2 + quiz3;
        double average = total / 3;

        Console.WriteLine("Total score: " + total);
        Console.WriteLine("Average score: " + average);

        
        if (average >= 75)
        {
            Console.WriteLine("Result: Pass");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }
}
