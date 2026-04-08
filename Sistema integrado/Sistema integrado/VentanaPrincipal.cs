using Sistema_integrado.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_integrado
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void PBMascota_Click(object sender, EventArgs e)
        {
            VentanaMascota ventana = new VentanaMascota();
            this.Hide();
            ventana.FormClosed += (s, args) => this.Show();
            ventana.Show();
        }

        private void PBTutores_Click(object sender, EventArgs e)
        {
            VentanaTutores ventana = new VentanaTutores();
            this.Hide();
            ventana.FormClosed += (s, args) => this.Show();
            ventana.Show();
        }
    }
}
