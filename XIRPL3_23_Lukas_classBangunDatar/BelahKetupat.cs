using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class BelahKetupat
    {
        public void belahKetupat()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS DAN KELILING BELAH KETUPAT");
            Console.Write("Masukkan Diagonal 1: ");
            int diagonal1bk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Diagonal 2: ");
            int diagonal2bk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Sisi: ");
            int sisiBK = Convert.ToInt32(Console.ReadLine());

            double luasBK = 0.5 * diagonal1bk * diagonal2bk;
            double kelilingBK = 4 * sisiBK;

            Console.WriteLine("Luas Belah Ketupat: " + luasBK);
            Console.WriteLine("Keliling Belah Ketupat: " + kelilingBK);
        }
    }
}
