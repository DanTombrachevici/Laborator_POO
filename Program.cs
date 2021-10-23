using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Text
    {
        public string text1;

        public void Read()
        {
            text1 = System.IO.File.ReadAllText("Textul.txt");
            System.Console.WriteLine("Textul :\n{0}\n",text1);
        }

        public void number_s()
        {
            string[] sent = text1.Split('.');
            int sentences = sent.Length;
            Console.WriteLine("Numarul de propozitii {0}", sentences);
        }

        public void number_w()
        {
            string[] word = text1.Split(' ');
            int w = word.Length;
            Console.WriteLine("Numarul de cuvinte {0}", w);
        }
        public void number_l()
        {
            int vocale = 0;
            int consoane = 0;

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] == 'a' || text1[i] == 'e' || text1[i] == 'i' || text1[i] == 'o' || text1[i] == 'u' || text1[i] == 'A' || text1[i] == 'E' || text1[i] == 'I' || text1[i] == 'O' || text1[i] == 'U')
                    vocale++;
                else
                    consoane++;
            }
            int litere = vocale + consoane;

            Console.WriteLine("Numarul de vocale {0}", vocale);
            Console.WriteLine("Numarul de consoane {0}", consoane);
            Console.WriteLine("Numarul de litere {0}", litere);

        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Text text = new Text();
            text.Read();
            text.number_s();
            text.number_w();
            text.number_l();


        }
    }
}
