using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;
using System.Text;

namespace Sistema_integrado.Models
{
    public class Paciente
    {
        public String Nombre { get; set; }
        public String Especie { get; set; }
        public String Raza { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public bool porSiAcaso { get; set; }

    }
}
