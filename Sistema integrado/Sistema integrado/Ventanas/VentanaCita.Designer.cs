namespace Sistema_integrado.Ventanas
{
    partial class VentanaCita
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
            toolStrip1 = new ToolStrip();
            TSB_Programar = new ToolStripButton();
            TSB_Cargar = new ToolStripButton();
            TSB_Editar = new ToolStripButton();
            TSB_Eliminar = new ToolStripButton();
            DGV_Citas = new DataGridView();
            paciente = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            motivo = new DataGridViewTextBoxColumn();
            diagnostico = new DataGridViewTextBoxColumn();
            tratamiento = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Citas).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSB_Programar, TSB_Cargar, TSB_Editar, TSB_Eliminar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(854, 37);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Programar
            // 
            TSB_Programar.Image = Properties.Resources.mas;
            TSB_Programar.ImageTransparentColor = Color.Magenta;
            TSB_Programar.Name = "TSB_Programar";
            TSB_Programar.Size = new Size(169, 34);
            TSB_Programar.Text = "Programar cita";
            TSB_Programar.Click += TSB_Programar_Click;
            // 
            // TSB_Cargar
            // 
            TSB_Cargar.Image = Properties.Resources.actualizar;
            TSB_Cargar.ImageTransparentColor = Color.Magenta;
            TSB_Cargar.Name = "TSB_Cargar";
            TSB_Cargar.Size = new Size(94, 34);
            TSB_Cargar.Text = "Cargar";
            // 
            // TSB_Editar
            // 
            TSB_Editar.Image = Properties.Resources.editar;
            TSB_Editar.ImageTransparentColor = Color.Magenta;
            TSB_Editar.Name = "TSB_Editar";
            TSB_Editar.Size = new Size(86, 34);
            TSB_Editar.Text = "Editar";
            TSB_Editar.Click += TSB_Editar_Click;
            // 
            // TSB_Eliminar
            // 
            TSB_Eliminar.Image = Properties.Resources.boton_eliminar;
            TSB_Eliminar.ImageTransparentColor = Color.Magenta;
            TSB_Eliminar.Name = "TSB_Eliminar";
            TSB_Eliminar.Size = new Size(107, 34);
            TSB_Eliminar.Text = "Eliminar";
            // 
            // DGV_Citas
            // 
            DGV_Citas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Citas.Columns.AddRange(new DataGridViewColumn[] { paciente, fecha, motivo, diagnostico, tratamiento });
            DGV_Citas.Location = new Point(12, 40);
            DGV_Citas.Name = "DGV_Citas";
            DGV_Citas.Size = new Size(830, 464);
            DGV_Citas.TabIndex = 1;
            // 
            // paciente
            // 
            paciente.HeaderText = "Paciente";
            paciente.Name = "paciente";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // motivo
            // 
            motivo.HeaderText = "Motivo";
            motivo.Name = "motivo";
            // 
            // diagnostico
            // 
            diagnostico.HeaderText = "Diagnostico";
            diagnostico.Name = "diagnostico";
            // 
            // tratamiento
            // 
            tratamiento.HeaderText = "Tratamiento";
            tratamiento.Name = "tratamiento";
            // 
            // VentanaCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 516);
            Controls.Add(DGV_Citas);
            Controls.Add(toolStrip1);
            Name = "VentanaCita";
            Text = "Citas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Citas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Programar;
        private ToolStripButton TSB_Cargar;
        private ToolStripButton TSB_Editar;
        private ToolStripButton TSB_Eliminar;
        private DataGridView DGV_Citas;
        private DataGridViewTextBoxColumn paciente;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn motivo;
        private DataGridViewTextBoxColumn diagnostico;
        private DataGridViewTextBoxColumn tratamiento;
    }
}