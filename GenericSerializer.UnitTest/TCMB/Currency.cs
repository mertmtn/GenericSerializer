using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.TCMB
{
    [XmlType("Currency")]
    public class Currency
    {
        [XmlElement(ElementName = "Unit")]
        public string Unit { get; set; }
        [XmlElement(ElementName = "Isim")]
        public string Isim { get; set; }
        [XmlElement(ElementName = "CurrencyName")]
        public string CurrencyName { get; set; }
        [XmlElement(ElementName = "ForexBuying")]
        public string ForexBuying { get; set; }
        [XmlElement(ElementName = "ForexSelling")]
        public string ForexSelling { get; set; }
        [XmlElement(ElementName = "BanknoteBuying")]
        public string BanknoteBuying { get; set; }
        [XmlElement(ElementName = "BanknoteSelling")]
        public string BanknoteSelling { get; set; }
        [XmlElement(ElementName = "CrossRateUSD")]
        public string CrossRateUSD { get; set; }
        [XmlElement(ElementName = "CrossRateOther")]
        public string CrossRateOther { get; set; }
        [XmlAttribute(AttributeName = "CrossOrder")]
        public string CrossOrder { get; set; }
        [XmlAttribute(AttributeName = "Kod")]
        public string Kod { get; set; }
        [XmlAttribute(AttributeName = "CurrencyCode")]
        public string CurrencyCode { get; set; }
    }
}
