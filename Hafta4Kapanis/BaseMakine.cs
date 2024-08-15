using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis
{
    public abstract class BaseMakine
    {
        protected BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }
        public DateTime UretimTarihi { get; set; }
        public int SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim tarihi -> {UretimTarihi} " +
                              $"\nSeri Numarası-> {SeriNumarasi} " +
                              $"\nAdı->{Ad} " +
                              $"\nAçıklaması-> {Aciklama}" +
                              $"\nİşletim Sistemi-> {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();
       

    }
}
