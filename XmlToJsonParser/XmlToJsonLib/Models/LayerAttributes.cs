using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmlToJsonParser.Models
{
    public class LayerAttributes
    {
        [JsonProperty(PropertyName = "name")]
        [XmlAttribute("name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
