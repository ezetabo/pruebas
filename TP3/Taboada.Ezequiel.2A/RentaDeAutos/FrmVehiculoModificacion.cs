using Entidades;
using System;
using System.Windows.Forms;

namespace RentaDeAutos
{
    public partial class FrmVehiculoModificacion : FrmVehiculoAlta
    {
        private Vehiculo vehiculo;

        public FrmVehiculoModificacion(Vehiculo vehiculo)
        {
            InitializeComponent();
            this.vehiculo = new Vehiculo(vehiculo.Patente,vehiculo.Clasificcacion,vehiculo.Color,false);
        }

        public override Vehiculo Vehiculo { get => vehiculo;}

        private void FrmVehiculoModificacion_Load(object sender, EventArgs e)
        {
            
            this.cmbClasificacion.DataSource = Enum.GetValues(typeof(EClasificcacion));
            this.cmbColor.DataSource = Enum.GetValues(typeof(ConsoleColor));
            this.textBox1.Text = vehiculo.Patente;
            this.cmbClasificacion.Text = vehiculo.Clasificcacion.ToString();
            this.cmbColor.Text = vehiculo.Color.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCarga())
            {
                Enum.TryParse<EClasificcacion>(this.cmbClasificacion.SelectedValue.ToString(), out EClasificcacion clasificcacion);
                Enum.TryParse<ConsoleColor>(this.cmbColor.SelectedValue.ToString(), out ConsoleColor color);
                this.vehiculo.Clasificcacion = clasificcacion;
                this.vehiculo.Color = color;
                this.DialogResult = DialogResult.OK;
            }
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
    }
}
