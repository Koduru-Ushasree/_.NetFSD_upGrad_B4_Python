using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day1_HandsOn
{
    internal class p2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator: (+, -, *, /)");
            string op = Console.ReadLine();

            string result = op switch
            {
                "+" => "Result: " + (num1 + num2),
                "-" => "Result: " + (num1 - num2),
                "*" => "Result: " + (num1 * num2),
                "/" when num2 == 0 => "Cannot Divide By Zero",
                "/" => "Result: " + (num1 / num2),
                _ => "Invalid Operator"

            };
            Console.WriteLine("Result:"+result);
        }
    }
}

//Level - 1 Problem 2: Simple Calculator Using Switch
//Scenario
//Create a simple calculator application that performs basic arithmetic operations.
//Requirements
//• Accept two numbers from user.
//• Accept operator (+, -, *, /).
//• Use switch statement to perform operation.
//• Display result.
//Technical Constraints
//• Use int or double data types.
//• Use switch-case statement.
//• Handle division by zero.
//Sample Input
//Enter First Number: 10
//Enter Second Number: 5
//Enter Operator: *
//Sample Output
//Result: 50
//Expectations
//Correct operator selection and proper validation of inputs.
//Learning Outcome
//Understand switch statements, arithmetic operators and control flow in C#.

