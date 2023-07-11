using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();

            // Set properti mobil
            mobil1._Warna = "Putih";
            mobil1._JumlahPintu = 2;
            mobil1._Merek = "lamborgini";
            mobil1._Model = "Veneno Roadster";
            mobil1._TahunKeluaran = 2013;

            // Panggil method mobil
            mobil1.TampilInfo();
            mobil1.Klakson1();
            mobil1.HitungKecepatan(710, 2);

            Mobil mobil2 = new Mobil();

            // Set properti mobil
            mobil2._Warna = "Hitam";
            mobil2._JumlahPintu = 2;
            mobil2._Merek = "Bugatti";
            mobil2._Model = "Chiron";
            mobil2._TahunKeluaran = 2018;

            // Panggil method mobil
            mobil2.TampilInfo();
            mobil2.Klakson2();
            mobil2.HitungKecepatan(620, 2);

            Mobil mobil3 = new Mobil();

            // Set properti mobil
            mobil3._Warna = "Merah";
            mobil3._JumlahPintu = 2;
            mobil3._Merek = "Ferari";
            mobil3._Model = "J50";
            mobil3._TahunKeluaran = 2016;

            // Panggil method mobil
            mobil3.TampilInfo();
            mobil3.Klakson3();
            mobil3.HitungKecepatan(1028, 2);

            Console.WriteLine("tekan random key untuk menghentikan program\n");


            Console.ReadKey();
        }
    }
}
