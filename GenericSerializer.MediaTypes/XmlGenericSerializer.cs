using GenericSerializer.Base; 
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace GenericSerializer.DataFormat
{

    public class XmlGenericSerializer<T> : IGenericSerializer<T>
    {
        public T DeserializeFromFile(string fileName)
        {
            var xml = new XmlSerializer(typeof(T));
            using StreamReader sr = new StreamReader(fileName);
            return (T)xml.Deserialize(sr);
        }

        public T DeserializeFromLink(string link)
        {
            var xmlSerialize = new XmlSerializer(typeof(T));
            var client = new WebClient();

            var data = Encoding.Default.GetString(client.DownloadData(link));
            var reader = new MemoryStream(Encoding.Default.GetBytes(data));

            var xmlResult = (T)xmlSerialize.Deserialize(reader);

            return (xmlResult != null) ? xmlResult : default;
        }

        public T DeserializeFromString(string xmlString)
        {
            var serializer = new XmlSerializer(typeof(T));
            using TextReader reader = new StringReader(xmlString);
            return (T)serializer.Deserialize(reader);
        }

        public void SerializeToFile(T objectData, string fileName)
        {
            var xml = new XmlSerializer(typeof(T));
            using StreamWriter sw = new StreamWriter(fileName);
            xml.Serialize(sw, objectData);
        }

        public string SerializeToString(T objectData)
        {
            var xml = new XmlSerializer(typeof(T));
            var stringWriter = new StringWriter();
            xml.Serialize(stringWriter, objectData);
            return stringWriter.ToString();
        }

        public T DeserializeFromLink(string link, string xmlRootAttributeName)
        {
            var xmlSerialize = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttributeName));

            var client = new WebClient();

            var data = Encoding.Default.GetString(client.DownloadData(link));

            var reader = new MemoryStream(Encoding.Default.GetBytes(data));

            var xmlResult = (T)xmlSerialize.Deserialize(reader);

            return (xmlResult != null) ? xmlResult : default;
        }
    }
}
