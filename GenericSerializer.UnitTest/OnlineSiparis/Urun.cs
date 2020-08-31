using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.OnlineSiparis
{
    public class Urun
    {
        [XmlElement(ElementName = "Isim")]
        public string UrunIsmi { get; set; }
        public string Aciklama { get; set; }
        public int Adet { get; set; }
        public int BirimFiyat { get; set; }
        [XmlIgnore]
        public int AraToplam { get; set; }
        public void Hesapla()
        {
            AraToplam = BirimFiyat * Adet;
        }
    }
}
