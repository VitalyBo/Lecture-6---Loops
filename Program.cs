using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Сonsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;


            while (true)
            {
                int choice = 0;

                Console.WriteLine("Choose what you want:\n1.While(WhileLoopExample)\n2.While(ValidateUserInput)\n3.Do While(DoWhileExample)\n4.Do While (PasswordValidation)\n5.For Loop(ForLoopExample)\n6.For Loop(SumAndAverageNumbers)\n7.Exit from program");
                Console.WriteLine("\nChoose and put number from 1 to 7");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("While(WhileLoopExample)");
                    Console.Write("Put some number: ");
                    int number = int.Parse(Console.ReadLine());
                    WhileLoopExample(number);
                    Console.WriteLine();
                    continue;
                }


                if (choice == 2)
                {
                    Console.WriteLine("While(ValidateUserInput)");
                    ValidateUserInput();
                    Console.WriteLine();
                    continue;
                }


                if (choice == 3) 
                { 
                    Console.WriteLine("Do While(DoWhileExample)");
                    DoWhileExample();
                    Console.WriteLine();
                    continue;
                }


                if (choice == 4)
                {
                    Console.WriteLine("Do While (PasswordValidation)");
                    PasswordValidation();
                    Console.WriteLine();
                    continue;
                }



                if (choice == 5) 
                { 
                    Console.WriteLine("For Loop(ForLoopExample)");
                    ForLoopExample();
                    Console.WriteLine();
                    continue;

                }


                if (choice == 6)
                { 
                    Console.WriteLine("For Loop(SumAndAverageNumbers)");
                    SumAndAverageNumbers();
                    Console.WriteLine();
                    continue;
                }


                if (choice == 7) 
                {
                    Console.Write("\nThank you for using our App for loops!");
                    Console.WriteLine();
                    break;
                }

                else { Console.Write("\nUuuuuups something going wrong! Try again!"); }
                                              

            }
        }


        public static void WhileLoopExample(int count)
        {
            if (count > 10) { Console.WriteLine("This number is too big! use number less than 10"); }
            else
            {
                while (count <= 10)
                {
                    Console.WriteLine(count);
                    count++;
                }
            }
        }

        public static void ValidateUserInput()
        {
            string input;
            int number;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Please enter a number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    isValid = true;
                    Console.WriteLine("You entered: " + number);
                }
                else { Console.WriteLine("Invalid input. Please enter a valid number."); }
                                  
            }
        }


        public static void DoWhileExample()
        {

            {
                int count = 11;

                do { Console.WriteLine(count); }
                                 
                while (count <= 10);

                Console.WriteLine("This is after our while loop");
            }
        }

        public static void PasswordValidation()
        {
            string password;
            bool isValidPassword = false;
            
            string correctPassword = "ValidPassword1";
            Console.WriteLine(" your correct password will be: ValidPassword1");

            do
            {
                Console.Write("Enter your password: "); 
                password = Console.ReadLine();

                if (password == correctPassword)
                {
                    if (password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"\d")) 
                    {isValidPassword = true; }
                    else { Console.WriteLine("Password must be at least 8 characters long and contain an uppercase letter and a number."); }
                }
                else { Console.WriteLine("Invalid password. Please try again."); }
                                    
            }
            while (!isValidPassword); 

            Console.WriteLine("Password accepted.");
        }


        public static void ForLoopExample()
        {
            for (int i = 450; i > -25; i -= 5)
            {
                Console.WriteLine(i);
            }
        }

        public static void SumAndAverageNumbers()
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < 300; i += 4)
            {
                sum += i;  
                count++; 
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Count: " + count);
            double average = (double)sum / count;
            Console.WriteLine("Average: " + average);
        }

    }

    
}