
using GenericSerializer.DataFormat;
using GenericSerializer.Models.Documents;
using GenericSerializer.Models.ETicaret;
using GenericSerializer.Models.OnlineSiparis;
using GenericSerializer.Models.Sinema;
using GenericSerializer.Models.TCMB;
using GenericSerializer.Models.ToDoList;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSerializer.ConsoleApp
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public double Ortalama { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creating an Employee object  
            var yeniOgrenci = new Ogrenci
            {
                Ad = "Yiğit",
                Soyad = "Nuhuz",
                No = 320,
                Ortalama = 50
            };

            ////var json = JsonSerializer.Serialize(yeniOgrenci);
            ////Console.WriteLine(json);
            //var jsonSerializer = new JsonGenericSerializer<Ogrenci>();
            //var stu = jsonSerializer.Deserialize(json);

            //Console.WriteLine($"Name: {stu.Ad}");
            //Console.ReadLine();
            //var xml = new XmlSerializer(typeof(Ogrenci));
            ////Ornek tipinde bir serileştirme yapacak nesnemizi oluşturuyorum.
            //using (StreamWriter sw = new StreamWriter(@"D:\OrnekXML.xml"))
            //{
            //    xml.Serialize(sw, yeniOgrenci);
            //    //Şuanki mevcut nesneyi(this) sw'nin tuttuğu dizine xml olarak serileştiriyoruz.
            //}
            //var xml = new XmlSerializer(typeof(Ogrenci));
            //using (StreamReader sr = new StreamReader(@"D:\OrnekXML.xml"))
            //{
            //    var stu =  (Ogrenci)xml.Deserialize(sr);
            //    //Verilen dizindeki xml deserialization yapılarak nihayetinde Ornek tipinde elde edilecektir.
            //    //object olarak gelen nesneyi biz Ornek tipine cast ediyoruz.
            //    Console.WriteLine($"Name: {stu.Ad}");
            //    //Gelen nesnenin verilerini şuandaki mevcut nesnenin veri alanlarına atamaktayız.
            //}

           
            ////var stu=xmlSerializer.DeserializeFromFile(@"D:\OrnekXML.xml");
           

            //var xmlSerializer = new XmlGenericSerializer<Siparis>();
            //var siparis = new Siparis();
            //var adres = new Adres();
            //var odeme = new Odeme();
            //var urunler = new List<Urun>();
            //var ToplamUrunFiyat = 0;

            //urunler.Add(new Urun
            //{
            //    UrunIsmi = "Pizza",
            //    Aciklama = "Orta Boy",
            //    Adet = 2,
            //    BirimFiyat = 15
            //});

            //urunler.Add(new Urun
            //{
            //    UrunIsmi = "Hamburger",
            //    Aciklama = "Buyuk Boy Patates",
            //    Adet = 3,
            //    BirimFiyat = 6
            //});

            //foreach (var urun in urunler)
            //{
            //    urun.Hesapla();
            //    ToplamUrunFiyat += urun.AraToplam;
            //}

            //adres.Baslik = "Ev Adresim";
            //adres.Satir1 = "Kodla Sokak, Objeler Caddesi";
            //adres.Sehir = "Istanbul";
            //adres.KapiNumarasi = "10";

            //odeme.OdemeTuru = "Nakit";
            //odeme.OdemeYeri = "Kapida";

            //siparis.Adres = adres;
            //siparis.Odeme = odeme;
            //siparis.Urunler = urunler;
            //siparis.SiparisTarih = DateTime.Now.ToString("MMMM dd, yyyy");

            //siparis.AraToplam = ToplamUrunFiyat;
            //siparis.EkUcret = 5;
            //siparis.Hesapla();

            ////xmlSerializer.SerializeToFile(siparis, @"D:\Siparis.xml");
            //var siparis=xmlSerializer.DeserializeFromFile(@"D:\Siparis.xml");
            //////Console.WriteLine($"Name: {siparis.Adres.Sehir}");

            //Console.WriteLine(xmlSerializer.SerializeToString(siparis, @"D:\Siparis.xml"));


 
            
            

          

            //var jsonSerializer = new JsonGenericSerializer<Film>();
            //Film filmOne = new Film
            //{
            //    FilmAdi = "Bad Boys",
            //    FilmYil = 1995,
            //    FilmKategori="Macera"
            //};
            //jsonSerializer.SerializeToFile(filmOne, @"D:\movie.json");

            //var film = jsonSerializer.DeserializeFromFile(@"D:\movie.json");

            //Console.WriteLine(film.FilmAdi);

 

            //var film = jsonSerializer.DeserializeFromFile(@"D:\movie.json");

           


        }
    }
}
