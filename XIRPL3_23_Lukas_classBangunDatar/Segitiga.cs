using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class Segitiga
    {
        public void segitiga()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS DAN KELILING SEGITIGA");
            Console.Write("Masukkan Tinggi: ");
            int tinggi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Alas: ");
            double alas = double.Parse(Console.ReadLine());
            Console.Write("Masukkan Sisi: ");
            double sisi = double.Parse(Console.ReadLine());

            double luasSegitiga = 0.5 * tinggi * alas;
            double kelilingSegitiga = sisi * sisi * sisi;

            Console.WriteLine("Luas Segitiga: " + luasSegitiga);
            Console.WriteLine("Keliling Segitiga: " + kelilingSegitiga);
        }
    }
}
