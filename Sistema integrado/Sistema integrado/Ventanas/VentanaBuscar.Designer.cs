namespace Sistema_integrado.Ventanas
{
    partial class VentanaBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaBuscar));
            txtBuscarPaciente = new TextBox();
            button1 = new Button();
            lblPaciente = new Label();
            lblTutores = new Label();
            txtBuscarTutor = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(126, 52);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(165, 23);
            txtBuscarPaciente.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(151, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBuscar_Click;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(54, 50);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(70, 21);
            lblPaciente.TabIndex = 2;
            lblPaciente.Text = "Paciente:";
            // 
            // lblTutores
            // 
            lblTutores.AutoSize = true;
            lblTutores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTutores.Location = new Point(70, 50);
            lblTutores.Name = "lblTutores";
            lblTutores.Size = new Size(50, 21);
            lblTutores.TabIndex = 3;
            lblTutores.Text = "Tutor:";
            // 
            // txtBuscarTutor
            // 
            txtBuscarTutor.Location = new Point(126, 52);
            txtBuscarTutor.Name = "txtBuscarTutor";
            txtBuscarTutor.Size = new Size(165, 23);
            txtBuscarTutor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 25);
            label1.TabIndex = 5;
            label1.Text = "Ingrese el nombre que desea buscar";
            // 
            // VentanaBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 161);
            Controls.Add(label1);
            Controls.Add(txtBuscarTutor);
            Controls.Add(lblTutores);
            Controls.Add(lblPaciente);
            Controls.Add(button1);
            Controls.Add(txtBuscarPaciente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaBuscar";
            Text = "Buscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarPaciente;
        private Button button1;
        private Label lblPaciente;
        private Label lblTutores;
        private TextBox txtBuscarTutor;
        private Label label1;
    }
}