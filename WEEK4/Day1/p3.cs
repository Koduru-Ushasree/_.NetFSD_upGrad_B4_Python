using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day1_HandsOn
{
    internal class p3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid Name!");
            }

            Console.WriteLine("Enter Salary: ");

            if (!double.TryParse(Console.ReadLine(), out double salary) || salary < 0)
            {
                Console.WriteLine("Invalid salary");
            }

            Console.WriteLine("Enter Years of Experience: ");

            if (!int.TryParse(Console.ReadLine(), out int exp) || exp < 0)
            {
                Console.WriteLine("Invalid Experience");
            }

            double bonusPercent;
            if (exp < 2)
            {
                bonusPercent = 0.05;
            }
            else if (exp <= 5)
            {
                bonusPercent = 0.10;

            }
            else
            {
                bonusPercent = 0.15;
            }
            double bonus = salary * bonusPercent;
            Console.WriteLine("Employee: "+name);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Final Salary: "+(salary+bonus));
        }
    }
}

//Level - 2 Problem 1: Employee Bonus Calculator
//Scenario
//Develop a console application that calculates employee bonus based on salary and years of experience.
//Requirements
//• Accept employee name, salary and years of experience.
//• Use if-else and conditional operator.
//• Bonus rules:
//   -Experience < 2 years: 5 % bonus
//   - 2 - 5 years: 10 % bonus
//   - > 5 years: 15 % bonus
//• Display final salary after bonus.
//Technical Constraints
//• Use double for salary.
//• Use if-else and ternary operator.
//• Use proper formatting for currency output.
//Sample Input
//Enter Name: Aisha
//Enter Salary: 50000
//Enter Experience: 4
//Sample Output
//Employee: Aisha
//Bonus: 5000
//Final Salary: 55000
//Expectations
//Accurate bonus calculation and correct usage of control statements.
//Learning Outcome
//Apply conditional logic and arithmetic operations in real-world scenarios.
