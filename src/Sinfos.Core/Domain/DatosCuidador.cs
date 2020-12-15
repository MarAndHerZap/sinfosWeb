using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class DatosCuidador
    {
        public string NumIde { get; set; }
        public string PriNomCui { get; set; }
        public string SegNomCui { get; set; }
        public string PriApeCui { get; set; }
        public string SegApeCui { get; set; }
        public string TipIdeCui { get; set; }
        public string NumIdeCui { get; set; }
        public int? EdadCui { get; set; }
        public string OcupaCui { get; set; }
        public string NivEducat { get; set; }
        public decimal? Menores { get; set; }

        public virtual DesnutricionFactores NumIdeNavigation { get; set; }
        public virtual TipoId TipIdeCuiNavigation { get; set; }
    }
}
