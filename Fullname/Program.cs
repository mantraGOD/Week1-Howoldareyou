using System;

namespace Fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1.programm küsib kasutaja käest kasutaja eesnime 
            //Step 2.programm küsib kasutaja käest kasutaja perekonnanime
            //Step 3.programm tervitab kasutajat kasutades neid andmeid
            Console.WriteLine("Hello,What is you name?");
            string username = Console.ReadLine();

            Console.WriteLine($"Hello, {username}");

            Console.WriteLine("What is your lastname?");
            string lastname = Console.ReadLine();

            Console.WriteLine($"You have a good lastname, {lastname}");

            Console.WriteLine($"Nice to meet you,{username} {lastname}");

            Console.WriteLine($"{username}, are you gay by any chance??");
            Console.ReadLine();
            Console.WriteLine($"WOW,{username}");









        }
    }
}
