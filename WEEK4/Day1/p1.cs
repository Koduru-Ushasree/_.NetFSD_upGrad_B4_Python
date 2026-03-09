using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day1_HandsOn
{
    internal class p1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            // Validate Name
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid Name! Please enter a valid name.");
            }
            else
            {
                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());
                // Validate Marks
                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid Marks! Please enter marks between 0 and 100");
                }
                else
                {
                    string grade;

                    if (marks >= 90)
                        grade = "A";
                    else if (marks >= 80)
                        grade = "B";
                    else if (marks >= 70)
                        grade = "C";
                    else if (marks >= 60)
                        grade = "D";
                    else
                        grade = "Fail";

                    Console.WriteLine("Student: " + name);
                    Console.WriteLine("Grade: " + grade);
                }
            }
        }
    }
}

//Level - 1 Problem 1: Student Grade Evaluator
//Scenario
//You are developing a console-based application in .NET 8 for a school. The application should evaluate a student’s marks and assign a grade based on predefined rules.
//Requirements
//• Accept student name and marks (0-100).
//• Use if-else statements to determine grade.
//• Display grade as A, B, C, D or Fail.
//• Handle invalid input using conditional checks.
//Technical Constraints
//• Use C# (.NET 8 Console Application).
//• Use appropriate data types (string, int).
//• Use if-else control flow.
//• Do not use advanced concepts like classes or LINQ.
//Sample Input
//Enter Name: Rahul
//Enter Marks: 78
//Sample Output
//Student: Rahul
//Grade: B
//Expectations
//Program should correctly evaluate grade and handle edge cases like marks below 0 or above 100.
//Learning Outcome
//Understand variables, data types, input/output handling and if-else control statements in C#.
