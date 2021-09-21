/// Week 2 Lab 1
/// File Name: week2lab1.cs
/// @author: Bill Gates
/// Date:  August 24, 2015
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum and product of these three numbers, and display the sum and product to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 5) Multiply the three integers
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            //print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, then press the third number and hit enter:");
            //declare three integer variables
            int n1, n2, n3, sum;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            //calculate the sum of these three numbers
            sum = n1 + n2 + n3;

            //print a message along with the sum of the three numbers
            Console.WriteLine("The sum of those three numbers is: " + sum);

            //Calculate the product of the three numbers
            int product = n1 * n2 * n3;

            //Printa message along with the product of the three numbers
            Console.WriteLine("The product of these three numbers is: " + product);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}