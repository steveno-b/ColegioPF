using System;
using System.Collections.Generic;

namespace ColegioPF.Modelo
{
    public partial class Estudiantes
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public double? Nota1 { get; set; }
        public double? Nota2 { get; set; }
        public double? Nota3 { get; set; }
        public double? NotaDef { get; set; }
        public string Definitiva { get; set; }
    }
}
