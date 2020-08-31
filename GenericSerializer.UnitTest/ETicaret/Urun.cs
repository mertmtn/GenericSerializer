using System;
using System.Collections.Generic; 
using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.ETicaret
{
    [XmlRoot(ElementName = "urun")]
    public class Urun
    {
        [XmlElement(ElementName = "UrunID")]
        public string UrunID { get; set; }

        [XmlElement(ElementName = "UrunAdi")]
        public string UrunAdi { get; set; }

        [XmlElement(ElementName = "Kod")]
        public string Kod { get; set; }

        [XmlElement(ElementName = "Fiyat")]
        public string Fiyat { get; set; }

        [XmlElement(ElementName = "ListFiyat")]
        public string ListFiyat { get; set; }

        [XmlElement(ElementName = "KdvOran")]
        public string KdvOran { get; set; }

        [XmlElement(ElementName = "Marka")]
        public string Marka { get; set; }

        [XmlElement(ElementName = "Aciklama")]
        public string Aciklama { get; set; }

        [XmlElement(ElementName = "ImageName")]
        public string ImageName { get; set; }

        [XmlElement(ElementName = "Kategori")]
        public Kategori Kategori { get; set; }

        [XmlElement(ElementName = "Renk")]
        public string Renk { get; set; }

        [XmlElement(ElementName = "Stoklar")]
        public List<Stoklar> Stoklar { get; set; }

        public DateTime CreatedDate { get; set; }

        public string DownloadedFile { get; set; }
    }
}
