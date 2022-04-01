// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
           //List<Employee> employees = PeopleFetcher.GetEmployees();
           List<Employee> employees = PeopleFetcher.GetFromApi();
           Util.PrintEmployees(employees);
           Util.MakeCSV(employees);
           Util.MakeBadges(employees);
        }
    }
}