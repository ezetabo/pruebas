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
    public partial class FrmClienteAlta : FrmAltaHerencia
    {
        private List<Cliente> clientes;
        private Cliente cliente;

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public virtual Cliente Cliente { get => cliente; set => cliente = value; }

        public FrmClienteAlta()
        {

        }

        public FrmClienteAlta(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCarga())
            {
                if (!Validador.Es_DNI_Telefono(this.textBox1.Text))
                {
                    MessageBox.Show("Formato de Dni incorrecto");
                    this.textBox1.Clear();
                    this.textBox1.Focus();
                }
                if (!Validador.Es_DNI_Telefono(this.txtTelefono.Text))
                {
                    MessageBox.Show("Formato de Telefono incorrecto");
                    this.txtTelefono.Clear();
                    this.txtTelefono.Focus();
                }
                cliente = new Cliente(this.textBox1.Text,this.txtNombre.Text,this.txtApellido.Text,this.txtTelefono.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            foreach (Cliente item in this.clientes)
            {
                if (item.Dni == this.textBox1.Text)
                {
                    MessageBox.Show("El DNI ya existe");
                    this.textBox1.Clear();
                    this.textBox1.Focus();
                    break;
                }                
            }
        }
        
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Nombre no Valido");
                this.txtNombre.Clear();
                this.txtNombre.Focus();
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Apellido no valido");
                this.txtApellido.Clear();
                this.txtApellido.Focus();
            }
        }
    }

}
