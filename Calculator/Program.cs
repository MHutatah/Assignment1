using System;

namespace Calculator;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MHutatah C# Calculator! :D");
        Console.WriteLine("Avaliabile Operations: (Addition [+]), Subtraction [-], Multiplication [*], Dvidide [/])");
        Console.Write("Which operation do you want to perform?");
        string operation = Console.ReadLine();
        Console.WriteLine("Please enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (operation == "+"){
            Console.WriteLine($"Addition of {a} and {b} = {a+b}");
        }
        else if (operation == "-"){
            Console.WriteLine($"Subtraction of {b} from {a} = {a-b}");
        }
        else if (operation == "*"){
            Console.WriteLine($"Multiplication of {a} by {b} = {a*b}");
        }
        else if (operation == "/"){
            if(b == 0){
                Console.WriteLine("Math Error: Can not divide by ZERO!!");
            }
            else{
            Console.WriteLine($"Subtraction of {a} by {b} = {a/b}");
            }
        }
        else{
            Console.WriteLine($"Please Enter a valid operation (+,-,*,/)!");
        }
    }
}
