namespace Sistema_integrado
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            PBMascota = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            PBTutores = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PBMascota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBTutores).BeginInit();
            SuspendLayout();
            // 
            // PBMascota
            // 
            PBMascota.Image = Properties.Resources.paw;
            PBMascota.Location = new Point(42, 37);
            PBMascota.Name = "PBMascota";
            PBMascota.Size = new Size(233, 246);
            PBMascota.SizeMode = PictureBoxSizeMode.StretchImage;
            PBMascota.TabIndex = 0;
            PBMascota.TabStop = false;
            PBMascota.Click += PBMascota_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 286);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 1;
            label1.Text = "Mascotas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 286);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 3;
            label2.Text = "Tutores";
            // 
            // PBTutores
            // 
            PBTutores.Image = Properties.Resources.people;
            PBTutores.Location = new Point(392, 37);
            PBTutores.Name = "PBTutores";
            PBTutores.Size = new Size(233, 246);
            PBTutores.SizeMode = PictureBoxSizeMode.StretchImage;
            PBTutores.TabIndex = 2;
            PBTutores.TabStop = false;
            PBTutores.Click += PBTutores_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 351);
            Controls.Add(label2);
            Controls.Add(PBTutores);
            Controls.Add(label1);
            Controls.Add(PBMascota);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaPrincipal";
            Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)PBMascota).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBMascota;
        private Label label1;
        private Label label2;
        private PictureBox PBTutores;
    }
}