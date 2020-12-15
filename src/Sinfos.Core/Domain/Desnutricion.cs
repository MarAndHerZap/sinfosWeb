using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class Desnutricion
    {
        public int Id { get; set; }
        public string PriNom { get; set; }
        public string SegNom { get; set; }
        public string PriApe { get; set; }
        public string SegApe { get; set; }
        public string TipIde { get; set; }
        public string NumIde { get; set; }
        public string Nivel { get; set; }
        public string Numero { get; set; }
        public string PesoNacer { get; set; }
        public string TallaNacer { get; set; }
        public string Edad { get; set; }
        public string Tiempo { get; set; }
        public string EdadInicio { get; set; }
        public string Incres { get; set; }
        public string Esquema { get; set; }
        public string Carnet { get; set; }
        public string Peso { get; set; }
        public string Talla { get; set; }
        public string Perimetro { get; set; }
        public string Imc { get; set; }
        public string ZcoreTalla { get; set; }
        public string ClasificacionPeso { get; set; }
        public string ZcoreEdad { get; set; }
        public string ClasificacionTalla { get; set; }
    }
}
