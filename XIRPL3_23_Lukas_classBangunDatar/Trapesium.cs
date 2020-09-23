using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class Trapesium
    {
        public void trapesium()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS DAN KELILING TRAPESIUM");
            Console.Write("Masukkan Tinggi: ");
            int tinggiT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan sisi A: ");
            int sisiAt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan sisi B: ");
            int sisiBt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan sisi C: ");
            int sisiCt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan sisi D: ");
            int sisiDt = Convert.ToInt32(Console.ReadLine());

            double luasTrapesium = 0.5 * (sisiAt + sisiBt) * tinggiT;
            double kelilingTrapesium = sisiAt + sisiBt + sisiCt + sisiDt;

            Console.WriteLine("Luas Trapesium: " + luasTrapesium);
            Console.WriteLine("Keliling Trapesium: " + kelilingTrapesium);
        }
    }
}
