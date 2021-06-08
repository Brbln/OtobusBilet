using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BiletManager : IBiletService
    {
        IBiletDal _biletDal;

        public BiletManager(IBiletDal biletDal)
        {
            _biletDal = biletDal;
        }

        public void Add(Bilet bilet)
        {
            _biletDal.Add(bilet);
        }

        public void Delete(Bilet bilet)
        {
            _biletDal.Delete(bilet);
        }

        public List<Bilet> GetAll()
        {
            return _biletDal.GetAll();
        }

        public Bilet GetById(int id)
        {
            return _biletDal.Get(a => a.BiletId == id);
        }

        public int GetCountByKoltuk(int seferId)
        {
            return _biletDal.GetCountByKoltuk(seferId);
        }

        public decimal GetFiyat(int id)
        {
            return _biletDal.GetFiyat(id);
        }

        public int GetId()
        {
            return _biletDal.GetId();
        }
       
        public List<int> GetKoltuk(int seferId)
        {
            return _biletDal.GetKoltuk(seferId);
        }

        public string GetSaat(int id)
        {
            return _biletDal.GetSaat(id);
        }

        public Bilet GetSonKayit()
        {
            return _biletDal.GetSonKayit();
        }

        public string GetTarih(int id)
        {
            return _biletDal.GetTarih(id);
        }

        public void Update(Bilet bilet)
        {
            _biletDal.Update(bilet);
        }
    }
}
