using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monitor
    {
        public string color;
        public int dimension;
        public int res_width;
        public int res_height;

    }
  

    class Program
    {
        static Monitor GetMonitor()
        {
            var Monitor1 = new Monitor();
            Console.WriteLine("Introduceti culoarea monitorului");
            Monitor1.color = Console.ReadLine();
            Console.WriteLine("Introduceti dimensiunea monitorului");
            Monitor1.dimension = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti width monitorului");
            Monitor1.res_width = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti height monitorului");
            Monitor1.res_height = int.Parse(Console.ReadLine());
            return Monitor1;
        }
        static Monitor GetMonitor2()
        {
            var Monitor2 = new Monitor();
            Monitor2.color = "black";
            Monitor2.dimension = 27;
            Monitor2.res_width = 1920;
            Monitor2.res_height = 1080;
            return Monitor2;
        }

        static void Print(Monitor Monitor1)
        {
            Console.WriteLine("#############################################");
            Console.WriteLine("Informatia despre primul monitor:");
            Console.WriteLine($"Color : {Monitor1.color}");
            Console.WriteLine($"Dimension : {Monitor1.dimension}cm");
            Console.WriteLine($"Resolution : {Monitor1.res_width}x{Monitor1.res_height}");
            Console.WriteLine("#############################################");
        }
        static void Print2(Monitor Monitor2)
        {
            Console.WriteLine("#############################################");
            Console.WriteLine("Informatia despre monitorul 2:");
            Console.WriteLine($"Color : {Monitor2.color}");
            Console.WriteLine($"Dimension : {Monitor2.dimension}cm");
            Console.WriteLine($"Resolution : {Monitor2.res_width}x{Monitor2.res_height}");
            Console.WriteLine("#############################################");
        }
        static void PrintMenu()
        {
            Console.WriteLine("--------------------Menu--------------------");
            Console.WriteLine("1 - Schimba parametrii primului monitor");
            Console.WriteLine("2 - Printeaza informatia despre primul monitor");
            Console.WriteLine("3 - Printeaza informatia despre monitorul 2");
            Console.WriteLine("4 - Compara monitoarele");
            Console.WriteLine("5 - Clean Console");
            Console.WriteLine("0 - EXIT");
            Console.WriteLine("--------------------Menu--------------------");
        }
        static void Compare(Monitor Monitor1 , Monitor Monitor2)
        {
            Console.WriteLine("#############################################");
            if (Monitor1.color == Monitor2.color)
                Console.WriteLine("Culorile sunt la fel");
            else 
                Console.WriteLine("Culorile nu sunt la fel");
            if(Monitor1.dimension == Monitor2.dimension)
                Console.WriteLine("Dimensiunele sunt egale");
            else
                Console.WriteLine("Dimensiunele nu sunt egale");
            if(Monitor1.res_width == Monitor2.res_width && Monitor1.res_height == Monitor2.res_height)
                Console.WriteLine("Resolutiile sunt la fel");
            else
                Console.WriteLine("Resolutiile nu sunt la fel");
            Console.WriteLine("#############################################");
        }


        static void Main(string[] args)
        {
            var firstMonitor = GetMonitor();
            var secondMonitor = GetMonitor2();
            PrintMenu();
            var x = int.Parse(Console.ReadLine());
            do
            { 
            switch (x)
                {
                    case 1:
                        firstMonitor = GetMonitor();
                        PrintMenu();
                        break;
                    case 2:
                        Print(firstMonitor);
                        PrintMenu();
                        break;
                    case 3:
                        Print2(secondMonitor);
                        break;
                    case 4:
                        Compare(firstMonitor, secondMonitor);
                        break;
                    case 5:
                        Console.Clear();
                        PrintMenu();
                        break;
                }
                x = int.Parse(Console.ReadLine());
            } while (x > 0);

    }
    }
}
