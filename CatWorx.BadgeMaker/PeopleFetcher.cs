using System;
using System.Net;
using Newtonsoft.Json.Linq;
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

            using(WebClient client = new WebClient())
            {
                string response = client.DownloadString("https://randomuser.me/api/?results=10&inc=name,id,picture");
                JObject json = JObject.Parse(response);
                foreach (JToken token in json.SelectToken("results"))
                {
                    Random rnd = new Random(); // this is so they have a random id
                    // Parse JSON data
                    Employee emp = new Employee
                    (
                        token.SelectToken("name.first").ToString(),
                        token.SelectToken("name.last").ToString(),
                        rnd.Next(),
                        token.SelectToken("picture.large").ToString()
                    );

                    employees.Add(emp);
                    //Console.WriteLine(token.SelectToken("picture.large").ToString());
                }
                
            }

            return employees;
        }
    }
}