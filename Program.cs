using System;
using System.Collections.Generic;
using Impostos.Entities;
using System.Globalization;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Insert the number of Tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health Expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine());
                    list.Add(new PhysicalPerson(name, anualIncome, healthExpenditure));
                }
                else
                {
                    Console.Write("Number os Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            double sum = 0;
            Console.WriteLine("Taxes Paid: ");
            foreach (Person obj in list)
            {
                Console.WriteLine(obj.Name + ": $ " + obj.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += obj.Taxes(); 
            }
            Console.WriteLine();
            Console.WriteLine("Total Taxes: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
