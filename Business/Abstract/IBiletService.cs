using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBiletService
    {
        public void Add(Bilet bilet);
        public void Update(Bilet bilet);
        public void Delete(Bilet bilet);
        List<Bilet> GetAll();
        Bilet GetById(int id);
        int GetCountByKoltuk(int seferId);
        List<int> GetKoltuk(int seferId);
        Bilet GetSonKayit();
        int GetId();
        string GetTarih(int id);
        string GetSaat(int id);
        decimal GetFiyat(int id);


    }
}
