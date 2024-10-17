using System;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge. There will be a vareity of differnet funstion you will have to choose from. Please pick one");

        Console.WriteLine("Today we are going to us ethe number adder called SUM. Please input 2 numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);


        Console.WriteLine("Coolbeans. Please input a 2nd number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to " + Sum(number1int, number2int));
        Sum(number1int, number2int);

        Console.WriteLine("Today we will convert seconds to minutes");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);


        Console.WriteLine(number3 + " minutes is equal to " + ConvertSecond(number3int) + " seconds ");

        Console.WriteLine(" What will the answer be if you add one to a number input a number to see");
        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);

        Console.WriteLine("If you add +1 to " + number4 + " you get " + PlusOne(number4int));

        Console.WriteLine("Good Morning Sir its been 5 days after the war so TYPE IN A NUMBER FOR THE VOLTAGE AND ONE FOR THE CURRENT");

        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);

        Console.WriteLine(number5 + " voltage and a current of " + number6 + " creates the circut power of " + CircuitPower(number5int, number6int));

        Console.WriteLine("How old am in days");
        var number7 = Console.ReadLine();
        var number7int = int.Parse(number7);

        Console.WriteLine("I'm uh Im uh uh " + number7 + "  so that means tha uh Im uh " + DaysinAYEAR(number7int) + " days old");

        Console.WriteLine(" We need to make a triange how tall should it be");
        var number8 = Console.ReadLine();
        var number8int = int.Parse(number8);

        Console.WriteLine(" We need to make a triange how wide should it be");
        var number9 = Console.ReadLine();
        var number9int = int.Parse(number9);

        Console.WriteLine(" The triangle with a height of " + number8 + " and a width of " + number9 + " has an area of " + triArea(number8int, number9int));

        Console.WriteLine("Give a number");
        var number10 = Console.ReadLine();
        var number10int = int.Parse(number10);

        Console.WriteLine("Its " + Lessorequalto(number10int) + " that " + number10 + " is less than or equal to 0");
    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int ConvertSecond(int number3)
    {
        return number3 * 60;
    }

    public static int  PlusOne(int number4)
    {

        return number4 + 1;
    }

    public static int CircuitPower(int  number5, int number6)
    {
        return number5 * number6;
    }

    public static int DaysinAYEAR(int number7)
    {
        return number7 * 365;
    }

    public static float triArea(float number8, float number9)
    {
        return (number8 * number9)/2;
    }

    public static bool Lessorequalto(int NUMBER10)
    {
        if (NUMBER10 >= 0)
        {
            return false;   
        }
        else
        {
            return true;
        }
    }

}

