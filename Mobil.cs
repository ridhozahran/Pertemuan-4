using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mobil
    {
         //fields
        private string _Warna;
        private float _JumlahPintu;
        private string _Merek;
        private string _Model;
        private float _TahunKeluaran;

        //properti
        private string warna
        {
            get
            {
                return _Warna;
            }
            set
            {
                _Warna = value;
            }
        }
        private float jumlahPintu
        {
            get
            {
                return _JumlahPintu;
            }
            set
            {
                _JumlahPintu = value;
            }
        }
        private string merek
        {
            get
            {
                return _Merek;
            }
            set
            {
                _Merek = value;
            }
        }
        private string model
        {
            get
            {
                return _Model;
            }
            set
            {
                _Model = value;
            }
        }
        private float tahunKeluaran
        {
            get
            {
                return _TahunKeluaran;
            }
            set
            {
                _TahunKeluaran = value;
            }
        }
        public void HitungKecepatan(int jarak, int waktu)
        {
            double kecepatan = (double)jarak / waktu;
            Console.WriteLine($"Kecepatan mobil adalah {kecepatan} km/jam\n");
        }

        public void Klakson1()
        {
            Console.WriteLine("bunyi klakson : Tinnnn! Tinnnn!");
            Console.WriteLine("===================================\n");
        }
        public void Klakson2()
        {
            Console.WriteLine("bunyi klakson : beepppp! beepppp!");
            Console.WriteLine("===================================\n");
        }
        public void Klakson3()
        {
            Console.WriteLine("bunyi klakson :Trenkkk! Trenkkk!");
            Console.WriteLine("===================================\n");
        }
        public void TampilInfo()
        {
            Console.WriteLine($"Merek Mobil    : {_Merek} \n");
            Console.WriteLine($"Dengan model   : {_Model} \n");
            Console.WriteLine($"Variasi warna  : {_Warna} \n");
            Console.WriteLine($"Jumlah pintu   : {_JumlahPintu} pintu\n");
            Console.WriteLine($"Keluaran tahun : {_TahunKeluaran}");

            Console.ReadLine();
        }
    }
}

