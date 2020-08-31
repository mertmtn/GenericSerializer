
using System.Collections.Generic;

using System.Xml.Serialization;

namespace GenericSerializer.UnitTest.ToDoList
{
    [XmlRoot("TaskList")]
    public class ToDoList
    {
        [XmlElement("Task")]
        public List<Task> TaskList { get; set; }
    }
}
