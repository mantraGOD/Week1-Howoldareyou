using System;

namespace howoldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            
            String UserName = Console.ReadLine();
            //Console.WriteLine("Hello, " + UserName + "!");
            //String interpolation
            Console.WriteLine ($"Hello,{UserName} ");
           
            Console.WriteLine("how old are you? Enter digits only:");

            int Age = Int32.Parse(Console.ReadLine());
            
            int YearOfBirth = 2021 - Age;
            
            Console.WriteLine($"You were born in {YearOfBirth}");

            
            
            Console.Read();


        }   

    }
}
