using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISeferService
    {
        public void Add(Sefer expedition);
        public void Update(Sefer exception);
        public void Delete(Sefer expedition);
        List<Sefer> GetAll();
        Sefer GetById(int id);
        string GetNereden(string nereden);
        string GetNereye(string nereye);
        List<Sefer> GetYolculuk(string nereden, string nereye);
        int GetSeferByBslBts(string basla, string bitis);
        Sefer GetSeferDetails(int id);

    }
}
