using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class LayangLayang
    {
        public void layangLayang()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS DAN KELILING LAYANG-LAYANG");
            Console.Write("Masukkan Diagonal 1: ");
            int diagonallyg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Diagonal 2: ");
            int diagonal2lyg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Sisi A: ");
            int sisiAlyg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Sisi C: ");
            int sisiClyg = Convert.ToInt32(Console.ReadLine());

            double luasLyg = 0.5 * diagonallyg * diagonal2lyg;
            double kelilingLyg = 2 * (sisiAlyg + sisiClyg);

            Console.WriteLine("Luas Layang-Layang: " + luasLyg);
            Console.WriteLine("Keliling Layang-Layang: " + kelilingLyg);
        }
    }
}
