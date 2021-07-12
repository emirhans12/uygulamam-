using System;

namespace aritmetik_işlemler
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, sonuc;
            Console.Write("Birinci Sayıyı Girin :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayıyı Girin : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü Sayıyı Girin : ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dördüncü Sayıyı Girin : ");
            d = Convert.ToDouble(Console.ReadLine());

            sonuc = (a + b) / c * d;
            Console.WriteLine("(a + b) / c * d = " + sonuc);
            sonuc = a * d + c / b;
            Console.WriteLine("a * d + c / b = " + sonuc);
            sonuc = a * a + b * b / c * c + d * d;
            Console.WriteLine("a * a + b * b / c * c + d * d = " + sonuc);
            sonuc = a * a * a + c * c + b / d;
            Console.WriteLine("a * a * a + c * c + b / d = " + sonuc);
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //    double a, b, c, sonuc;
            //    Console.Write("Birinci yazılı :");
            //    a = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("İkinci yazılı : ");
            //    b = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Üçüncü yazılı : ");
            //    c = Convert.ToDouble(Console.ReadLine());
            //    sonuc = (a + b + c) / 3;
            //    Console.WriteLine(" ortalama notu : " + sonuc);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            //double boy, kilo, indeks = 0;
            //Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,65)  : ");
            //boy = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Kilonuzu Giriniz : ");
            //kilo = Convert.ToDouble(Console.ReadLine());
            //indeks = kilo / (boy * boy);


            //Console.WriteLine("Vücut Kitle İndexiniz : {0}", indeks);
            //if (indeks < 18)
            //{
            //    Console.WriteLine("Zayıf");
            //}
            //else if (indeks >= 18 && indeks < 25)
            //{
            //    Console.WriteLine("Normal");
            //}
            //else if (indeks >= 25 && indeks < 30)
            //{
            //    Console.WriteLine("Kilolu");
            //}
            //else if (indeks >= 30 && indeks < 35)
            //{
            //    Console.WriteLine("Obez");
            //}
            //else
            //{
            //    Console.WriteLine("Ciddi Obez");
            //}
            //int x, y, z;
            //double ortalama, toplam;
            //Console.WriteLine("x girin");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("y girin");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("z girin");
            //z = Convert.ToInt32(Console.ReadLine());
            //toplam = x + y + z;

            //ortalama = toplam / 3;
            //Console.WriteLine("Toplam :" + toplam);
            //Console.WriteLine("Ortalama :" + ortalama);
            //Console.ReadKey();
            ////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
