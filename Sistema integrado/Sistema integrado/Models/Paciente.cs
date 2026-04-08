using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;
using System.Text;

namespace Sistema_integrado.Models
{
    public class Paciente
    {
        private String Nombre { get; set; }
        private String Especie { get; set; }
        private String Raza { get; set; }
        private int Edad { get; set; }
        private double Peso { get; set; }

        private bool porSiAcaso { get; set; }
    }
}
