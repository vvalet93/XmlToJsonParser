using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlToJsonParser.Models
{
    public class LayersModel : BaseLayerInfo
    {
        [JsonProperty(PropertyName = "sublayers", Order = 3)]
        [XmlElement("Layer")]
        public List<SublayersModel> Sublayers { get; set; }
    }
}
