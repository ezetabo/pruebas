using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace ControlArchivos
{
    public class Serializador<T> : IArchivos<T>
        where T : class
    {
        private ETipoExtenxion extenxion;

        public Serializador(ETipoExtenxion extenxion)
        {
            this.extenxion = extenxion;
        }

        public bool Escribir(string path, T dato)
        {
            bool ok = false;
            try
            {                
                if (this.extenxion == ETipoExtenxion.Json)
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Archivo archivo = new Archivo();
                        JsonSerializerOptions opciones = new JsonSerializerOptions();
                        opciones.WriteIndented = true;
                        archivo.Escribir(path,JsonSerializer.Serialize(dato, typeof(T), opciones));
                        ok = true;
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("La extension no es Json");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializar = new XmlSerializer(typeof(T));
                            xmlSerializar.Serialize(xmlTextWriter, dato);
                            ok = true;
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("La extension no es Xml");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ok;
        }

        public T Leer(string path)
        {
            try
            {
                if (this.extenxion == ETipoExtenxion.Json)
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Archivo archivo = new Archivo();
                        T objeto = JsonSerializer.Deserialize<T>(archivo.Leer(path));
                        return objeto;
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("La extension no es Json");
                    }
                }
                else
                {

                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmliTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            T objeto = xmlSerializer.Deserialize(xmliTextReader) as T;
                            return objeto;
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("La extension no es Xml");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }  
        
    }
}
