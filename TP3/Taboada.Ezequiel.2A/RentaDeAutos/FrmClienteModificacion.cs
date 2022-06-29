using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace RentaDeAutos
{
    public partial class FrmClienteModificacion : FrmClienteAlta
    {
        private Cliente cliente;
        public override Cliente Cliente { get => cliente; set => cliente = value; }

        public FrmClienteModificacion(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = new Cliente(cliente.Dni, cliente.Nombre, cliente.Apellido, cliente.Telefono);
        }

        private void FrmClienteModificacion_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.cliente.Dni;
            this.txtNombre.Text = this.cliente.Nombre;
            this.txtApellido.Text = this.cliente.Apellido;
            this.txtTelefono.Text = this.cliente.Telefono;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validador.Es_DNI_Telefono(this.txtTelefono.Text))
            {
                MessageBox.Show("Formato de Telefono incorrecto");
                this.txtTelefono.Clear();
                this.txtTelefono.Focus();
            }
            if (VerificarCarga())
            {
                this.cliente.Nombre = this.txtNombre.Text;
                this.cliente.Apellido = this.txtApellido.Text;
                this.cliente.Telefono = this.txtTelefono.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool VerificarCarga()
        {
            bool ok = true;
            foreach (Control item in groupBox1.Controls)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
