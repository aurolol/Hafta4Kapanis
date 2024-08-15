using Hafta4Kapanis;

class Program
{
    public static void Main(string[] args)
    {
        bool devamMi = true;
        while (devamMi)
        {

         baslangic: Console.WriteLine("Merhabalar. Telefon için '1' Bilgisayar için '2' yazınız.");
            int tercih = Convert.ToInt32(Console.ReadLine());
            if (tercih == 1)
            {

                Telefon telefon = new Telefon();

                Console.Write("Telefonun Seri Numarası nedir?");
                telefon.SeriNumarasi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Telefonun Adı nedir?");
                telefon.Ad = Console.ReadLine();

                Console.Write("Telefonun Açıklaması nedir?");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("Telefonun İşletim Sistemi nedir?");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("Telefonun Tr Lisansı var mı ?");
                telefon.TrLisansliMi = Convert.ToBoolean(Console.ReadLine());
                
                Console.WriteLine("Telefonunuz başarıyla oluşturuldu!");
                telefon.BilgileriYazdir();

            }
            else if (tercih == 2)
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Bilgisayarın Seri Numarası nedir?");
                bilgisayar.SeriNumarasi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bilgisayarın Adı nedir?");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Bilgisayarın Açıklaması nedir?");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("Bilgisayarın İşletim Sistemi nedir?");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("Bilgisayarın Kaç Usb Girişi var?");
                bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bilgisayarın bluetooth'u var mı?");
                bilgisayar.BluetoothVarMi = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Bilgisayarınız başarıyla oluşturuldu!");
                bilgisayar.BilgileriYazdir();

            }
            else
            {
                Console.WriteLine("Yanlış bir tercih yaptınız.");
                goto baslangic;
            }

            baslangic2: Console.WriteLine("Başka bir ürün oluşturmak istiyor musunuz? " +
                              "\nİstiyorsanız 'Evet' istemiyorsanız 'Hayır' yazınız.");
            string secim = Console.ReadLine().ToLower();
            if (secim == "evet")
            {

            }
            else if (secim == "hayır")
            {
                Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz ve iyi günler dileriz.");
                devamMi = false;
            }
            else
            {
                Console.WriteLine("Hatalı tercih yaptınız.");
                goto baslangic2;
            }

        }
    }
}
