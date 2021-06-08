using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new TicketSystemDBContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Seferler.Count() == 0)
                {
                    context.Seferler.AddRange(Seferler);
                }


                if (context.Biletler.Count() == 0)
                {
                    context.Biletler.AddRange(Bilets);

                }
                if (context.Sehirler.Count() == 0)
                {
                    context.Sehirler.AddRange(Sehirs);

                }

                context.SaveChanges();
            }
        }

        private static Sefer[] Seferler =
        {
            new Sefer(){ KalkisSehir="İstanbul", VarisSehir="Isparta", SeferTarihi="15.05.2021", KalkisZamani="18.00", SeferUcreti=110},
            new Sefer(){ KalkisSehir="Rize", VarisSehir="İstanbul", SeferTarihi="16.05.2021", KalkisZamani="19.00", SeferUcreti=180},
            };

        private static Bilet[] Bilets =
        {
            new Bilet(){ Ad="Emirhan", Soyad="Taşçı", Mail="emirhantasci@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=11, Fiyat=110, SeferId=1},
            new Bilet(){ Ad="Can", Soyad="Yumak", Mail="canyumak@outlook.com", Nereden="Kocaeli", Nereye="Isparta", KoltukNo=10, Fiyat=100, SeferId=1},
            new Bilet(){ Ad="Hale", Soyad="Opak", Mail="haleopak@outlook.com", Nereden="Kütahya", Nereye="Isparta", KoltukNo=8, Fiyat=80, SeferId=1},
            new Bilet(){ Ad="Aylin", Soyad="Kone", Mail="aylinkone@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=4, Fiyat=110, SeferId=1},
            new Bilet(){ Ad="Murat", Soyad="Porut", Mail="muratporut@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=20, Fiyat=110, SeferId=1},
            new Bilet(){ Ad="Mehmet", Soyad="Oguz", Mail="mehmetoguz@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=19, Fiyat=110, SeferId=1},
            new Bilet(){ Ad="Yusuf", Soyad="Süy", Mail="yusufyus@outlook.com", Nereden="Rize", Nereye="İstanbul", KoltukNo=15, Fiyat=180, SeferId=2},
            new Bilet(){ Ad="Sena", Soyad="Çor", Mail="senacor@outlook.com", Nereden="Ordu", Nereye="Samsun", KoltukNo=11, Fiyat=60, SeferId=2},
            new Bilet(){ Ad="Ahmet", Soyad="Can", Mail="ahmetcan@outlook.com", Nereden="Kocaeli", Nereye="İstanbul", KoltukNo=8, Fiyat=50, SeferId=2}

        };
        private static Sehir[] Sehirs =
        {
            new Sehir(){ SehirAdi= "İstanbul"},
            new Sehir(){ SehirAdi= "Kocaeli"},
            new Sehir(){ SehirAdi= "Kütahya"},
            new Sehir(){ SehirAdi= "Afyon"},
            new Sehir(){ SehirAdi= "Isparta"},

            new Sehir(){ SehirAdi= "Samsun"},
            new Sehir(){ SehirAdi= "Ordu"},
            new Sehir(){ SehirAdi= "Rize"}
        };

    }
}

