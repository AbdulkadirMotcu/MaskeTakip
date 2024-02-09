Degiskenler();


Vatandas vatandas1 = new Vatandas();
vatandas1.Ad = "Kadir";
vatandas1.Soyad = "Motcu";
vatandas1.DogumYili = 2001;
vatandas1.TcNo = 10822281464;





static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000;
    int sayi = 0;
    bool girisYapmismi = false;



    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);
}

//pascal casing 
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set;}
    public long TcNo { get; set; }

}