namespace Sistema_integrado
{
    partial class VentanaMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMascota));
            toolStrip1 = new ToolStrip();
            TSB_Crear = new ToolStripButton();
            TSB_Consulta = new ToolStripButton();
            TSB_Editar = new ToolStripButton();
            TSB_Eliminar = new ToolStripButton();
            TSB_BuscarMascotas = new ToolStripButton();
            DGVMascotas = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Especie = new DataGridViewTextBoxColumn();
            Raza = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            TSB_Cita = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMascotas).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSB_Crear, TSB_Consulta, TSB_Editar, TSB_Eliminar, TSB_BuscarMascotas, TSB_Cita });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(854, 37);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Crear
            // 
            TSB_Crear.Image = Properties.Resources.plus;
            TSB_Crear.ImageTransparentColor = Color.Magenta;
            TSB_Crear.Name = "TSB_Crear";
            TSB_Crear.Size = new Size(221, 34);
            TSB_Crear.Text = "Crear nuevo registro";
            TSB_Crear.Click += TSB_Crear_Click;
            // 
            // TSB_Consulta
            // 
            TSB_Consulta.Image = Properties.Resources.load;
            TSB_Consulta.ImageTransparentColor = Color.Magenta;
            TSB_Consulta.Name = "TSB_Consulta";
            TSB_Consulta.Size = new Size(94, 34);
            TSB_Consulta.Text = "Cargar";
            TSB_Consulta.Click += TSB_Consulta_Click;
            // 
            // TSB_Editar
            // 
            TSB_Editar.Image = Properties.Resources.edit;
            TSB_Editar.ImageTransparentColor = Color.Magenta;
            TSB_Editar.Name = "TSB_Editar";
            TSB_Editar.Size = new Size(86, 34);
            TSB_Editar.Text = "Editar";
            TSB_Editar.Click += TSB_Editar_Click;
            // 
            // TSB_Eliminar
            // 
            TSB_Eliminar.Image = Properties.Resources.delete;
            TSB_Eliminar.ImageTransparentColor = Color.Magenta;
            TSB_Eliminar.Name = "TSB_Eliminar";
            TSB_Eliminar.Size = new Size(107, 34);
            TSB_Eliminar.Text = "Eliminar";
            TSB_Eliminar.Click += TSB_Eliminar_Click;
            // 
            // TSB_BuscarMascotas
            // 
            TSB_BuscarMascotas.Alignment = ToolStripItemAlignment.Right;
            TSB_BuscarMascotas.Image = Properties.Resources.buscandoimagen;
            TSB_BuscarMascotas.ImageTransparentColor = Color.Magenta;
            TSB_BuscarMascotas.Name = "TSB_BuscarMascotas";
            TSB_BuscarMascotas.Size = new Size(94, 34);
            TSB_BuscarMascotas.Text = "Buscar";
            TSB_BuscarMascotas.Click += TSB_BuscarMascotas_Click;
            // 
            // DGVMascotas
            // 
            DGVMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMascotas.Columns.AddRange(new DataGridViewColumn[] { Nombre, Especie, Raza, Edad, Peso });
            DGVMascotas.Location = new Point(10, 37);
            DGVMascotas.Name = "DGVMascotas";
            DGVMascotas.Size = new Size(832, 467);
            DGVMascotas.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre del paciente";
            Nombre.Name = "Nombre";
            // 
            // Especie
            // 
            Especie.HeaderText = "Especie";
            Especie.Name = "Especie";
            // 
            // Raza
            // 
            Raza.HeaderText = "Raza";
            Raza.Name = "Raza";
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Peso
            // 
            Peso.HeaderText = "Peso";
            Peso.Name = "Peso";
            // 
            // TSB_Cita
            // 
            TSB_Cita.Image = Properties.Resources.cita;
            TSB_Cita.ImageTransparentColor = Color.Magenta;
            TSB_Cita.Name = "TSB_Cita";
            TSB_Cita.Size = new Size(69, 34);
            TSB_Cita.Text = "Cita";
            TSB_Cita.Click += TSB_Cita_Click;
            // 
            // VentanaMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 516);
            Controls.Add(DGVMascotas);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaMascota";
            Text = "Mascotas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Consulta;
        private ToolStripButton TSB_Editar;
        private ToolStripButton TSB_Crear;
        private ToolStripButton TSB_Eliminar;
        private DataGridView DGVMascotas;
        private ToolStripButton TSB_BuscarMascotas;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Raza;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Peso;
        private ToolStripButton TSB_Cita;
    }
}
