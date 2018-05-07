using Newtonsoft.Json;

namespace XmlToJsonParser.Models
{
    public class BaseLayerInfo
    {
        [JsonProperty(PropertyName = "name", Order = 0)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "title", Order = 1)]
        public string Title { get; set; } = "";
    }
}
