using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace RentaDeAutos
{
    public partial class FrmClientes : Form
    {

        ControlListas<Cliente> clientes;
        Cliente cliente;

        public Cliente Cliente { get => cliente; set => cliente = value; }
               
        public FrmClientes(ControlListas<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clientes.Lista;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.cliente = (Cliente)this.dataGridView1.CurrentRow.DataBoundItem;
            if (MessageBox.Show("*** ESTE PROCESO ES IRREVERSIBLE *** \n\n ¿Seguro que quiere eliminar ese Cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (this.clientes - cliente)
                {
                    MessageBox.Show("Cliente eliminado");
                    Limpar();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmClienteAlta frmAlta = new FrmClienteAlta(this.clientes.Lista);
            frmAlta.ShowDialog();
            if (frmAlta.DialogResult == DialogResult.OK)
            {
                if (this.clientes + frmAlta.Cliente)
                {
                    MessageBox.Show("Alta exitosa");
                    Limpar();
                }
            }
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text))
            {
                List<Cliente> aux = new List<Cliente>();
                foreach (Cliente  item in this.clientes.Lista)
                {
                    if (item.Dni.StartsWith(this.textBox1.Text.ToUpper()))
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
            this.textBox1.Text = null;
            this.dataGridView1.DataSource = this.clientes.Lista;
        }
           
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            FrmClienteModificacion modificacion = new FrmClienteModificacion((Cliente)this.dataGridView1.CurrentRow.DataBoundItem);
            modificacion.ShowDialog();
            if (modificacion.DialogResult == DialogResult.OK)
            {
                int indice = ControlListas<Cliente>.BuscarIndex(this.clientes, modificacion.Cliente);
                if (indice > -1)
                {
                    this.clientes.Lista[indice] = modificacion.Cliente;
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
            this.cliente = (Cliente)this.dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
