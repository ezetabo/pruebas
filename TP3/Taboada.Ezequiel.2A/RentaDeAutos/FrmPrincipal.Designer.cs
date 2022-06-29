
namespace RentaDeAutos
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolClientes,
            this.toolVehiculos,
            this.toolAlquiler,
            this.toolSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(984, 77);
            this.menuPrincipal.TabIndex = 3;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // toolClientes
            // 
            this.toolClientes.Image = ((System.Drawing.Image)(resources.GetObject("toolClientes.Image")));
            this.toolClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolClientes.Name = "toolClientes";
            this.toolClientes.Size = new System.Drawing.Size(125, 73);
            this.toolClientes.Text = "Clientes";
            this.toolClientes.Click += new System.EventHandler(this.toolClientes_Click);
            // 
            // toolVehiculos
            // 
            this.toolVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("toolVehiculos.Image")));
            this.toolVehiculos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolVehiculos.Name = "toolVehiculos";
            this.toolVehiculos.Size = new System.Drawing.Size(133, 73);
            this.toolVehiculos.Text = "Vehiculos";
            this.toolVehiculos.Click += new System.EventHandler(this.toolVehiculos_Click);
            // 
            // toolAlquiler
            // 
            this.toolAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("toolAlquiler.Image")));
            this.toolAlquiler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAlquiler.Name = "toolAlquiler";
            this.toolAlquiler.Size = new System.Drawing.Size(124, 73);
            this.toolAlquiler.Text = "Alquiler";
            this.toolAlquiler.Click += new System.EventHandler(this.toolAlquiler_Click);
            // 
            // toolSalir
            // 
            this.toolSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolSalir.Image")));
            this.toolSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSalir.Name = "toolSalir";
            this.toolSalir.Size = new System.Drawing.Size(105, 73);
            this.toolSalir.Text = "Salir";
            this.toolSalir.Click += new System.EventHandler(this.toolSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 416);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolClientes;
        private System.Windows.Forms.ToolStripMenuItem toolVehiculos;
        private System.Windows.Forms.ToolStripMenuItem toolAlquiler;
        private System.Windows.Forms.ToolStripMenuItem toolSalir;
    }
}

