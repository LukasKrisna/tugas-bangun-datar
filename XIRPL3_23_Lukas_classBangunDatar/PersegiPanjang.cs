using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class PersegiPanjang
    {
        public void persegiPanjang()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS DAN KELIING PERSEGI PANJANG");
            Console.Write("Masukkan Panjang: ");
            int panjangPP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Lebar: ");
            int lebarPP = Convert.ToInt32(Console.ReadLine());

            double luasPP = panjangPP * lebarPP;
            double kelilingPP = 2 * panjangPP + lebarPP;

            Console.WriteLine("Luas Persegi Panjang: " + luasPP);
            Console.WriteLine("Keliling Persegi Panjang: " + kelilingPP);
        }
    }
}
