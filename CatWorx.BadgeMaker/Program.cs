// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            double side = 3.14;
            double area = side * side;
            greeting = greeting + "World";
            Console.WriteLine("Greeting: " + greeting);
            Console.WriteLine($"Greeting {greeting}");
            Console.WriteLine("Area is a {0}", area.GetType());
            Console.WriteLine("The area is {0}", area);

            bool isCold = true;

            Console.WriteLine(isCold ? "Drink!" : "Add some ice");
            Console.WriteLine(!isCold ? "Drink!" : "Add some ice");
            string stringNum = "2";
            int intNum = Convert.ToInt16(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());

            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

            myScoreBoard.Add("firstInning", 10);
            myScoreBoard.Add("secondInning", 20);
            myScoreBoard.Add("thirdInning", 30);
            myScoreBoard.Add("fourthInning", 40);
            myScoreBoard.Add("fifthInning", 50);

            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

            string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

            List<string> employees = new List<string>() { "adam", "amy" };
            employees.Add("barbara");
            employees.Add("Billy");

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}