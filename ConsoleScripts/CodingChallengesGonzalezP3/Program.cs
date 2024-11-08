using System;
using System.Security.Cryptography.X509Certificates;

class Challenges
{
        public static void Main(string[] args)
    {

        Console.WriteLine("Pick a number any number");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nplease choose a function to perform:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Minutes");
            Console.WriteLine("3. +1");
            Console.WriteLine("4. Circut Power");
            Console.WriteLine("5. Age");
            Console.WriteLine("6. Area of triangle");
            Console.WriteLine("7. Positive or negative");
            Console.WriteLine("0. and press 0 to quit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformSum();
                    break;
                case "2":
                    ConvertMinutesToSeconds();
                    break;
                case "3":
                    AddOneToNumber();
                    break;
                case "4":
                    CalculateCircuitPower();
                    break;
                case "5":
                    CalculateAgeInDays();
                    break;
                case "6":
                    CalculateTriangleArea();
                    break;
                case "7":
                    CheckIfNumberIsPositiveOrNegative();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("Bye bye");
                    break;
                default:
                    Console.WriteLine("Not that one another one");
                    break;
            }
        }
    }

    private static void PerformSum()
    {

        int number1 = GetIntegerInput("Today we are going to us ethe number adder called SUM. Please input 2 numbers for us to add. \n");
        int number2 = GetIntegerInput("Coolbeans. Please input a 2nd number");
        Console.WriteLine("The sum of {number1} and {number2} is {Sum(number1, number2)}.");
    }

    private static void ConvertMinutesToSeconds()
    {
        int minutes = GetIntegerInput("Please enter the number of minutes to convert to seconds:");
        Console.WriteLine($"{minutes} minutes is {Multiply(minutes)} seconds.");
    }

    private static void AddOneToNumber()
    {
        int number = GetIntegerInput("Please enter a number to which I will add 1:");
        Console.WriteLine($"{number} + 1 is {Add(number)}.");
    }

    private static void CalculateCircuitPower()
    {
        int voltage = GetIntegerInput("Please enter the voltage:");
        int current = GetIntegerInput("Please enter the current:");
        Console.WriteLine($"The circuit power is {Circuit(voltage, current)} watts.");
    }

    private static void CalculateAgeInDays()
    {
        int ageInYears = GetIntegerInput("Please enter your age in years:");
        Console.WriteLine($"You are approximately {Aged(ageInYears)} days old.");
    }

    private static void CalculateTriangleArea()
    {
        float baseLength = GetFloatInput("Please enter the base of the triangle:");
        float height = GetFloatInput("Please enter the height of the triangle:");
        Console.WriteLine($"The area of the triangle is {CalculateArea(baseLength, height)}.");
    }

    private static void CheckIfNumberIsPositiveOrNegative()
    {
        int number = GetIntegerInput("Please enter a number to check if it's positive or negative:");
        Console.WriteLine($"The number is {(IsNegative(number) ? "negative" : "positive")}.");
    }


    private static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    private static int Multiply(int minutes)
    {
        return minutes * 60;
    }

    private static int Add(int number)
    {
        return number + 1;
    }

    private static int Circuit(int voltage, int current)
    {
        return voltage * current;
    }

    private static int Aged(int years)
    {
        return years * 365;
    }

    private static float CalculateArea(float baseLength, float height)
    {
        return (baseLength * height) / 2;
    }

    private static bool IsNegative(int number)
    {
        return number < 0;
    }

    private static int GetIntegerInput(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
                return result;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static float GetFloatInput(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out float result))
                return result;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public static bool ReverseTheBool()
    {
        Console.WriteLine("This code make the truth a lie and a false");
        Console.WriteLine("Type in 1 for truth and 2 for false");
        var number = Console.ReadLine();
        int numberInt;
        while (!int.TryParse(number, out numberInt))
        {
            Console.WriteLine("Thats neither a truth or false trey again");
            number = Console.ReadLine();
        }
        if (numberInt == 1)
        {
            Console.WriteLine("Truth turned into False");
        }
        else if (numberInt == 2)
            Console.WriteLine("False turned into Truth");
    }
}


