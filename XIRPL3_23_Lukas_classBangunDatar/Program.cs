using System;

namespace XIRPL3_23_Lukas_classBangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===MENGHITUNG LUAS DAN KELILING BANGUN DATAR===");
            Console.WriteLine("===============BANGUN DATAR===============");
            Console.WriteLine(" 1. Segitiga \n 2. Persegi \n 3. Persegi Panjang \n 4. Jajar Genjang \n 5. Trapesium \n 6. Layang-layang \n 7. Belah Ketupat \n 0. Kembali");
            Console.Write("Masukkan Pilihan : ");
            string pilihan = Console.ReadLine();
            int pilih = Int32.Parse(pilihan);
            switch (pilih)
            {
                case 1:
                    Segitiga segitiga1 = new Segitiga();
                    segitiga1.segitiga();
                    break;
                case 2:
                    Console.WriteLine("Masukkan Sisi: ");
                    int sisi = Convert.ToInt32(Console.ReadLine());
                    Persegi persegi1 = new Persegi();
                    persegi1.luas(sisi);
                    persegi1.keliling(sisi);
                    break;
                case 3:
                    PersegiPanjang persegiPanjang1 = new PersegiPanjang();
                    persegiPanjang1.persegiPanjang();
                    break;
                case 4:
                    Jajargenjang jajarGenjang1 = new Jajargenjang();
                    jajarGenjang1.jajarGenjang();
                    break;
                case 5:
                    Trapesium trapesium1 = new Trapesium();
                    trapesium1.trapesium();
                    break;
                case 6:
                    LayangLayang layangLayang1 = new LayangLayang();
                    layangLayang1.layangLayang();
                    break;
                case 7:
                    BelahKetupat belahKetupat1 = new BelahKetupat();
                    belahKetupat1.belahKetupat();
                    break;
                default:
                    Console.WriteLine("Kembali ke awal");
                    break;
            }
            Console.ReadLine();
        }
    }
}
