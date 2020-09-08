using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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

            if (alive == "ja")
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

            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("bomer");
       
            }

            while (alive == "nej")
            {
                Console.WriteLine("hur fan kan du vara här");
            }
            switch (age)
            {
                case 15:
                    Console.WriteLine("äntligen får du ligga");
                    break;
                case 18:
                    Console.WriteLine("nu fan blir det krogen");
                    break;
                default:
                    Console.WriteLine("snart dördu så lev livet");
                    break;
            }


        }
    }
}
