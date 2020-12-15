using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class IdentPacienteNotificacion
    {
        public int? CodUgp { get; set; }
        public string CodEve { get; set; }
        public string Anno { get; set; }
        public string Semana { get; set; }
        public int IdNotif { get; set; }
        public string TipIde { get; set; }
        public string NumIde { get; set; }
        public string PriNom { get; set; }
        public string SegNom { get; set; }
        public string PriApe { get; set; }
        public string SegApe { get; set; }
        public string Telefono { get; set; }
        public string FechaNto { get; set; }
        public int? Edad { get; set; }
        public string Sexo { get; set; }
        public string CodPaisO { get; set; }
        public string Area { get; set; }
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public string CenPoblad { get; set; }
        public string CodVere { get; set; }
        public string Ocupacion { get; set; }
        public string Medida { get; set; }
        public string Municipio { get; set; }
    }
}
