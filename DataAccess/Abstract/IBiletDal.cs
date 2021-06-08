using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBiletDal : IEntityRepository<Bilet>
    {
        int GetCountByKoltuk(int seferId);
        List<int> GetKoltuk(int seferId);
        Bilet GetSonKayit();
        int GetId();
        string GetTarih(int id);
        string GetSaat(int id);
        decimal GetFiyat(int id);
    }
}
