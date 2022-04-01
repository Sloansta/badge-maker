// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            Console.WriteLine("Would you like to manually input employee data? (N/Y)");

            string answer = Console.ReadLine();

            if(answer == "n" || answer == "N" || answer == "no" || answer == "No")
            {
                List<Employee> employees = PeopleFetcher.GetFromApi();
                Util.PrintEmployees(employees);
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }else if(answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes")
            {
                List<Employee> employees = PeopleFetcher.GetEmployees();
                Util.PrintEmployees(employees);
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }
            else
            {
                Console.WriteLine("See you!");
                return;
            }
        }
    }
}