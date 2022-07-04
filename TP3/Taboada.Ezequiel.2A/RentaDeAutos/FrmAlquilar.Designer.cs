
namespace RentaDeAutos
{
    partial class FrmAlquilar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            this.rtbVehiculo = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblFechaRetorno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(69, 33);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(94, 50);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(343, 33);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(74, 50);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.Text = "Agregar Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // rtbCliente
            // 
            this.rtbCliente.Location = new System.Drawing.Point(7, 89);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.Size = new System.Drawing.Size(249, 96);
            this.rtbCliente.TabIndex = 2;
            this.rtbCliente.Text = "";
            // 
            // rtbVehiculo
            // 
            this.rtbVehiculo.Location = new System.Drawing.Point(262, 89);
            this.rtbVehiculo.Name = "rtbVehiculo";
            this.rtbVehiculo.Size = new System.Drawing.Size(249, 96);
            this.rtbVehiculo.TabIndex = 3;
            this.rtbVehiculo.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(252, 206);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de dias:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total a Pagar : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(206, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(211, 46);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(58, 279);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(359, 50);
            this.btnAlquilar.TabIndex = 8;
            this.btnAlquilar.Text = "Alquilar Vehiculo";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Regreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de retiro";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaActual.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFechaActual.Location = new System.Drawing.Point(573, 74);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(211, 53);
            this.lblFechaActual.TabIndex = 12;
            this.lblFechaActual.Text = "label6";
            this.lblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaRetorno
            // 
            this.lblFechaRetorno.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblFechaRetorno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaRetorno.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFechaRetorno.Location = new System.Drawing.Point(573, 182);
            this.lblFechaRetorno.Name = "lblFechaRetorno";
            this.lblFechaRetorno.Size = new System.Drawing.Size(211, 53);
            this.lblFechaRetorno.TabIndex = 13;
            this.lblFechaRetorno.Text = "label4";
            this.lblFechaRetorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAlquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1256, 534);
            this.Controls.Add(this.lblFechaRetorno);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rtbVehiculo);
            this.Controls.Add(this.rtbCliente);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.btnAgregarCliente);
            this.Name = "FrmAlquilar";
            this.Text = "Alquiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlquilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.RichTextBox rtbCliente;
        private System.Windows.Forms.RichTextBox rtbVehiculo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblFechaRetorno;
    }
}