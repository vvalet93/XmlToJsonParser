using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlToJsonParser.Models
{
    public class Capability
    {
        [JsonProperty(PropertyName = "layer")]
        [XmlElement("Layer")]
        public List<LayersModel> Layers { get; set; }
    }
}
