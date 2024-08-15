using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis
{
    internal class Telefon : BaseMakine
    {
        public bool TrLisansliMi { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine(TrLisansliMi ? "Tr Lisansı Var." : "Tr Lisansı yok.");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonun adı -> {Ad}");
        }
    }

    
}
