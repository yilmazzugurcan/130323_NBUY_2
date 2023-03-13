using System;

namespace _130323_NBUY_2
{
    internal class Program
    {


        #region GİRİLMEYEN VERİLERİ NULL YAZDIRMA, CONSCRUCTOR METOD
        static void Main(string[] args)
        {

            Programci a = new Programci("Haşmet");
            Programci b = new Programci("ziya", "alp");
            Programci c = new Programci("kamuran", "kamiloğlu", 23);
            Programci d = new Programci(30, "hayrettin", "kütükçü", "c#");

            a.Ozellik_Yazdir(); Console.WriteLine("\n");
            b.Ozellik_Yazdir(); Console.WriteLine("\n");
            c.Ozellik_Yazdir(); Console.WriteLine("\n");
            d.Ozellik_Yazdir();


            Console.Read();

        }

        public class Programci
        {
            string adi, soyadi, kullanilan_dil;
            int yasi;

            public Programci(string ad)
            {
                this.adi = ad;
                this.soyadi = null;
                this.yasi = 0;
                this.kullanilan_dil = null;

            }

            public Programci(string ad, string soyad)
            {
                this.adi = ad;
                this.yasi = 0;
                this.soyadi = soyad;
                this.kullanilan_dil = null;

            }

            public Programci(string ad, string soyad, int yas)
            {
                this.yasi = yas;
                this.adi = ad;
                this.soyadi = soyad;
                this.kullanilan_dil = null;

            }

            public Programci(int yas, string ad, string soyad, string kullanilan_dil)
            {
                this.yasi = yas;
                this.adi = ad;
                this.soyadi = soyad;
                this.kullanilan_dil = kullanilan_dil;

            }

            public void Ozellik_Yazdir()
            {
                if (this.adi != null)
                {
                    Console.WriteLine("Adı: " + this.adi);

                }
                else Console.WriteLine("ad bilgisi elimizde yoktur.");




                if (this.soyadi != null)
                {
                    Console.WriteLine("Soyadı: " + this.soyadi);
                }
                else Console.WriteLine("Soyad bilgisi elimizde yoktur.");



                if (this.yasi != 0)
                {
                    Console.WriteLine("Yaşı: " + this.yasi);
                }
                else Console.WriteLine("Yaş bilgisi elimizde yoktur.");




                if (this.kullanilan_dil != null)
                {
                    Console.WriteLine("Kullanılan Dil: " + this.kullanilan_dil);
                }
                else Console.WriteLine("Kullanılan Dil bilgisi elimizde yoktur.");

            }
        }

    }
}

#endregion


        #region Yıkıcı Metod ve örnek çözümü
//
//Personel p;//stackte p değşken oluşur fakat heap alanında oluşmaığı için p null olarak atanır.
//p.Ad = "Jale";
//----------------
//    p=new Personel();// heapte tanımlanır ve referans numarasını alır


/* constructor metou  yapıcı metot
 * nesnenn rame  retlmesn sağlayan metot
 * constructor metou tanımlanmazsa varsayılan(efault) constructor geçerlr.
 * Constructor metotlarının overloaı arır.
 * kendimiz sınıf içerisinde constructor metou yazablrz ,
 * gerye önş tp ğlmayan tek metour
 * kenmz constructor tanımlarsak varsayılan constructor ptal olur
 * sınıf çne mzaları farklı bren fazla constructor olabşlr

 */

Personel p = new Personel();
//Br sınıftan örnek retme nstance  enr
Console.WriteLine(p.isegirisTarih);

Console.ReadLine();



///Object Initializer
Personel p2 = new Personel { Ad = "Aem", City = "ankara" };

Personel p9 = new Personel { City = "kayseri", Region = "İç anadolu" };
Personel p8 = new Personel { Ad = "Meliha" };




//----------------------------------------------------------------------------------------
//----------------------Programcı Çıktısı-------------------------------------------------


Programci a = new Programci();
Programci b = new Programci(23, "Ziya");
Programci c = new Programci(27, "Kamuran", "Kamiloğlu");
Programci d = new Programci(30, "Hayrettin", "Kütükçü", "C#");

a = null;
//a.showOzellikler();
b.showOzellikler();
c.showOzellikler();
d.showOzellikler();

Console.ReadLine();



//--------------------------Başka -------------------------------
//--------------------------Örnek--------------------------------

//Önce değişkenlerimi tanımlıyorum
string _ad, _soyad, _dogumYil, _dogumYeri, _meslek;
//Kullanıcıdan verileri girmesini istiyorum ve her bir veriyi ilgili değişkenime atama işlemi yapıyorum
Console.WriteLine("Adınızı giriniz: ");
_ad = Console.ReadLine();
Console.WriteLine("Soyadınızı giriniz: ");
_soyad = Console.ReadLine();
Console.WriteLine("Doğum yılınızı giriniz: ");
_dogumYil = Console.ReadLine();
Console.WriteLine("Doğum yerinizi giriniz: ");
_dogumYeri = Console.ReadLine();
Console.WriteLine("Mesleğinizi giriniz: ");
_meslek = Console.ReadLine();

//Personel classından nesne oluşturuyorum ve ilgili parametrelerini belirtiyorum.
Personel prsnl = new Personel(_ad, _soyad, _dogumYil, _dogumYeri, _meslek);




        }
    }

    class Programci
{
    int yasi;
    string adi;
    string soyadi;
    string kullandigiDil;

    // Hic parametre almayan bir yapılandırıcı..
    public Programci()
    {
        this.adi = null;
        this.yasi = 0;
        this.soyadi = null;
        this.kullandigiDil = null;
    }

    // İsmini ve yasini alan bir yapılandırıcı..
    public Programci(int yasi, string adi)
    {
        this.adi = adi;
        this.yasi = yasi;

        this.soyadi = null;
        this.kullandigiDil = null;
    }

    // İsmini, soyismini ve yasini alan bir yapılandırıcı..
    public Programci(int yasi, string adi, string soyadi)
    {
        this.adi = adi;
        this.yasi = yasi;
        this.soyadi = soyadi;
        this.kullandigiDil = null;
    }

    // İsmini, soyismini kullandığı dili ve yasini alan bir yapılandırıcı..
    public Programci(int yasi, string adi, string soyadi, string kullandigiDil)
    {
        this.adi = adi;
        this.yasi = yasi;
        this.soyadi = soyadi;
        this.kullandigiDil = kullandigiDil;
    }

    ~Programci()//yıkıcı metot ~ işareti ile ve sınıfımızın adiyla herhan erişim belirleyici ve tür tanımlamasına gerk kalmasan tanımlanır
    {
        Console.WriteLine("Yıkıcı metot çalıştı");
        GC.Collect();
    }
    public void showOzellikler()
    {
        if (this.yasi != 0)
            Console.WriteLine("Yasi : " + this.yasi);
        else Console.WriteLine("Yasi bilgisi elimizde yok şu anda...");

        if (this.adi != null)
            Console.WriteLine("Adı : " + this.adi);
        else Console.WriteLine("Adi bilgisi elimizde yok şu anda...");

        if (this.soyadi != null)
            Console.WriteLine("Soyadı : " + this.soyadi);
        else Console.WriteLine("Soyadı bilgisi elimizde yok şu anda...");

        if (this.kullandigiDil != null)
            Console.WriteLine("Kullandığı Programlama dili : " + this.kullandigiDil);
        else Console.WriteLine("Hangi Dili kullanığını bilmiyoruz be... :-(\n");
    }

}
}

	#endregion