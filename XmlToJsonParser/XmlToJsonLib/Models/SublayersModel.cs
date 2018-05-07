using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlToJsonParser.Models
{
    public class SublayersModel : BaseLayerInfo
    {
        [JsonProperty(PropertyName = "attributes", Order = 3)]
        [XmlArrayItem("Attribute")]
        public List<LayerAttributes> Attributes { get; set; }
    }
}
