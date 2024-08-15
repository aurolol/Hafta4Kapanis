using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis
{
    internal class Bilgisayar : BaseMakine
    {
        int _usbGirisSayisi;
        public int UsbGirisSayisi
        {
            get
            {
                return _usbGirisSayisi;
            }
            set
            {
                if (value == 2 || value == 4)
                    _usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Usb giriş sayısı hatalı.");
                    _usbGirisSayisi = -1;
                }
                   
            }
        }
        public bool BluetoothVarMi { get; set; }


        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Usb Giriş Sayısı-> {UsbGirisSayisi}");
            Console.WriteLine(BluetoothVarMi ? "Bluetooth Var." : "Bluetooth Yok.");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarın Adı -> {Ad}");
        }
    }
    
}
    

