using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class CompleNotificacion
    {
        public int IdNotif { get; set; }
        public string Fuente { get; set; }
        public string CodDptoR { get; set; }
        public string DireccionR { get; set; }
        public DateTime? FecCon { get; set; }
        public DateTime? IniSin { get; set; }
        public string ClasifCaso { get; set; }
        public string PacHos { get; set; }
        public DateTime? FecHos { get; set; }
        public string ConFin { get; set; }
        public DateTime? FecDef { get; set; }
        public string CerDef { get; set; }
        public string CodCie { get; set; }
        public string NomProfe { get; set; }
        public int? Telefono { get; set; }
        public string TipCas { get; set; }
        public DateTime? Ajuste { get; set; }

        public virtual Cie10 CodCieNavigation { get; set; }
        public virtual Departamentos CodDptoRNavigation { get; set; }
    }
}
