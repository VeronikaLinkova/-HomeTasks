using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка_от_Егора
{
    class Program
    {
        static void Main(string[] args)
        {
            Example Ololo = new Example();
            //1
            int a = Ololo.Sum(-100,1, 9);
            Console.WriteLine(a);
            Console.ReadKey();

            //2
           int[] mas = Ololo.Age(10, 6);
           foreach (int elem in mas)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();

            //3
            Console.WriteLine(Ololo.Fahrenheit(10));
            Console.WriteLine(Ololo.Kelvin(-100));
            Console.ReadKey();

            //4
            Console.WriteLine(Ololo.Val());

            //5
            Ololo.KrugVKvadrate(30, 40);

            //6
            Ololo.Delenie(40,1);
            Ololo.Delenie(40,2);
            Ololo.Delenie(40,3);
            Ololo.Delenie(40,4);
            Ololo.Delenie(40,5);
            Ololo.Delenie(40,400);

            //7
            Ololo.NumberСomparison(454);

            //8
            Ololo.Number(123, 9);
            Ololo.Number(0, 0);

            //9
            Ololo.DaysOfTheWeek(1);

            //10
            Ololo.EvenNumbers(8);
            
            //11
            Console.WriteLine(Ololo.MinNumber());

            //12
            Console.WriteLine($"В футбольном клубе Барселона {Ololo.FootballClub("Барселона")} знаков");

            //13            
            Ololo.Informatica();

            //15
            Ololo.LetterCombinations("елки зеленые");
            Console.ReadKey();
        }

    }
}
