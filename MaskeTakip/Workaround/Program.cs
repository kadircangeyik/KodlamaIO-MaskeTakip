
using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        Vatandas vatandas1 = new Vatandas();

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Kadir";
        ogrenciler[1] = "Ahmet";
        ogrenciler[2] = "Buse";

        ogrenciler = new string[4];
        ogrenciler[3] = "Melisa";


        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = { "Bursa", "Adıyaman", "Karaman" };
        string[] sehirler2 = { "Hatay", "Antalya", "Diyarbakır" };
        sehirler2 = sehirler1;
        sehirler1[0] = "Çanakkale";
        Console.WriteLine(sehirler2[0]);

        Console.WriteLine();
        foreach (string s in sehirler2)
        {
            Console.WriteLine(s);
        }

        List<string> yeniSehirler = new List<string> { "Ankara 1", "İstanbul 1", "izmir 1" };
        yeniSehirler.Add("Adana 1");

        foreach (string yenisehir in yeniSehirler)
        {
            Console.WriteLine(yenisehir);
        }
        int sonuc = Topla(5, 10);
        Console.WriteLine(sonuc);
        SelamVer("Burak");
        SelamVer();
        Degiskenler();
        Person person1 = new Person();
        person1.FirstName = "Hasan";
        person1.LastName = "Tekin";
        person1.NationalIdentity = 1234;
        person1.DateOfBirthYear = 1995;
        PttManager pttmanager = new PttManager(new PersonManager());
        pttmanager.GİveMask(person1);
        Console.ReadLine();


    }
    static void SelamVer(string isim = "Nedim")
    {
        Console.WriteLine("Hello " + isim);
    }
    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    private static void Degiskenler()
    {
        string mesaj = "Hello";
        double tutar = 10000;
        int sayi = 11;
        bool girisYapmisMi = false;

        string ad = "Hasan";
        string soyad = "Tekin";
        int dogumYili = 2003;
        long tcNo = 12345678910;
    }

    public class Vatandas
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int dogumYili { get; set; }
        public long tcNo { get; set; }
    }
}