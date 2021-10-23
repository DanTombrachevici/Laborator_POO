using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Box
{
        public float Height { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public Box()
    {
            Height = 1;
            Width = 1;
            Depth = 1;

        }
    public Box(float value)
    {
            Height = value;
            Width = value;
            Depth = value;

        }
    public Box(float height, float width, float depth)
    {
            Height = height;
            Width = width;
            Depth = depth;

       }

}

    class Program
    {


        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box(10);
            Box box3 = new Box(20,30,40);
            float A;
            float V;
           

            Console.WriteLine("####################Box-1####################");
            Console.WriteLine($"Height : {box1.Height}");
            Console.WriteLine($"Height : {box1.Width}");
            Console.WriteLine($"Height : {box1.Depth}");
            Console.WriteLine("#############################################");

            Console.WriteLine("####################Box-2####################");
            Console.WriteLine($"Height : {box2.Height}");
            Console.WriteLine($"Height : {box2.Width}");
            Console.WriteLine($"Height : {box2.Depth}");
            Console.WriteLine("#############################################");

            Console.WriteLine("####################Box-3####################");
            Console.WriteLine($"Height : {box3.Height}");
            Console.WriteLine($"Height : {box3.Width}");
            Console.WriteLine($"Height : {box3.Depth}");
            Console.WriteLine("#############################################");

            if (box3.Height == box3.Width && box3.Width == box3.Depth)
            {
                A = box3.Depth * box3.Depth  *6;
                V = box3.Depth * box3.Depth * box3.Depth;

                Console.WriteLine($"Aria = {A}");
                Console.WriteLine($"Volumul = {V}");
            }
            else
            {
                A = 2 * (box3.Depth * box3.Width + box3.Depth * box3.Height + box3.Width * box3.Height);
                V =box3.Depth * box3.Width * box3.Height;
                Console.WriteLine($"Aria = {A}");
                Console.WriteLine($"Volumul = {V}");
            }

        }
    }
}
