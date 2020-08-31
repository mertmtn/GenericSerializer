using System; 
using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.ETicaret
{
    [XmlRoot(ElementName = "Kategori")]
    public class Kategori
    {
        [XmlAttribute(AttributeName = "no")]
        public string No { get; set; }

        [XmlText]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        public string DownloadedFile { get; set; }
    }
}
