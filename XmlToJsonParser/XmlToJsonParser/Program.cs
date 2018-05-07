using System;
using System.IO;
using System.Text;
using System.Xml;
using XmlToJsonLib;

namespace XmlToJsonParser
{
    class Program
    {
        static void Main(string[] args)
        {      
            var xdDoc = LoadDoc(args);
            if (xdDoc != null)
            {
                try
                {
                    var json = ParseToJson.Parse(xdDoc);
                    Console.WriteLine(json);
                    File.WriteAllText(args[1], json, Encoding.GetEncoding(65001)); // UTF-8
                    Console.WriteLine($"Результат записан в файл {args[1]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: Не удается создать файл!\n {ex} ");
                }
            }
        }

        private static XmlDocument LoadDoc(string[] sInpPath)
        {
            try
            {
                var xdDoc = new XmlDocument();
                xdDoc.Load(sInpPath[0]);
                return xdDoc;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"\nERROR:\n {ex}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"\nERROR:\n {ex}");
            }
            catch (Exception ex)    //other errors
            {
                Console.WriteLine($"\nERROR:\n {ex}");
            }

            return null;
        }
    }
}
