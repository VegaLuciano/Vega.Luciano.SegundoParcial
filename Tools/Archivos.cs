using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Collections;
using Entidades;

namespace Tools
{
    public static class Archivo
    {
        public static List<T>? LeerArchivoJson<T>(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();

                List<T>? lista = JsonConvert.DeserializeObject<List<T>>(json);

                return lista;
            }

        }

        public static void GuardarArchivoJson<T>(string path, List<T> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }

        public static List<T>? LeerArchivoXML<T>(string path) 
        {
            using (XmlTextReader reader = new XmlTextReader(path))
            {
                XmlSerializer ser = new XmlSerializer((typeof(List<T>)));

                List<T>? lista = (List<T>?)ser.Deserialize(reader);

                return lista;
            }
        }

        public static void GuardarArchivoXml<T>(string path, List<T> lista) 
        {
            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer((typeof(List<T>)));

                ser.Serialize(writer, lista);
            }
        }

    }
}