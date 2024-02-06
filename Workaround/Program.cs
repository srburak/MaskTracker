
//string mesaj = "Merhaba";
//double tutar = 100000;
//int sayi = 100;
//bool girişYaptımı = false;

//Console.WriteLine(mesaj);
//Console.WriteLine(tutar*1.18);

using Business.Concrete;
using Entites.Concrete;

Vatandas vatandas = new();
SelamVer(isim: "Burak");
SelamVer(isim: "Engin");
SelamVer();

static void SelamVer(string isim="noname")
{
    Console.WriteLine("Merhaba " + isim);
}

Console.WriteLine("......................................");

int sonuc = Topla(5, 4);
static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}

Console.WriteLine("......................................");
//Diziler - Arrays

string[] ogrenciler = new string[3];
ogrenciler[0] = "Burak";
ogrenciler[1] = "Engin";
ogrenciler[2] = "Kadir";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

Console.WriteLine("......................................");

// Referans Tipler
string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] {"Bursa" , "Diayrbakır" , "Muğla"};
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

//Değer Tip
//int sayi1 = 10;
//int sayi2 = 20;
//sayi2 = sayi1;
//sayi1 = 30;
//Console.WriteLine(sayi2);

Console.WriteLine("......................................");

foreach(string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

Console.WriteLine("......................................");

List<string> yenisehirler1 = new List<string> { "Samsun", "Konya", "Antalya" };
yenisehirler1.Add("Adana");
foreach(var ysehir in yenisehirler1)
{
    Console.WriteLine(ysehir);
}


Console.WriteLine("......................................");

Person person = new Person();
person.FirstName = "BURAK";
person.LastName = "KAYMAZ";
person.DateOfBirthYear = 2001;
person.NationalIdentitiy = 123;

PttManager pttManager = new PttManager(new PersonManeger());
pttManager.GiveMask(person);

Console.ReadLine();
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int dogumYili { get; set; }
    public long TcNo { get; set; }
}