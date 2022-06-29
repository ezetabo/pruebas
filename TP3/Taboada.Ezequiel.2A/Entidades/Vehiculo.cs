using System;
using System.Text;

namespace Entidades
{
    public enum EClasificcacion
    {
        Economico,
        Grande,
        Mini,
        Superior,
        Van
    }
    public class Vehiculo
    {
        private string patente;
        private EClasificcacion clasificcacion;
        private ConsoleColor color;
        private bool alquilado;
        private double costo;

        public Vehiculo()
        {

        }

        public Vehiculo(string patende, EClasificcacion clasificcacion, ConsoleColor color, bool alquilado)           
        {
            this.Patente = patende;
            this.clasificcacion = clasificcacion;
            this.color = color;
            this.alquilado = alquilado;
            this.costo = Vehiculo.ValorDia(this.clasificcacion);
        }

        public string Patente { get => patente; set => patente = value.ToUpper(); }
        public EClasificcacion Clasificcacion { get => clasificcacion; set => clasificcacion = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public bool Alquilado { get => alquilado; set => alquilado = value; }
        public double Costo { get => costo; set => costo = value; }

        public static bool operator ==(Vehiculo c1, Vehiculo c2)
        {
            return c1 is not null && c2 is not null && c1.patente == c2.patente;
        }

        public static bool operator !=(Vehiculo c1, Vehiculo c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Vehiculo nuevo = obj as Vehiculo;
            return nuevo is not null && this == nuevo;
        }

        public override int GetHashCode()
        {
            return this.patente.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{"Patente",-14}{":",2}{this.patente,-10}");
            sb.AppendLine($"{"Clasificacion",-14}{":",2}{this.clasificcacion,-10}");
            sb.AppendLine($"{"Color",-14}{":",2}{ this.color,-8}");
            sb.AppendLine($"{"Alquilado",-14}{":",2}{ alquilado,-6}");
            sb.AppendLine($"{"Costo",-14}{":",2}${ this.costo:0.00}");
            return sb.ToString();
        }

        private static double ValorDia(EClasificcacion clasificcacion)
        {
            double valor = 0;
            switch (clasificcacion)
            {
                case EClasificcacion.Economico:
                    valor = 7388;
                    break;
                case EClasificcacion.Grande:
                    valor = 8522;
                    break;
                case EClasificcacion.Mini:
                    valor = 10952;
                    break;
                case EClasificcacion.Superior:
                    valor = 16720;
                    break;
                case EClasificcacion.Van:
                    valor = 19612;
                    break;
              
            }
            return valor;
        }
       
    }
}
