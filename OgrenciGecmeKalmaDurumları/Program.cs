using System;

namespace OgrenciGecmeKalmaDurumları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci bilgisi girilecek...");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciler = new string[n]; // öğrenci isimleri....
            float[] ortalamalar = new float[n];

            for (int i = 0; i < n; i++)
            {
                int sira = i + 1;
                Console.WriteLine($"{sira} öğrencinin adı");
                ogrenciler[i] = Console.ReadLine();

                Console.WriteLine($"{sira} öğrencinin vize notu");
                float vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{sira} öğrencinin final notu");
                float final = Convert.ToSingle(Console.ReadLine());

                ortalamalar[i] = (vize * 0.4f) + (final * 0.6f);
            }


            float genelToplam = 0;
            foreach (var item in ortalamalar)
                genelToplam += item;

            float genelOrtalama = genelToplam / n;

            string[] kalanlar = new string[0];
            string[] gecenler = new string[0];


            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] >= genelOrtalama)
                {
                    Array.Resize(ref gecenler, gecenler.Length + 1);
                    gecenler[gecenler.Length - 1] = ogrenciler[i];
                }
                else
                {
                    Array.Resize(ref kalanlar, kalanlar.Length + 1);
                    kalanlar[kalanlar.Length - 1] = ogrenciler[i];
                }
            }

            Console.WriteLine("\nÖğrenci Durumları\n");

            foreach (var item in kalanlar)
            {
                int varMi = Array.IndexOf(ogrenciler, item);
                if (varMi != -1)
                {
                    Console.WriteLine($"{item} kaldı. Ortalaması = {ortalamalar[varMi]}");
                }
            }

            Console.WriteLine("*********************");

            foreach (var item in gecenler)
            {
                int varMi = Array.IndexOf(ogrenciler, item);
                if (varMi != -1)
                {
                    Console.WriteLine($"{item} geçti. Ortalaması = {ortalamalar[varMi]}");
                }
            }

            Console.ReadKey();

        }
    }
}
