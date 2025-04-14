using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            
            Console.WriteLine("Hello World!");

            //exercise 2 
            //declare variable
            double num1, num2;

            //prompt for input and convert to num1
            Console.WriteLine("Input value for number 1");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input value for number 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            double addition = num1 + num2;
            Console.WriteLine("Result of addition " + addition);

            double subtract = num1 - num2;
            Console.WriteLine("Result of subtraction " + subtract);

            double multiplaction = num1 * num2;
            Console.WriteLine("Result of multiplaction " + multiplaction);

            double division = num1 / num2;
            Console.WriteLine("Result of division " + division);



            //exercise 3
            //declare:
            double radius = 0;

            Console.WriteLine("What is the radius of the circle");
            radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius ,2);
            
            Console.WriteLine("The are of the circle is "+area.ToString("#.##"));
            Console.Read();
            

            //exercise 4 
            //declare 
            double temperature, ftemperature;
            Console.WriteLine("Input a temperature in celsius");
            temperature = Convert.ToDouble(Console.ReadLine());

            ftemperature = (temperature * 9 / 5) + 32;

            Console.WriteLine("The temperature you inputted in farenheit is " + ftemperature.ToString("#.##"));
            


            //exercise 5
            //declare 
            int userNum;
            Console.WriteLine("Input a whole number");
            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum/2 == 0)
            {
                Console.WriteLine("It is an even number");
            } else
            {
                Console.WriteLine("It is an odd number");
            }
            

            //exercise 6
            //declare
            int age, months;
            Console.WriteLine("What is your current age");
            age = Convert.ToInt32(Console.ReadLine());

            months = age * 12;

            Console.WriteLine("Your age in months is "+months);
            

            //exercise 7
            double amount, interest, time, rate;
            Console.WriteLine("Input the loan amount, interest rate as a decimal, and payoff time in years");
            amount = Convert.ToDouble(Console.ReadLine());
            interest = Convert.ToDouble(Console.ReadLine()); 
            time = Convert.ToDouble(Console.ReadLine());

            rate= amount * interest * time;
            Console.WriteLine("The current interest rate is " + rate);
            

            //exercise 8
            string name;
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hello "+name);
            


            //exercise 10
            string userInput = string.Empty;
            const string userPass = "password123";
            Console.WriteLine("Input your password to log in");
            userInput = Console.ReadLine();

            if (userInput == userPass) {
                Console.WriteLine("You have succesfully logged in");
            } else
            {
                Console.WriteLine("You have inputted the wrong password");
            }
            

            //exercise 1
            int userNum;
            Console.WriteLine("Input your number");
            userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum > 0)
            {
                Console.WriteLine("This is a positive number");

            }
            else if (userNum < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("It is a zero");
            }

            Console.WriteLine((userNum % 2 == 0) ? "it is even" : "it is odd");
            

            //exercise 2
            double grade;
            Console.WriteLine("Input your grade as whole number");
            grade = Convert.ToDouble(Console.ReadLine());

            int grade10 = (int)Math.Round(grade) / 10;

            switch (grade10)
            {
                case 10:
                case 9:
                    Console.WriteLine("Your grade is an A");
                    break;

                case 8:
                    Console.WriteLine("Your grade is a B");
                    break;

                case 7:
                    Console.WriteLine("Your grade is a C");
                    break;

                case 6:
                    Console.WriteLine("Your grade is a D");
                    break;
                
                case 5:
                    Console.WriteLine("Your grade is a F");
                    break;
                default:
                    Console.WriteLine("Your grade is a F");
                    break;

            }
            Console.Read();


            //hmw exercise 2
            Console.WriteLine("Input a number such as 1234");
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                Console.WriteLine(Convert.ToInt32(c));
                sum += Convert.ToInt32(c. ToString());
            }
            Console.WriteLine(sum);

        }
    }
}
