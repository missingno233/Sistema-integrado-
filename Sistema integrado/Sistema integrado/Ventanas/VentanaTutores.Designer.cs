namespace Sistema_integrado.Ventanas
{
    partial class VentanaTutores
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
            toolStrip1 = new ToolStrip();
            TSB_Crear = new ToolStripButton();
            TSB_Consulta = new ToolStripButton();
            TSB_Editar = new ToolStripButton();
            TSB_Eliminar = new ToolStripButton();
            DGVTutores = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTutores).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSB_Crear, TSB_Consulta, TSB_Editar, TSB_Eliminar });
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
            // DGVTutores
            // 
            DGVTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTutores.Location = new Point(10, 37);
            DGVTutores.Name = "DGVTutores";
            DGVTutores.Size = new Size(835, 467);
            DGVTutores.TabIndex = 1;
            // 
            // VentanaTutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 516);
            Controls.Add(DGVTutores);
            Controls.Add(toolStrip1);
            Name = "VentanaTutores";
            Text = "Tutores";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Consulta;
        private ToolStripButton TSB_Editar;
        private ToolStripButton TSB_Crear;
        private ToolStripButton TSB_Eliminar;
        private DataGridView DGVTutores;
    }
}