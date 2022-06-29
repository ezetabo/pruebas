using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace RentaDeAutos
{
    public partial class FrmVehiculos : Form
    {

        ControlListas<Vehiculo> vehiculos;
        Vehiculo vehiculo;

        public ControlListas<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }
        public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }

        public FrmVehiculos(ControlListas<Vehiculo> vehiculos)
        {
            InitializeComponent();
            this.vehiculos = vehiculos;

        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = vehiculos.Lista;
        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.vehiculo =(Vehiculo)this.dataGridView1.CurrentRow.DataBoundItem;
            if (MessageBox.Show("*** ESTE PROCESO ES IRREVERSIBLE *** \n\n ¿Seguro que quiere eliminar ese vehiculo?","Eliminar Vehiculo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                if(this.vehiculos - vehiculo)
                {
                    MessageBox.Show("Vehiculo eliminado");
                    Limpar();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmVehiculoAlta frmAlta = new FrmVehiculoAlta(this.vehiculos.Lista);
            frmAlta.ShowDialog();
            if (frmAlta.DialogResult == DialogResult.OK)
            {
                if (this.vehiculos + frmAlta.Vehiculo)
                {
                    MessageBox.Show("Alta exitosa");
                    Limpar();
                }
            }
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPatente.Text))
            {               
                List<Vehiculo> aux = new List<Vehiculo>();
                foreach (Vehiculo item in this.vehiculos.Lista)
                {
                    if (item.Patente.StartsWith(this.txtPatente.Text.ToUpper()))
                    {
                        aux.Add(item);
                    }
                }
                this.dataGridView1.DataSource = aux;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar() 
        {
            this.dataGridView1.DataSource = null;
            this.txtPatente.Text = null;
            this.dataGridView1.DataSource = this.vehiculos.Lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmVehiculoModificacion modificacion = new FrmVehiculoModificacion((Vehiculo)this.dataGridView1.CurrentRow.DataBoundItem);
            modificacion.ShowDialog();
            if (modificacion.DialogResult == DialogResult.OK)
            {               
                int indice = ControlListas<Vehiculo>.BuscarIndex(this.vehiculos,modificacion.Vehiculo);
                if (indice > -1)
                {
                    this.vehiculos.Lista[indice] = modificacion.Vehiculo;
                    MessageBox.Show("Modificacion exitosa");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("se rompio");
                }           
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.vehiculo = (Vehiculo)this.dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
                int indice = ControlListas<Vehiculo>.BuscarIndex(this.vehiculos, (Vehiculo)this.dataGridView1.CurrentRow.DataBoundItem);
                if (indice > -1)
                {
                    this.vehiculos.Lista[indice].Alquilado = false;
                    MessageBox.Show("Vehiculo liberado");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un vehiculo");
                }
            
        }
    }
}
