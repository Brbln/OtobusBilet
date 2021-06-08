using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bilet:IEntity
    {
        public int BiletId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string KimlikNo { get; set; }
        public string Cinsiyet { get; set; }
        public string TelNo { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public int KoltukNo { get; set; }
        public decimal Fiyat { get; set; }
        public Sefer sefer { get; set; }
        public int SeferId { get; set; }
    }
}
