using Newtonsoft.Json;
using System;
using System.Xml;
using System.Xml.Serialization;
using XmlToJsonParser.Models;

namespace XmlToJsonLib
{
    public static class ParseToJson
    {
        public static string Parse(XmlDocument doc)
        {
            Capability capabilites;

            try
            {
                // Serialize xml to object
                var serializer = new XmlSerializer(typeof(Capability));
                using (XmlReader reader = new XmlNodeReader(doc))
                {
                    capabilites = (Capability)serializer.Deserialize(reader);
                }

                // Deserialize object to string
                var jsonString = JsonConvert.SerializeObject(capabilites.Layers, Newtonsoft.Json.Formatting.Indented);
                return jsonString;
            }
            catch (XmlException exception)
            {
                Console.WriteLine($"ERROR! Ошибка при сериализации XML документа в объект. {exception}");
                throw;
            }
            catch(JsonException exception)
            {
                Console.WriteLine($"ERROR! Ошибка при десериализации объекта в Json. {exception}");
                throw;
            }
        }
    }
}
