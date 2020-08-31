using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.OnlineSiparis
{
    public class Adres
    {
        [XmlAttribute("Isim")]
        public string Baslik { get; set; }
        [XmlElement("KapiNo")]
        public string KapiNumarasi { get; set; }
        public string Satir1 { get; set; }
        public string Sehir { get; set; }

    }
}
