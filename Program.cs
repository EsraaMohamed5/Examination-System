using System;
class Program
{
    static void Main(string[] args)
    {
        string[] subjects = { "Programming", "Maths", "Computer Architecture" };
        Console.WriteLine("Available Subjects:");
        for (int i = 0; i < subjects.Length; i++)
            Console.WriteLine($"{i + 1}. {subjects[i]}");

        int selectedIndex = -1;
        bool subjectValid = false;
        while (!subjectValid)
        {
            Console.Write("Choose a subject by number: ");
            if (int.TryParse(Console.ReadLine(), out selectedIndex))
            {
                selectedIndex -= 1;
                if (selectedIndex >= 0 && selectedIndex < subjects.Length)
                    subjectValid = true;
                else
                    Console.WriteLine("Invalid number. Try again.");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        string subject = subjects[selectedIndex];

        Console.WriteLine($"\nSubject: {subject}");
        int choice = 0;
        bool valid = false;
        while (!valid)
        {
            Console.Write("Choose Exam Type:\n1. Final\n2. Practical\nEnter your choice: ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "1" || input == "final")
            {
                choice = 1;
                valid = true;
            }
            else if (input == "2" || input == "practical")
            {
                choice = 2;
                valid = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid input (1, 2, final, or practical)");
            }
        }
        int numberOfQuestions = 5;
        string[] questions = new string[numberOfQuestions];
        string[][] options = new string[numberOfQuestions][];
        int[] correctAnswers = new int[numberOfQuestions]; 
        int[] marks = new int[numberOfQuestions];

        if (subject == "Programming")
        {
            questions[0] = "What does OOP stand for?";
            options[0] = new string[] { "Object-Oriented Programming", "Only Object Programming", "Open Object Plan" };
            correctAnswers[0] = 1;
            marks[0] = 5;

            questions[1] = "Which symbol starts a comment in C#?";
            options[1] = new string[] { "//", "/* */", "#" };
            correctAnswers[1] = 1;
            marks[1] = 5;

            questions[2] = "What is the correct keyword to define a class?";
            options[2] = new string[] { "define", "class", "object" };
            correctAnswers[2] = 2;
            marks[2] = 5;

            questions[3] = "Which of the following is a loop structure?";
            options[3] = new string[] { "if", "for", "int" };
            correctAnswers[3] = 2;
            marks[3] = 5;

            questions[4] = choice == 1 ? "C# is case-sensitive."
                                       : "Which keyword is used to inherit a class in C#?";

            if (choice == 1)
            {
                options[4] = new string[] { "True", "False" };
                correctAnswers[4] = 1;
            }
            else
            {
                options[4] = new string[] { "inherits", "extends", ":" };
                correctAnswers[4] = 3;
            }
            marks[4] = 5;
        }
        else if (subject == "Maths")
        {
            questions[0] = "What is the derivative of x^2?";
            options[0] = new string[] { "x", "2x", "x^2" };
            correctAnswers[0] = 2;
            marks[0] = 5;

            questions[1] = "What is the value of π (pi)?";
            options[1] = new string[] { "3.14", "2.71", "1.41" };
            correctAnswers[1] = 1;
            marks[1] = 5;

            questions[2] = "Which shape has 3 sides?";
            options[2] = new string[] { "Triangle", "Square", "Circle" };
            correctAnswers[2] = 1;
            marks[2] = 5;

            questions[3] = "What is 10 ÷ 2?";
            options[3] = new string[] { "3", "5", "10" };
            correctAnswers[3] = 2;
            marks[3] = 5;

            questions[4] = choice == 1 ? "Zero is an even number."
                                       : "What is the sum of the interior angles of a triangle?";

            if (choice == 1) 
            {
                options[4] = new string[] { "True", "False" };
                correctAnswers[4] = 1;
            }
            else 
            {
                options[4] = new string[] { "180 degrees", "90 degrees", "360 degrees" };
                correctAnswers[4] = 1;
            }
            marks[4] = 5;
        }
        else 
        {
            questions[0] = "Which part executes instructions?";
            options[0] = new string[] { "ALU", "RAM", "ROM" };
            correctAnswers[0] = 1;
            marks[0] = 5;

            questions[1] = "RAM is volatile memory.";
            options[1] = new string[] { "True", "False", "Sometimes" };
            correctAnswers[1] = 1;
            marks[1] = 5;

            questions[2] = "Cache is faster than RAM.";
            options[2] = new string[] { "True", "False", "Equal" };
            correctAnswers[2] = 1;
            marks[2] = 5;

            questions[3] = "Which stores BIOS?";
            options[3] = new string[] { "RAM", "ROM", "SSD" };
            correctAnswers[3] = 2;
            marks[3] = 5;

            questions[4] = choice == 1 ? "Registers are faster than RAM."
                                       : "Which component temporarily holds data for processing?";

            if (choice == 1) 
            {
                options[4] = new string[] { "True", "False" };
                correctAnswers[4] = 1;
            }
            else 
            {
                options[4] = new string[] { "Cache", "Register", "RAM" };
                correctAnswers[4] = 2;
            }
            marks[4] = 5;
        }

        Console.WriteLine($"\n--- {subject} Exam ---");

        int totalCorrect = 0;
        int totalMarks = 0;
        int obtainedMarks = 0;

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine($"\nQ{i + 1}: {questions[i]}");
            for (int j = 0; j < options[i].Length; j++)
            {
                Console.WriteLine($"{j + 1}. {options[i][j]}");
            }

            int userChoice = -1;
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.Write("Enter your answer (number): ");
                if (int.TryParse(Console.ReadLine(), out userChoice))
                {
                    if (userChoice >= 1 && userChoice <= options[i].Length)
                        validAnswer = true;
                    else
                        Console.WriteLine("Invalid choice number. Try again.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            totalMarks += marks[i];
            if (userChoice == correctAnswers[i])
            {
                totalCorrect++;
                obtainedMarks += marks[i];
            }
        }

        Console.WriteLine("\n---------------------------");
        Console.WriteLine($"Correct Answers: {totalCorrect}/{numberOfQuestions}");
        Console.WriteLine($"Marks Obtained: {obtainedMarks}/{totalMarks}");

        string grade = obtainedMarks >= 0.9 * totalMarks ? "Excellent"
                      : obtainedMarks >= 0.75 * totalMarks ? "Very Good"
                      : obtainedMarks >= 0.6 * totalMarks ? "Good"
                      : obtainedMarks >= 0.5 * totalMarks ? "Pass"
                      : "Fail";

        Console.WriteLine($"Your Grade: {grade}");
        Console.WriteLine("---------------------------\n");

        Console.WriteLine("Correct Answers Review:");
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine($"Q{i + 1}: {options[i][correctAnswers[i] - 1]}");
        }

        Console.WriteLine("\nExam completed. Press any key to exit.");
        Console.ReadKey();
    }
}
