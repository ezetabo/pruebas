using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlArchivos;
using Entidades;

namespace RentaDeAutos
{
    public partial class FrmAlquilar : Form
    {
        private ControlListas<Cliente> clientes;
        private ControlListas<Vehiculo> vehiculos;
        private Cliente cliente;
        private Vehiculo vehiculo;
        private AlquilerCliente alquilerCliente;
        private ControlListas<AlquilerCliente> registros;
        private Serializador<ControlListas<AlquilerCliente>> serializadorRegistros;
       

        public FrmAlquilar(ControlListas<Cliente> clientes, ControlListas<Vehiculo> vehiculos)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.vehiculos = vehiculos;
            this.registros = new ControlListas<AlquilerCliente>();
           
        }

        public AlquilerCliente AlquilerCliente { get => alquilerCliente; set => alquilerCliente = value; }
        public ControlListas<AlquilerCliente> Registros { get => registros; set => registros = value; }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(clientes);
            frmClientes.ShowDialog();
            if (frmClientes.DialogResult == DialogResult.OK)
            {
                this.cliente = frmClientes.Cliente;
                this.rtbCliente.Text = this.cliente.ToString();
            }
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            FrmVehiculos frmVehiculos = new FrmVehiculos(vehiculos);
            frmVehiculos.ShowDialog();
            if (frmVehiculos.DialogResult == DialogResult.OK)
            {
                this.vehiculo = frmVehiculos.Vehiculo;                
                this.rtbVehiculo.Text += this.vehiculo.ToString();
            }
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {

            double total = this.vehiculo.Costo * (double)numericUpDown1.Value;
            this.lblTotal.Text = total.ToString();
            this.vehiculo.Alquilado = true;
            this.alquilerCliente = new AlquilerCliente(cliente, vehiculo, (int)numericUpDown1.Value);
            if (registros != alquilerCliente)
            {
                _ = registros + alquilerCliente;
            }
            else
            {
                int indice = ControlListas<AlquilerCliente>.BuscarIndex(registros, alquilerCliente);
                _ = registros.Lista[indice] + vehiculo;
            }

            if (GenerarTicket())
            {
                if (MessageBox.Show("** Ticket impreso correctamente **") == DialogResult.OK)
                {
                    Limpiar();
                }
            }
        }

        private bool GenerarTicket()
        {
            StringBuilder sb = new StringBuilder();
            Archivo txt = new Archivo();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Ticket";

            sb.AppendLine("******************************************************");
            sb.AppendLine($"Alquieleres srl    {DateTime.Now.ToShortDateString()}");
            sb.AppendLine($"tipo de Vehiculo: {this.vehiculo.Clasificcacion} - Patente: {this.vehiculo.Patente}");
            sb.AppendLine($"Color: {this.vehiculo.Color} - Precio por dia: ${this.vehiculo.Costo:0.00}");
            sb.AppendLine($"Cantidad de dias:  {this.numericUpDown1.Value}");
            sb.AppendLine($"Total a pagar:  ${this.lblTotal.Text}");
            sb.AppendLine("******************************************************");
            return txt.Escribir(path + DateTime.Now.ToString("HH_mm_ss") + ".txt", sb.ToString());
        }

        private void Limpiar()
        {
            this.rtbCliente.Clear();
            this.rtbVehiculo.Clear();
            this.numericUpDown1.Value = 1;
            this.lblTotal.Text = string.Empty;
        }

        private void FrmAlquilar_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

