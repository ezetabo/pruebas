using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControlListas<T>
    {
        private List<T> lista;

        public List<T> Lista { get => lista; set => lista = value; }

        public ControlListas()
        {
            this.Lista = new List<T>();
        }

        public ControlListas(List<T> lista)
        {
            this.lista = lista;
        }

        public static bool operator ==(ControlListas<T> control, T elemento)
        {
            bool existe = false;
            foreach (T item in control.lista)
            {
                if (item.Equals(elemento))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public static bool operator !=(ControlListas<T> control, T elemento)
        {
            return !(control == elemento);
        }

        public static bool operator -(ControlListas<T> control, T elemento)
        {
            bool sePudo = false;
            if (control == elemento)
            {
                control.lista.Remove(elemento);
                sePudo = true;
            }
            return sePudo ;
        }

        public static bool operator +(ControlListas<T> control, T elemento)
        {
            bool sePudo = false;
            if (control != elemento)
            {
                control.lista.Add(elemento);
                sePudo = true;
            }
            return sePudo;
        }

        public static int BuscarIndex(ControlListas<T> listas , T elemento)
        {
            int index = -1;
            foreach (T item in listas.Lista)
            {
                if (item.Equals(elemento))
                {
                    index = listas.lista.IndexOf(item);
                    break; 
                }
            }
            return index;
        }
    }
}
