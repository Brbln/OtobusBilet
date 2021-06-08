using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SeferManager : ISeferService
    {
        ISeferDal _seferDal;
        public SeferManager(ISeferDal expeditionDal)
        {
            _seferDal = expeditionDal;
        }
        public void Add(Sefer expedition)
        {
            _seferDal.Add(expedition);
        }

        public void Delete(Sefer expedition)
        {
            _seferDal.Delete(expedition);
        }

        public List<Sefer> GetAll()
        {
            return _seferDal.GetAll();
        }

        public Sefer GetById(int id)
        {
            return _seferDal.Get(a => a.SeferId == id);
        }

        public string GetNereden(string nereden)
        {
            return _seferDal.GetNereden(nereden);
        }

        public string GetNereye(string nereye)
        {
            return _seferDal.GetNereye(nereye);
        }

        public int GetSeferByBslBts(string basla, string bitis)
        {
            return _seferDal.GetSeferByBslBts(basla, bitis);
        }

        public Sefer GetSeferDetails(int id)
        {
            return _seferDal.GetSeferDetails(id);
        }
        public List<Sefer> GetYolculuk(string nereden, string nereye)
        {
            return _seferDal.GetYolculuk(nereden, nereye);
        }

        public void Update(Sefer sefer)
        {
            _seferDal.Update(sefer);
        }

    }
}
