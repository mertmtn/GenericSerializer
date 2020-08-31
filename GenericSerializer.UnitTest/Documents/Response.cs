using Newtonsoft.Json;
namespace GenericSerializer.UnitTest.Documents
{
    public class Response
    {
        [JsonProperty("numFound")]
        public long NumFound { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("docs")]
        public Doc[] Docs { get; set; }
    }
}
