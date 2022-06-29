using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;
        private string telefono;

        public Cliente()
        {

        }

        public Cliente(string dni, string nombre, string apellido, string telefono)
        {
            this.dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.telefono = telefono;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = Validador.FormatoNombre(value); }
        public string Apellido { get => apellido; set => apellido = Validador.FormatoNombre(value); }
        public string Telefono { get => telefono; set => telefono = value; }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1 is not null && c2 is not null && c1.Dni == c2.dni;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Cliente nuevo = obj as Cliente;
            return nuevo is not null && this == nuevo;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{"Dni",-8}{":",2}{this.dni}");
            sb.AppendLine($"{"Nombre",-8}{":",2}{this.nombre}");
            sb.AppendLine($"{"Apellido",-8}{":",2}{ this.apellido}");
            sb.AppendLine($"{"Telefono",-8}{":",2}{ telefono}");           
            return sb.ToString();          
        }
    }
}
