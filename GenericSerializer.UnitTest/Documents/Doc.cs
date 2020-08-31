using Newtonsoft.Json; 

namespace GenericSerializer.UnitTest.Documents
{
    public class Doc
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("abstract")]
        public string[] Abstract { get; set; }
    }
}
