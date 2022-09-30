using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.Write("Sum of the numbers: ");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.Write("Aver age of the numbers: ");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order
            Console.WriteLine("Numbers in ascending order: ");
            int i = 1;

            numbers.OrderBy(x => x)
                     .ToList()
                     .ForEach(x => Console.WriteLine($"Number {i++}: {x}"));

            Console.WriteLine();

            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("Numbers in descending order: ");
            int j = 1;
            numbers.OrderByDescending(x => x)
                   .ToList()
                   .ForEach(x => Console.WriteLine($"Number {j++}: {x}"));

            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6:");
            int s = 1;
            numbers.Where(x => x > 6)
                   .ToList()
                   .ForEach(x => Console.WriteLine($"Number {s++}: {x}"));
            Console.WriteLine();


            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Four numbers in ascending order: ");
            int b = 1;
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine($"Number {b++}: {x}"));
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            int names = 1;
            Console.WriteLine("Names that start with 'C' or 'S': ");
            employees.Where(x => x.FirstName
                                .ToLower()
                                .StartsWith('c') || x.FirstName
                                .ToLower().StartsWith('s'))
                           .OrderBy(x => x.FirstName)
                           .ToList()
                           .ForEach(x => Console.WriteLine($"Person {names++}: {x.FullName}"));
            Console.WriteLine();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            int agesForeacher = 1;
            Console.WriteLine("Names of people who are over 26: ");
            employees.Where(x => x.Age > 26)
                           .OrderBy(x => x.Age)
                           .ToList()
                           .ForEach(x => Console.WriteLine($"Person {agesForeacher++}: {x.FullName} and they are {x.Age} years old"));
            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("Average and sum of people who are over 35 and their years of experience is less than ten: ");
            var emper = employees.Where(x => x.Age > 35 && x.YearsOfExperience < 10).ToList();
            Console.WriteLine($"Sum: {emper.Sum(x => x.YearsOfExperience)} | Average: {Math.Round(emper.Average(x => x.YearsOfExperience), 2)}");

                           
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee("Kael", "Renaud", 14, 0));
            int bobthebuilder = 1;
            employees.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine($"Person {bobthebuilder++}'s name and age: {x.FullName}, {x.Age} years old"));

            Console.ReadLine();
        }















        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
