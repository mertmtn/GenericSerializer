using GenericSerializer.Base;
using Newtonsoft.Json;
using System.IO;
using System.Net; 

namespace GenericSerializer.DataFormat
{
    public class JsonGenericSerializer<T> : IGenericSerializer<T>
    {
        public T DeserializeFromFile(string fileName)
        {
            using (var file = File.OpenText(fileName))
            { 
                var serializer = new JsonSerializer();
                return (T)serializer.Deserialize(file, typeof(T));
            }
        }

        public T DeserializeFromLink(string link)
        {
            var client = new WebClient();
            var myJSON = client.DownloadString(link);
            return JsonConvert.DeserializeObject<T>(myJSON);
        }

        public T DeserializeFromString(string jsonString)
        {
            return  System.Text.Json.JsonSerializer.Deserialize<T>(jsonString);
        }

        public void SerializeToFile(T objectData, string fileName)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(objectData));

            using (var file = File.CreateText(fileName))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, objectData);
            }
        }

        public string SerializeToString(T objectData)
        {
            return JsonConvert.SerializeObject(objectData).ToString();
        }
    }
}
