using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlArchivos
{
    public enum ETipoExtenxion
    {
        Json,
        Xml        
    }
    public interface IArchivos<T>
        where T : class       
    {
       
        bool Escribir(string ruta, T dato);

        T Leer(string ruta);
    }
    
}
