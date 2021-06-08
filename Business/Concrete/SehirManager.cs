using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SehirManager : ISehirService
    {
        ISehirDal _cityDal;
        public SehirManager(ISehirDal cityDal)
        {
            _cityDal = cityDal;
        }
        public void Add(Sehir city)
        {
            _cityDal.Add(city);
        }

        public void Delete(Sehir city)
        {
            _cityDal.Delete(city);
        }

        public List<Sehir> GetAll()
        {
            return _cityDal.GetAll();
        }

        public Sehir GetById(int id)
        {
            return _cityDal.Get(a => a.SehirId == id);
        }

        public void Update(Sehir city)
        {
            _cityDal.Update(city);
        }
    }
}
