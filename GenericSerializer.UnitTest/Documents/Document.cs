using Newtonsoft.Json;

namespace GenericSerializer.UnitTest.Documents
{
    public class Document
    {
        [JsonProperty("response")]
        public Response Response { get; set; }
    }
}
