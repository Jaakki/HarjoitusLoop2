using System;
using System.Collections.Generic;

namespace HarjoitusLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comic bat1 = new Comic();
            bat1.name = "Bat-Man";
            bat1.price = 3;
            bat1.publisher = "DC Comics";
            bat1.issueNumber = 20;

            Comic bat2 = new Comic();
            bat2.name = "Bat-Man";
            bat2.price = 3;
            bat2.publisher = "DC Comics";
            bat2.issueNumber = 24;

            Comic bat3 = new Comic();
            bat3.name = "Bat-Man";
            bat3.price = 3;
            bat3.publisher = "DC Comics";
            bat3.issueNumber = 27;

            List<Comic> comics = new List<Comic>();
            comics.Add(bat1);
            comics.Add(bat2);
            comics.Add(bat3);

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"{bat1.name} {bat1.price} {bat1.publisher} {bat1.issueNumber}");
                Console.WriteLine($"{bat2.name} {bat2.price} {bat2.publisher} {bat2.issueNumber}");
                Console.WriteLine($"{bat3.name} {bat3.price} {bat3.publisher} {bat3.issueNumber}");
            }

            for (int i = 1; i < 13; i++)
            {
                Comic spider = new Comic("Spider-Man", 4, "Marvel", i);
                comics.Add(spider);
            }

            for (int i = 1; i < 13; i++)
            {
                Comic hulk = new Comic("Incredible Hulk", 2, "Marvel", i);
                comics.Add(hulk);
            }

            //for (int i = 0; i < comics.Count; i++)
            //{
            //    Console.WriteLine($"{comics[i].name} | {comics[i].publisher} | issue:{comics[i].issueNumber} | {comics[i].price}$");
            //}

            int x = 0;
            int y = 0;
            for (int i = 0; i < comics.Count; i++)
            {
                y = i+1;
                x += comics[i].price;
                Console.WriteLine($"{comics[i].name} | {comics[i].publisher} | issue:{comics[i].issueNumber} | {comics[i].price}$");
            }
            Console.WriteLine($"\n{x}");
            Console.WriteLine($"{x / y}");
        }
    }
}
