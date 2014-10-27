using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    class Program
    {
        

        //Start!
        static void Main(string[] args)
        {
            //Variables
            string name; //Player's Name
            string choice; //A varible used to store player actions
            int mhp = 0; //Montser's HP
            int mpow = 0; //Montser's Power
            
            while (true) //Name Selection Loop
            {
                Console.WriteLine("What is your name, Sir?");
                name = Console.ReadLine();
                if (name == "" || name == " " || name == "  "|| name == "   ")
                {
                    Console.Clear();
                    Console.WriteLine("That is not a valid name!");
                    Console.WriteLine();
                }
                else if (name != "")
                {
                    Console.Clear();
                    break;
                }
               

            }
            string thing = "Name Saved As: " + name;
            Console.WriteLine(thing);
            for (int i = 0; i <= thing.Length; i++) // Takes variable "thing" and makes all of the lined spaces (------------) a certain length 
            {
                Console.Write("-");
                if (i == thing.Length)
                {
                    Console.WriteLine("");
                }
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("You find a monster!");
            System.Threading.Thread.Sleep(1000);
            while (true) // Monster Loop
            {
                Console.WriteLine("Current Stats");
                for (int i = 0; i <= thing.Length; i++)
                {
                    Console.Write("-");
                    if (i == thing.Length)
                    {
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("HP = " + mhp);
                Console.WriteLine("POW = " + mpow);
                Console.Clear();
                Console.WriteLine("What will you do?");
                for (int i = 0; i <= thing.Length; i++)
                {
                    Console.Write("-");
                    if (i == thing.Length)
                    {
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("1 - Attack");
                for (int i = 0; i <= thing.Length; i++)
                {
                    Console.Write("-");
                    if (i == thing.Length)
                    {
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("2 - Block");
                for (int i = 0; i <= thing.Length; i++)
                {
                    Console.Write("-");
                    if (i == thing.Length)
                    {
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("3 - Run");
                for (int i = 0; i <= thing.Length; i++)
                {
                    Console.Write("-");
                    if (i == thing.Length)
                    {
                        Console.WriteLine("");
                      
                    }

                }
                choice = Console.ReadLine();
            }




        }

       


    }
}
