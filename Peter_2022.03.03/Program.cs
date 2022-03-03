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
        struct Adat
        {
            public int ora, perc, masodperc, halad_mp;
            public string varos;     
        }
  

        static void Main(string[] args)
        {
            List<Adat> lista = new List<Adat>();
            Adat adatok = new Adat();
            int athalado_jarmu = int.Parse(File.ReadLines("forgalom.txt").First());
            foreach(var i in File.ReadAllLines("forgalom.txt").Skip(1))
            {
                string[] db =i.Split(' ');
                adatok.ora = int.Parse(db[0]);
                adatok.perc = int.Parse(db[1]);
                adatok.masodperc = int.Parse(db[2]);
                adatok.halad_mp = int.Parse(db[3]);
                adatok.varos = db[4];
                lista.Add(adatok);
            }
        }
    }
}
