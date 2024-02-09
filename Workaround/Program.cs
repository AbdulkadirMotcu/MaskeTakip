

//Vatandas vatandas1 = new Vatandas();
//vatandas1.Ad = "Kadir";
//vatandas1.Soyad = "Motcu";
//vatandas1.DogumYili = 2001;
//vatandas1.TcNo = 10822281464;


SelamVer("Kadir");
SelamVer();

int sonuc = Topla(3,5);

Console.WriteLine(sonuc);



static int Topla(int sayi1,int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}



static void SelamVer(string isim = "Kullanıcı")
{
    Console.WriteLine("Merhaba" + " " + isim);
}





//pascal casing 
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set;}
    public long TcNo { get; set; }

}