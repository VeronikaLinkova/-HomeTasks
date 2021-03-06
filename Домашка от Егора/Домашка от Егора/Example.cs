﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Домашка_от_Егора
{
    public class Example
    {
        //задание 1
        public int Sum(int x, int y, int z)
        {
            int t = x * y + 37;
            if (t>0)
            {
                z = 2 * z;
                int rez = 7 * x + y;
                return rez;
            }
            else
            {
                if (x!=0)
                {
                    z = z / 2;
                }
                else
                {
                    z = z / 5;
                }
                int rez = 5 * y-x;
                return rez;               
            }            
        }

        //задание 2
        public int[] Age(int a, int b)
        {
            
            int averageAge = (a + b) / 2;
            int deviation1 = Math.Abs(a - averageAge);
            int deviation2 = Math.Abs(b - averageAge);
            int[] info = new int[3] {averageAge, deviation1, deviation2};
            return info;
        }
        //задание 3
        public double Fahrenheit(double cel)
        {            
            double far = (1.8 * cel)+32;
            return far;
        }

        public double Kelvin(double a)
        {
            double b = a+273.15;
            return b;            
        }

        //задание 4
        public int Val()
        {
            int rez = (564 % 10) * 100 + (564 / 100) + (((564 / 10) % 10)) * 10;
            return rez;
        }
        //задание 5
        public void KrugVKvadrate(double skv, double skr)
        {
            //d - диаметр круга
            //a - сторона квадрата
            // p - число пи
            // d_kv - диаметр квадрата
            double a = 0;
            double p = 3.1415926535897931;
            double d_kv = Math.Sqrt(2 * (a * a));
            a = Math.Sqrt(skv);
            double d = Math.Sqrt((4 * skr) / p);
            if (d <= a)
            {
                Console.WriteLine("Круг помещается в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не помещается в квадрате");
            }


            if (d_kv <= d)
            {
                Console.WriteLine("Квадрат помещается в круг");
            }
            else
            {
                Console.WriteLine("Квадрат не помещается в круг");
            }
        }
        //задание 6
        public void Delenie(int m, int n)
        {
            if ((m%n)==0)
            {
                Console.WriteLine(m / n);
            }
            else
            {
                Console.WriteLine("m на n нацело не делится");
            }
        }
        //задание 7
        public void NumberСomparison(int x)
        {
            int x1 = x / 100;
            int x2 = (x / 10) % 10;
            int x3 = x % 10;
            if (x1>x3)
            {
                Console.WriteLine("Первое число больше третьего");
            }
            else if(x1==x3)
            {
                Console.WriteLine("Первое число равно третьему");
            }
            
            else
            {
                Console.WriteLine("Последнее число больше первого");
            }
            if (x1>x2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (x1==x2)
            {
                Console.WriteLine("Первое число равно второму");
            }
            else
            {
                Console.WriteLine("Второе число больше первого");
            }

            if (x2>x3)
            {
                Console.WriteLine("Второе число больше третьего");
            }
            else if (x2==x3)
            {
                Console.WriteLine("Второе число равно третьему");
            }
            else
            {
                Console.WriteLine("Третье число больше второго");
            }
        }
        //задание 8
        public void Number(int x, int n)
        {
            int x1 = x / 100;
            int x2 = (x / 10) % 10;
            int x3 = x % 10;
            int[] list_line_num = new int[3] {x1,x2,x3};
            foreach(int elem in list_line_num)
            {
                if (elem ==6)
                {
                    Console.WriteLine($"Число 6 входит в число {x}");
                }
                else
                {
                    Console.WriteLine($"Число 6 не входит в число {x}");
                }
                break;
            }
            foreach (int elem in list_line_num)
            {
                if (elem == n)
                {
                    Console.WriteLine($"Число {n} входит в число {x}");
                }
                else
                {
                    Console.WriteLine($"Число {n} не входит в число {x}");
                }
                break;
            }
        }
        //задание 9
        public void DaysOfTheWeek(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;

                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
        }
        //задание 10
        public void EvenNumbers(int n)
        {
            int j = 0;
            Random r = new Random();            
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(1, 100);

            }
            foreach (int i in array)
            {
                if ((i%2)==0)
                {
                    j += 1;
                }
                Console.WriteLine(i);               
            }
            Console.WriteLine(j);
        }
        //задание 11
        public int MinNumber()
        {
            int x = 200;
            int min = x % 17;
            while(min!=0)
            {
                x += 1;
                min = x % 17;         
            }
            return x;
        }
        //задание 12
        public int FootballClub(string name)
        {
            return name.Length;
        }
        //задание 13
        public void Informatica()
        {
            string sourceLine = "информатика";            
            string text1 = sourceLine.Substring(2, sourceLine.Length - 6);
            string text2 = sourceLine.Substring(7, sourceLine.Length - 8);
            Console.WriteLine(text1);
            Console.WriteLine(text2);
        }
        //задание 15
        public void LetterCombinations(string name)
        {                     
            char ch = 'е';
            int indexOfCharFirst = name.IndexOf(ch); 
            Console.WriteLine(indexOfCharFirst+1);
            int indexOfCharLast = name.LastIndexOf(ch); 
            Console.WriteLine(indexOfCharLast+1);
        }
    }
}