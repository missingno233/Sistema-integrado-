namespace Sistema_integrado
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            TSB_Crear = new ToolStripButton();
            TSB_Consulta = new ToolStripButton();
            TSB_Editar = new ToolStripButton();
            TSB_Eliminar = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSB_Crear, TSB_Consulta, TSB_Editar, TSB_Eliminar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Crear
            // 
            TSB_Crear.Image = (Image)resources.GetObject("TSB_Crear.Image");
            TSB_Crear.ImageTransparentColor = Color.Magenta;
            TSB_Crear.Name = "TSB_Crear";
            TSB_Crear.Size = new Size(134, 22);
            TSB_Crear.Text = "Crear nuevo registro";
            TSB_Crear.Click += TSB_Crear_Click;
            // 
            // TSB_Consulta
            // 
            TSB_Consulta.Image = (Image)resources.GetObject("TSB_Consulta.Image");
            TSB_Consulta.ImageTransparentColor = Color.Magenta;
            TSB_Consulta.Name = "TSB_Consulta";
            TSB_Consulta.Size = new Size(62, 22);
            TSB_Consulta.Text = "Cargar";
            TSB_Consulta.Click += TSB_Consulta_Click;
            // 
            // TSB_Editar
            // 
            TSB_Editar.Image = (Image)resources.GetObject("TSB_Editar.Image");
            TSB_Editar.ImageTransparentColor = Color.Magenta;
            TSB_Editar.Name = "TSB_Editar";
            TSB_Editar.Size = new Size(57, 22);
            TSB_Editar.Text = "Editar";
            TSB_Editar.Click += TSB_Editar_Click;
            // 
            // TSB_Eliminar
            // 
            TSB_Eliminar.Image = (Image)resources.GetObject("TSB_Eliminar.Image");
            TSB_Eliminar.ImageTransparentColor = Color.Magenta;
            TSB_Eliminar.Name = "TSB_Eliminar";
            TSB_Eliminar.Size = new Size(70, 22);
            TSB_Eliminar.Text = "Eliminar";
            TSB_Eliminar.Click += TSB_Eliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 398);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Veterinaria yeye";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Consulta;
        private ToolStripButton TSB_Editar;
        private ToolStripButton TSB_Crear;
        private ToolStripButton TSB_Eliminar;
        private DataGridView dataGridView1;
    }
}
