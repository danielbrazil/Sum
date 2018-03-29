/*
Program: Method to my Madness
Course: PROG1783-18W-Sec1-IT Support Programming Fundamentals
Professor: Scanlan, H.
Number Student ID: 7679566
Student: Daniel Brazil
Date: Mar, 08, 2018
*/


using System;

namespace BonusMethod
{
    class Program
    {
        //main method that start the program
        static void Main(string[] args)
        {
            //declaration of variables
            string sAnswer; //this variable take answer about numbers
            int firstNumberMultiply; //this variable will have a fisrt number of multiply
            int secondNumberMultiply; //this variable will have a second number of multiply
            int secondNumberDivide; //this variable will have a second number of divide
            int resultMultiply; //this variable will have a result of multiply
            double resultDivide; //this variable will have a result of divide
            bool bValidateNumber; //this variable validate user press just numbers integers

            //call the method that show in the screen the title of program
            Madness();
            //put cursor in this position defined
            Console.SetCursorPosition(0, 2);
            Console.Write("Execute Method Multiply...");
            Console.SetCursorPosition(0, 3);
            Console.Write("*******************************************************");

            //set variables to work
            bValidateNumber = false;
            firstNumberMultiply = 0;
            secondNumberMultiply = 0;
            secondNumberDivide = 0;
            resultMultiply = 0;
            resultDivide = 0;

            //loop to verify if user press just numbers integers
            //this loop ask about the first number for multiply
            while (!bValidateNumber)
            {
                Console.SetCursorPosition(0, 4);
                Console.Write("Please input first number: ");
                Console.SetCursorPosition(27, 4);
                sAnswer = Console.ReadLine();
                //if user press integer number set variable of loop with true and take answer and change to int
                if (int.TryParse(sAnswer, out firstNumberMultiply))
                {
                    firstNumberMultiply = int.Parse(sAnswer);
                    bValidateNumber = true;
                }
                //if user something different number, show message error and ask again
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 20);
                    Console.Write("Please input just numbers...");
                    Console.ResetColor();
                }
            }

            //set again the variable that validate if user press just numbers because the system ask again about another numbers
            bValidateNumber = false;
            //this commands clean the position of screen
            Console.SetCursorPosition(0, 20);
            Console.Write("                                         ");

            //loop to verify if user press just numbers integers
            //this loop ask about the first number for multiply
            while (!bValidateNumber)
            {
                Console.SetCursorPosition(0, 5);
                Console.Write("Please input second number: ");
                Console.SetCursorPosition(28, 5);
                sAnswer = Console.ReadLine();
                //if user press integer number set variable of loop with true and take answer and change to int
                if (int.TryParse(sAnswer, out secondNumberMultiply))
                {
                    secondNumberMultiply = int.Parse(sAnswer);
                    bValidateNumber = true;
                }
                //if user something different number, show message error and ask again
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 20);
                    Console.Write("Please input just numbers...");
                    Console.ResetColor();
                }

            }

            //this commands clean the position of screen
            Console.SetCursorPosition(0, 20);
            Console.Write("                                         ");

            //call the function that multiply the numbers and put the result inside the resultMultiply variable
            resultMultiply = Multiply(firstNumberMultiply, secondNumberMultiply);
            Console.SetCursorPosition(0, 6);
            Console.Write("{0} * {1} = {2}", firstNumberMultiply, secondNumberMultiply, resultMultiply);

            Console.SetCursorPosition(0, 7);
            Console.Write("*******************************************************");

            Console.SetCursorPosition(0, 8);
            Console.Write("Execute Method Divide...");
            Console.SetCursorPosition(0, 9);
            Console.Write("*******************************************************");

            Console.SetCursorPosition(0, 10);
            Console.Write("Your first number is a result of multiply : {0} ", resultMultiply);

            //set again the variable that validate if user press just numbers because the system ask again about another numbers
            bValidateNumber = false;

            //loop to verify if user press just numbers integers
            //this loop ask about the first number for multiply
            while (!bValidateNumber)
            {
                Console.SetCursorPosition(0, 11);
                Console.Write("Please input second number: ");
                Console.SetCursorPosition(28, 11);
                sAnswer = Console.ReadLine();
                //if user press integer number set variable of loop with true and take answer and change to int
                if (int.TryParse(sAnswer, out secondNumberDivide))
                {
                    secondNumberDivide = int.Parse(sAnswer);
                    bValidateNumber = true;
                }
                //if user something different number, show message error and ask again
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 20);
                    Console.Write("Please input just numbers...");
                    Console.ResetColor();
                }
            }

            //this commands clean the position of screen
            Console.SetCursorPosition(0, 20);
            Console.Write("                                         ");

            //call the function that divide the numbers and put the result inside the resultDivide variable
            resultDivide = Divide(resultMultiply, secondNumberDivide);
            Console.SetCursorPosition(0, 12);
            Console.Write("{0} / {1} = {2}", resultMultiply, secondNumberDivide, resultDivide.ToString("0.00"));

            Console.SetCursorPosition(0, 13);
            Console.Write("*******************************************************");
            Console.SetCursorPosition(0, 14);
            Console.Write("Thank you !!!");

            Console.SetCursorPosition(0, 15);
            Console.ReadLine();
        }

        //mehtod show the information about system
        public static void Madness()
        {

            Console.SetCursorPosition(0, 0);
            Console.Write("Method to my Madness. - By Daniel Brazil - ID: 7679566 ");
            Console.SetCursorPosition(0, 1);
            Console.Write("*******************************************************");
            
        }

        //method that multiply 2 numbers and return the result in integer
        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        //method that divide 2 numbers and return the result in double
        //parameters utilized double for result in double too
        public static double Divide(double firstNumber, double secondNumber)
        {
            double dResult;
            dResult = (firstNumber / secondNumber);
            return dResult;
        }

    }
}
