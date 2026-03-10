using System;
using System.Reflection.Emit;

namespace Day2_Problem1
{
    public class Calculator
    {
        private int n1;
        private int n2;

        public int Add(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            return this.n1 + this.n2;
        }

        public int Subtract(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            return this.n1 - this.n2;
        }
    }

    class problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Calculator calc = new Calculator();


            Console.WriteLine("Addition = " + calc.Add(a, b));
            Console.WriteLine("Subtraction = " + calc.Subtract(a, b));
        }
    }
}

//Level - 1 Problem 1: Simple Calculator Using Methods
//Scenario:
//A small retail shop wants a simple calculator application to perform addition and subtraction operations using reusable methods.
//Requirements:
//1.Create a class named Calculator.
//2.Create methods Add(int a, int b) and Subtract(int a, int b).
//3.Each method should return the result.
//4. In Main(), create an object and call the methods.
//5. Display the output.
//Technical Constraints:
//1.Use method parameters and return types properly.
//2. Use appropriate access modifiers.
//3. No global variables allowed.
//Expectations:
//Proper method definition, object creation, and method invocation.
//Learning Outcome:
//Understand functions, parameters, return types, classes, and objects.
//Sample Input: 10 5
//Sample Output: Addition = 15, Subtraction = 5
//enhance the problem 1 by adding private data members, set values those data members and display data using public without using get set properties and without constructors
