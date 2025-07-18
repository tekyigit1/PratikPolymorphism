using System;

namespace GeometrikSekiller
{
    // Tüm şekillerin ortak özelliklerini içeren base class
    class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Alan hesaplama metodu - alt sınıflarda override edilecek
        public virtual double AlanHesapla()
        {
            return 0;
        }
    }

    // Kare sınıfı - BaseGeometrikSekil'den kalıtım alır
    class Kare : BaseGeometrikSekil
    {
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;  // Karede alan = Genişlik x Yükseklik
        }
    }

    // Dikdörtgen sınıfı
    class Dikdortgen : BaseGeometrikSekil
    {
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;  // Dikdörtgende de aynı hesap
        }
    }

    // Dik üçgen sınıfı
    class DikUcgen : BaseGeometrikSekil
    {
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;  // Dik üçgende alan = (Genişlik x Yükseklik) / 2
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism örneği: Her şekli BaseGeometrikSekil türünde tanımlıyoruz
            BaseGeometrikSekil kare = new Kare { Genislik = 5, Yukseklik = 5 };
            BaseGeometrikSekil dikdortgen = new Dikdortgen { Genislik = 4, Yukseklik = 6 };
            BaseGeometrikSekil dikUcgen = new DikUcgen { Genislik = 3, Yukseklik = 4 };

            // Alan sonuçlarını ekrana yazdır
            Console.WriteLine("Kare Alanı: " + kare.AlanHesapla());
            Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen.AlanHesapla());
            Console.WriteLine("Dik Üçgen Alanı: " + dikUcgen.AlanHesapla());
        }
    }
}
