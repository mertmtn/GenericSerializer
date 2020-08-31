using GenericSerializer.DataFormat;
using GenericSerializer.Models;
using GenericSerializer.Models.Enums;
using GenericSerializer.UnitTest.Documents;
using GenericSerializer.UnitTest.ETicaret;
using GenericSerializer.UnitTest.OgrenciIsleri;
using GenericSerializer.UnitTest.OnlineSiparis;
using GenericSerializer.UnitTest.Sinema;
using GenericSerializer.UnitTest.TCMB;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GenericSerializer.UnitTest
{
    public class Tests
    {
        #region XML Tests
        [Test]
        public void XML_Deserialize_From_XmlString()
        {
            string testData = @"<TaskList>
                        <Task>
                            <TaskAdi>Name1</TaskAdi>
                            <Desc>Desc1</Desc>
                        </Task>
                        <Task>
                            <TaskAdi>Name2</TaskAdi>
                            <Desc>Desc2</Desc>
                        </Task>
                    </TaskList>";

            var xmlSerializer = GenericSerializer<ToDoList.ToDoList>.CreateSerializerObject(DataFormatType.XML);
            var task1 = xmlSerializer.DeserializeFromString(testData);

            Assert.AreEqual("Name1", task1.TaskList.FirstOrDefault().TaskAdi);
        }

        [Test]
        public void XML_Serialize_FromObject_ToFile()
        {
            var xmlSerializer = GenericSerializer<Siparis>.CreateSerializerObject(DataFormatType.XML);

            var siparis = new Siparis();
            var adres = new Adres();
            var odeme = new Odeme();
            var urunler = new List<OnlineSiparis.Urun>();
            var ToplamUrunFiyat = 0;

            urunler.Add(new OnlineSiparis.Urun
            {
                UrunIsmi = "Pizza",
                Aciklama = "Orta Boy",
                Adet = 2,
                BirimFiyat = 15
            });

            urunler.Add(new OnlineSiparis.Urun
            {
                UrunIsmi = "Hamburger",
                Aciklama = "Buyuk Boy Patates",
                Adet = 3,
                BirimFiyat = 6
            });

            foreach (var urun in urunler)
            {
                urun.Hesapla();
                ToplamUrunFiyat += urun.AraToplam;
            }

            adres.Baslik = "Ev Adresim";
            adres.Satir1 = "Kodla Sokak, Objeler Caddesi";
            adres.Sehir = "Istanbul";
            adres.KapiNumarasi = "10";

            odeme.OdemeTuru = "Nakit";
            odeme.OdemeYeri = "Kapida";

            siparis.Adres = adres;
            siparis.Odeme = odeme;
            siparis.Urunler = urunler;
            siparis.SiparisTarih = DateTime.Now.ToString("MMMM dd, yyyy");

            siparis.AraToplam = ToplamUrunFiyat;
            siparis.EkUcret = 5;
            siparis.Hesapla();

            xmlSerializer.SerializeToFile(siparis, @"D:\Siparis.xml");
            Assert.IsTrue(File.Exists(@"D:\Siparis.xml"));

        }
        [Test]
        public void XML_Serialize_FromObject_ToString()
        {
            var xmlSerializer = GenericSerializer<Siparis>.CreateSerializerObject(DataFormatType.XML);

            var siparis = new Siparis();
            var adres = new Adres();
            var odeme = new Odeme();
            var urunler = new List<OnlineSiparis.Urun>();
            var ToplamUrunFiyat = 0;

            urunler.Add(new OnlineSiparis.Urun
            {
                UrunIsmi = "Pizza",
                Aciklama = "Orta Boy",
                Adet = 2,
                BirimFiyat = 15
            });

            urunler.Add(new OnlineSiparis.Urun
            {
                UrunIsmi = "Hamburger",
                Aciklama = "Buyuk Boy Patates",
                Adet = 3,
                BirimFiyat = 6
            });

            foreach (var urun in urunler)
            {
                urun.Hesapla();
                ToplamUrunFiyat += urun.AraToplam;
            }

            adres.Baslik = "Ev Adresim";
            adres.Satir1 = "Kodla Sokak, Objeler Caddesi";
            adres.Sehir = "Istanbul";
            adres.KapiNumarasi = "10";

            odeme.OdemeTuru = "Nakit";
            odeme.OdemeYeri = "Kapida";

            siparis.Adres = adres;
            siparis.Odeme = odeme;
            siparis.Urunler = urunler;
            siparis.SiparisTarih = DateTime.Now.ToString("MMMM dd, yyyy");

            siparis.AraToplam = ToplamUrunFiyat;
            siparis.EkUcret = 5;
            siparis.Hesapla();

            var xmlString = xmlSerializer.SerializeToString(siparis);

            Assert.IsNotNull(xmlString);

        }

        [Test]
        public void XML_Deserialize_ToObject_FromURL()
        {
            var xmlSerializer = GenericSerializer<Urunler>.CreateSerializerObject(DataFormatType.XML);

            var urunler = xmlSerializer.DeserializeFromLink("https://www.korayspor.com/grisport.xml");
            Assert.IsTrue(urunler.Urun.Count > 0);
        }

        [Test]
        public void XML_Deserialize_ToObject_FromFile()
        {
            var xmlSerializer = GenericSerializer<OnlineSiparis.Urun>.CreateSerializerObject(DataFormatType.XML);

            var siparis = xmlSerializer.DeserializeFromFile(@"D:\Siparis.xml");
            Assert.IsNotNull(siparis.Aciklama);
        }

        [Test]
        public void XML_Deserialize_ToObject_FromURL_WithRootAttirbuteName()
        {
            var xmlSerializerTCMB = GenericSerializer<Tarih_Date>.CreateSerializerObject(DataFormatType.XML) as XmlGenericSerializer<Tarih_Date>;

            var kur = xmlSerializerTCMB.DeserializeFromLink("https://www.tcmb.gov.tr/kurlar/today.xml", "Tarih_Date");

            Assert.IsTrue(kur.Currency.Count > 0);
        }
        #endregion

        #region JSON Tests

        [Test]
        public void JSON_Serialize_ToFile_FromObject()
        {
            var jsonSerializer = GenericSerializer<Film>.CreateSerializerObject(DataFormatType.JSON);

            var filmOne = new Film
            {
                FilmAdi = "Bad Boys",
                FilmYil = 1995,
                FilmKategori = "Macera"
            };
            jsonSerializer.SerializeToFile(filmOne, @"D:\movie.json");

            Assert.IsTrue(File.Exists(@"D:\movie.json"));
        }

        [Test]
        public void JSON_Serialize_ToObject_FromFile()
        {
            var jsonSerializer = GenericSerializer<Film>.CreateSerializerObject(DataFormatType.JSON);

            var film = jsonSerializer.DeserializeFromFile(@"D:\movie.json");

            Assert.IsNotNull(film.FilmAdi);
        }

        [Test]
        public void JSON_Deserialize_ToObject_FromURL()
        {
            var jsonSerializer = GenericSerializer<Document>.CreateSerializerObject(DataFormatType.JSON);

            var document = jsonSerializer.DeserializeFromLink("http://api.plos.org/search?q=title:%22Drosophila%22%20and%20body:%22RNA%22&fl=id,abstract&wt=json&indent=on");

            Assert.IsNotNull(document.Response.NumFound);
        }

        [Test]
        public void JSON_Serialize_ToString_FromObject()
        {
            var jsonSerializer = GenericSerializer<Ogrenci>.CreateSerializerObject(DataFormatType.JSON);

            var yeniOgrenci = new Ogrenci
            {
                Ad = "Mert",
                Soyad = "Metin",
                No = 200,
                Ortalama = 95
            };
            var jsonString = jsonSerializer.SerializeToString(yeniOgrenci);

            Assert.IsNotNull(jsonString);
        }

        [Test]
        public void JSON_Deserialize_ToObject_FromString()
        {
            var jsonSerializer = GenericSerializer<Ogrenci>.CreateSerializerObject(DataFormatType.JSON);

            var yeniOgrenci = new Ogrenci
            {
                Ad = "Mert",
                Soyad = "Metin",
                No = 200,
                Ortalama = 95
            };
            var jsonString = jsonSerializer.SerializeToString(yeniOgrenci);
            var ogrenci = jsonSerializer.DeserializeFromString(jsonString);

            Assert.IsNotNull(ogrenci.Ad);
        }
        #endregion

    }
}