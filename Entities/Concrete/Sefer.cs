using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sefer:IEntity
    {
        public int SeferId { get; set; }
        public string SeferTarihi { get; set; }
        public string KalkisSehir { get; set; }
        public string VarisSehir { get; set; }
        public string KalkisZamani { get; set; }
        public decimal SeferUcreti { get; set; }
        public List<Bilet> Bilets { get; set; }
    }
}
