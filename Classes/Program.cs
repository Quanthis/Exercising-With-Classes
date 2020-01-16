using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 przykladowabron = new Class1();
            przykladowabron.Wypisz();
            Console.WriteLine();

            Class1 innabron = new Class1("podgatunek innej broni",34.43);
            innabron.Wypisz();
            Console.WriteLine();

            Class1 innabron2 = new Class1("inny podgatunek", 45.54);
            innabron.Wypisz();

            Console.Write("Ilość rodzajów broni:" + Class1.Count);

            Console.ReadKey();
        }
    }
}
