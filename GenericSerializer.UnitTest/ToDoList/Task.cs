using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.ToDoList
{
    public class Task
    {
        [XmlElement("TaskAdi")]
        public string TaskAdi { get; set; }
        [XmlElement("Tanim")]
        public string Tanim { get; set; }
    }
}