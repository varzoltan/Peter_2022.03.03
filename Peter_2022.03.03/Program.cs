using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peter_2022._03._03
{
    internal class Program
    {
        /*struct Adat
        {
            public int ora, perc, masodperc, halad_mp;
            public string varos;
        }*/
        class Adat
        {
            public int ora{get;set;}
            public int perc { get; set; }
            public int masodperc { get; set; }
            public int halad_mp { get; set; }
            public string varos { get; set; }
            public Adat(string sor)//konstruktor
            {
                string[] db = sor.Split(' ');
                ora = int.Parse(db[0]);
                perc = int.Parse(db[1]);
                masodperc = int.Parse(db[2]);
                halad_mp = int.Parse(db[3]);
                varos = db[4];
            }

        }
        
        static List<Adat> lista = new List<Adat>();
        //static Adat adatok = new Adat();
        static void Beolvas()
        {
            int athalado_jarmu = int.Parse(File.ReadLines("forgalom.txt").First());
            foreach (string i in File.ReadAllLines("forgalom.txt").Skip(1))
            {        
                lista.Add(new Adat(i));
            }
        }
        static void Main(string[] args)
        {
            //1.feladat
            Console.WriteLine("Adjon meg egy fájlnevet2");
            string valami = Console.ReadLine();
            Beolvas();

            //2.feladat
        }
    }
}
