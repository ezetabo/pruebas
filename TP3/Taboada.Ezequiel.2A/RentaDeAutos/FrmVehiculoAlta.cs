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
    public partial class FrmVehiculoAlta : FrmAltaHerencia
    {
        List<Vehiculo> vehiculos;
        private Vehiculo vehiculo;

        public virtual Vehiculo Vehiculo { get => vehiculo; }

        public FrmVehiculoAlta()
        {

        }

        public FrmVehiculoAlta(List<Vehiculo> lista)
        {
            InitializeComponent();
            this.vehiculos = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCarga())
            {
                Enum.TryParse<EClasificcacion>(this.cmbClasificacion.SelectedValue.ToString(), out EClasificcacion clasificcacion);
                Enum.TryParse<ConsoleColor>(this.cmbColor.SelectedValue.ToString(), out ConsoleColor color);
                this.vehiculo = new Vehiculo(textBox1.Text, clasificcacion, color, false);
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

        private void FrmAltaVehiculo_Load(object sender, EventArgs e)
        {
            this.cmbClasificacion.DataSource = Enum.GetValues(typeof(EClasificcacion));
            this.cmbColor.DataSource = Enum.GetValues(typeof(ConsoleColor));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Vehiculo item in this.vehiculos)
            {
                if (item.Patente == this.textBox1.Text.ToUpper())
                {
                    MessageBox.Show("La patente ya existe");
                    this.textBox1.Clear();
                    this.textBox1.Focus();
                    break;
                }
            }  
            
        }
    }
}
