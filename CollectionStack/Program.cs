using System;
using System.Collections.Generic;

namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<string> hobby = new Stack<string>();

            hobby.Push("Drone Flying");
            hobby.Push("Boat Racing");

            Console.WriteLine("How many hobbies do you have?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the name of your hobby: ");
                hobby.Push(Console.ReadLine());
            }

            string firstHobby = hobby.Peek();
            Console.WriteLine($"Would you like to remove {firstHobby} from the end of the Stack (yes or no)? :");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                hobby.Pop();
                firstHobby = hobby.Peek();
                Console.WriteLine($"Would you like to remove {firstHobby} from the end of the Stack (yes or no)? :");
                answer = Console.ReadLine();
            }


            Console.WriteLine("Would you like to look for an existing hobby (yes or no):");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Enter the Hobby name:");
                string hobbyName = Console.ReadLine();
                if (hobby.Contains(hobbyName))
                {
                    Console.WriteLine("That hobby is on the list!");
                }
                else
                {
                    Console.WriteLine("Would you look at that, that hobby is not on the list...");
                }
                Console.WriteLine("Would you like to search for another hobby (yes or no):");
                answer = Console.ReadLine();
            }

            Console.WriteLine($"{hobby.Count()} That's a lot of hobbies!!");



            foreach (var b in hobby)
            {
                Console.WriteLine(b);
            }



            if (hobby.Peek() == null)
                Console.WriteLine("Your List Is Empty :(");
            else
                Console.WriteLine($"You have {hobby.Count} in total on your list.");

        }
    }
}
