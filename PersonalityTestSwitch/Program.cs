using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane" konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine" konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline" konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, kosool kuva "oled ükssarvik";

            Console.WriteLine("Mis on su lemmik värv?");
            string usercolor = Console.ReadLine().ToLower();

            switch (usercolor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                        case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {usercolor} ükssarvik");
                    break;

            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
