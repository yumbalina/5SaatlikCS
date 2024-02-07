// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

//static void degiskenler()
//{
//    string mesaj = "Merhaba!";
//    double tutar = 100000; //dbden gelir
//    int sayi = 100;
//    bool girisYapmisMi = false;

//    string ad = "Engin";
//    string soyad = "Demiroğ";
//    int dogumYili = 1985;
//    long tcNo = 11111111111;

//    //Projeye Bagli
//    Console.WriteLine(tutar * 1.18);
//}
//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }
//}

//degiskenler();
//Vatandas vatandas1 = new Vatandas();

static void SelamVer() 
{
    Console.WriteLine("Merhaba!");
}
SelamVer();
static int Topla()
{
    return 5;
}
int sonuc = Topla();

static void SelamVer2(string isim = "Cem")
{
    Console.WriteLine("Merhaba " + isim);
}
SelamVer2();