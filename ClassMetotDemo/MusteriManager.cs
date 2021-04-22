using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class MusteriManager
    {

        public void musteriEkle(Musteri musteri,List<Musteri> musteriListesi)
        {
            musteriListesi.Add(musteri);
            

        }
        
        public void musteriListele(List<Musteri> musteriListesi)
        {
            Console.WriteLine("\nMusteriler Listeleniyor..\n");
            foreach (var musteri in musteriListesi) {
                Console.WriteLine("Id:" + musteri.musteriID+ " Adı: "+musteri.musteriAdi+" Soyadi: "+musteri.musteriSoyadi+ " Telefon: "+
                    musteri.musteriTel);
            }
            Console.WriteLine("\nMusteriler Listelendi..\n");

        }

        public void musteriSil(int id, List<Musteri> musteriListesi)
        {
            
            musteriListesi.RemoveAt(id);
            Console.WriteLine("\n"+id+". Musteri Silindi.");
        }

    }
}
