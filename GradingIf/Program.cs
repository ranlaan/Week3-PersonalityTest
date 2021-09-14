using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            int Hinne = Convert.ToInt32(Console.ReadLine());

            if (Hinne == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (Hinne == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (Hinne == 3)
            {
                Console.WriteLine("Hea");
            }
            else if (Hinne == 2)
            {
                Console.WriteLine("Rahuldav");
            }
            else
            {
                Console.WriteLine("Puudulik");
            }




        }
    }
}
