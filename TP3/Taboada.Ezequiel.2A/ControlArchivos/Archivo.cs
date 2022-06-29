using System;
using System.IO;

namespace ControlArchivos
{
    public class Archivo : IArchivos<string>
    {
        public bool Escribir(string ruta, string dato)
        {
            bool ok = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(dato);
                    ok = true;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            return ok;
        }
       
        public string Leer(string ruta)
        {
            string rtn = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {

                    while (!sr.EndOfStream)
                    {
                        rtn += sr.ReadLine() + "\n";
                    }
                }
                return rtn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string ObtenerRuta(string nombreArchivo)
        {
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaCompleta = Path.Combine(rutaBase, nombreArchivo);
            return rutaCompleta;
        }

    }
}
