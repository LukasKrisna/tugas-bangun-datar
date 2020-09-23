using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class Persegi 
    {
        public int sisiPersegi;
        public void luas(int sisiPersegi)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS PERSEGI");

            double luasPersegi = sisiPersegi * sisiPersegi;

            Console.WriteLine("Luas Persegi: " + luasPersegi);
        }
        public void keliling(int sisiPersegi)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG KELILING PERSEGI");

            double kelilingPersegi = 4 * sisiPersegi;

            Console.WriteLine("Keliling Persegi: " + kelilingPersegi);
        }
    }
}
