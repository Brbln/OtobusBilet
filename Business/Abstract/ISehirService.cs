
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISehirService
    {
        public void Add(Sehir city);
        public void Update(Sehir city);
        public void Delete(Sehir city);
        List<Sehir> GetAll();
        Sehir GetById(int id);
    }
}
