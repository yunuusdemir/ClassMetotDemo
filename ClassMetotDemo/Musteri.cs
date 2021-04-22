using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class Musteri
    {
        public Musteri(int id,string adi,string soyadi,long tel)
        {
            this.musteriID = id;
            this.musteriAdi = adi;
            this.musteriSoyadi = soyadi;
            this.musteriTel = tel;
        }
        public int musteriID { get; set; }
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public long musteriTel { get; set; }

    }
}
