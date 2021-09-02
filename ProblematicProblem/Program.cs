
using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        //Random rng;
        static Random rng = new Random();        
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string cont = Console.ReadLine();
            bool KeepGoing (string keepOn)
            {
                if (keepOn == "yes")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (KeepGoing(cont) == false)
            {
                //end program
                Environment.Exit(0);
            }
            else
            {
                //continue
                Console.WriteLine();
            }
            

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? yes/no : ");
            string seeList = Console.ReadLine();

            if (seeList == "yes")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
            }
                Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                string addToList = Console.ReadLine();
                Console.WriteLine("");

                while (addToList == "yes")
                {
                    Console.Write("What activity would you like to add? ");
                    string userAddition = Console.ReadLine();
                    Console.WriteLine("");
                    activities.Add(userAddition);
                    
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to add another activity? yes/no: ");
                    //string addToList = bool.Parse(Console.ReadLine());
                    addToList = Console.ReadLine();
                }
            while (cont == "yes") 
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 11; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                do
                {
                    int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];


                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}. Wait {21 - userAge} more years.d");
                        Console.WriteLine("Pick something else!");
                        Console.WriteLine("");
                        activities.Remove(randomActivity);
                    
                    //string randomNumber = rng.Next(activities.Count);
                    randomNumber = rng.Next(activities.Count);
                    //string randomActivity = activities[randomNumber];
                    randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? done/another: ");
                    Console.WriteLine();
                    cont = Console.ReadLine();
                    if (cont == "done")
                    {
                        Environment.Exit(0);
                    }
                } while (cont == "another");
            } 
        }
    }
}
