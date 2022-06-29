using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlquilerCliente
    {
        private Cliente cliente;
        private Vehiculo vehiculoActual;
        private int cantidadDias;
        private Dictionary<Vehiculo, int> masAlquilado;

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Vehiculo VehiculoActual { get => vehiculoActual; set => vehiculoActual = value; }
        public int CantidadDias { get => cantidadDias; set => cantidadDias = value; }
        public Dictionary<Vehiculo, int> MasAlquilado { get => masAlquilado; set => masAlquilado = value; }

        public AlquilerCliente()
        {
            this.masAlquilado = new Dictionary<Vehiculo, int>();
        }

        public AlquilerCliente(Cliente cliente, Vehiculo vehiculo,int dias)
            : this()
        {
            this.cliente = cliente;
            this.vehiculoActual = vehiculo;
            this.cantidadDias = dias;
        }
              
        public static bool operator ==(AlquilerCliente a1, AlquilerCliente a2)
        {
            return a1 is not null && a2 is not null && a1.cliente.Equals(a2.Cliente);
        }

        public static bool operator !=(AlquilerCliente a1, AlquilerCliente a2)
        {
            return !(a1 == a2);
        }

        public static AlquilerCliente operator +(AlquilerCliente al, Vehiculo veh)
        {
            if (al.masAlquilado.ContainsKey(veh))
            {
                al.masAlquilado[veh]++;
            }
            else
            {
                al.masAlquilado.Add(veh, 1);
            }

            return al;
        }

        public override bool Equals(object obj)
        {
            AlquilerCliente alquiler = obj as AlquilerCliente;
            return alquiler is not null && this == alquiler; ;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(cliente.ToString());
            foreach (KeyValuePair<Vehiculo, int> item in this.masAlquilado)
            {
                sb.AppendLine($"Veces alquilado [{item.Value}] vehiculo: {item.Key}");
            }
            return sb.ToString();
        }
    }
}
