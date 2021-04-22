using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriListesi = new List<Musteri>();
            MusteriManager musteriBll = new MusteriManager();

            musteriBll.musteriEkle(new Musteri(1,"yunus","demir",549876), musteriListesi);
            musteriBll.musteriEkle(new Musteri(2, "hamza", "taç", 4389438), musteriListesi);
            musteriBll.musteriEkle(new Musteri(3, "mustafa", "kerim", 343984), musteriListesi);
            musteriBll.musteriEkle(new Musteri(4, "bilal", "sırat", 34454354), musteriListesi);
            Console.WriteLine("** Musteriler Eklendi **");
            musteriBll.musteriListele(musteriListesi);
            musteriBll.musteriSil(3,musteriListesi);
            musteriBll.musteriListele(musteriListesi);

        }
    }
}
