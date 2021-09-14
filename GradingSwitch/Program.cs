using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            string Hinne = Console.ReadLine().ToLower();

            switch (Hinne)
            {
                case "5":
                    Console.WriteLine("Suurepärane");
                    break;
                case "4":
                    Console.WriteLine("Väga hea");
                    break;
                case "3":
                    Console.WriteLine("Hea");
                    break;
                case "2":
                    Console.WriteLine("Rahulav");
                    break;
                default:
                    Console.WriteLine("Puudulik");
                    break;
            }




        }
    }
}
