using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class BiletSefer
    {
        public List<Bilet> Biletler { get; set; }
        public List<Sefer> Seferler { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public Sefer YeniSefer { get; set; }
        public string saat { get; set; }
        public string tarih { get; set; }
        public decimal fiyat { get; set; }
        public Bilet bilet { get; set; }

    }
}
