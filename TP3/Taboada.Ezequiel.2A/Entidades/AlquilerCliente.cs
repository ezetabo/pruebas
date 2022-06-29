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
        private double total;
        private DateTime fechaAlquiler;
        private DateTime fechaRetorno;

       

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Vehiculo VehiculoActual { get => vehiculoActual; set => vehiculoActual = value; }
        public int CantidadDias { get => cantidadDias; set => cantidadDias = value; }
        public double Total { get => total; set => total = value; }

        public AlquilerCliente()
        {
           
        }

        public AlquilerCliente(Cliente cliente, Vehiculo vehiculo,int dias)
            : this()
        {
            this.cliente = cliente;
            this.vehiculoActual = vehiculo;
            this.cantidadDias = dias;
        }
              
        
       

       
    }
}
