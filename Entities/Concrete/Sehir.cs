using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sehir:IEntity
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }       
        public override string ToString()
        {
            return $"{SehirId,-5} {SehirAdi}";
        }
    }
}
