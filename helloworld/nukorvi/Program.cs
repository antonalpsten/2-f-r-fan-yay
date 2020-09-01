using System;

namespace nukorvi
{
    class Program
    {
        static void Main(string[] args)
        {   
         
            Console.WriteLine("hello bomers!!!");

            Console.WriteLine("skriv ditt namn!");

            string User = Console.ReadLine();

            Console.WriteLine("skriv din ålder!");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("är du vid liv?");

            string alive = Console.ReadLine();

            if(alive == "ja")
            {
                Console.WriteLine(User);
                Console.WriteLine(age);
                Console.WriteLine("yay maoder f**ker!!");
            }
            else
            {
                Console.WriteLine(User);
                Console.WriteLine(age);
                Console.WriteLine(":(");
            }




        }
    }
}
