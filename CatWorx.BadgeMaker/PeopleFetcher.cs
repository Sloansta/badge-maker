using System;
using System.NET;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
        {
            // returns a list of employees
            List<Employee> employees = new List<Employee>();
            while(true)
            {

                Console.WriteLine("Please enter a first name: (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if(firstName == "")
                {
                    break;
                }

                // add a Console.ReadLine() for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine()); // parsing the id so that it's passed as an integer rather than a string value 
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();


                
                // new instance of Employee
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }

            return employees;
        }

        // gets a list of random employees via API call
        public static List<Employee> GetFromApi()
        {
            List<Employee> employees = new List<Employee>();

            return employees;
        }
    }
}