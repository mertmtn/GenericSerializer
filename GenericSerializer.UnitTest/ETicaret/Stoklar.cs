using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.ETicaret
{
    [XmlRoot(ElementName = "Stoklar")]
    public class Stoklar
    {
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "Barkod")]
        public string Barkod { get; set; }

        [XmlElement(ElementName = "Ozellik")]
        public string Ozellik { get; set; }

        public string UrunID { get; set; }

        public DateTime CreatedDate { get; set; }

        public string DownloadedFile { get; set; }
    }
}
