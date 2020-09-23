using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class Jajargenjang
    {
        public void jajarGenjang()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MENGHITUNG LUAS DAN KELILING JAJAR GENJANG");
            Console.Write("Masukkan Alas: ");
            int alasJg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Tinggi: ");
            int tinggiJg = Convert.ToInt32(Console.ReadLine());

            double luasJg = alasJg * tinggiJg;
            double kelilingJg = 2 * alasJg + tinggiJg;

            Console.WriteLine("Luas Jajar Genjang: " + luasJg);
            Console.WriteLine("Keliling Jajar Genjang: " + kelilingJg);
        }
    }
}
