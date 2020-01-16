using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Class1
    {
        public static int Count = 0;
        public string nazwa;
        public double atak;

        public Class1()
        {
            atak = 3454.345;
            nazwa = "PrzykładowaNazwa";
            Count++;
            //Obrona = obrona;
        }
        public Class1(string nazwa_, double atak_)
        {
            nazwa = nazwa_;
            atak = atak_;
            Count++;
        }
        public void Wypisz()
        {
            Console.WriteLine(nazwa);
            Console.WriteLine(atak);
        }
        //public double Atak { get; set; }
        //public double Obrona { get; set; }
        
    }
}
