using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class DesnutricionFactores
    {
        public string NumIde { get; set; }
        public decimal? PesoNac { get; set; }
        public decimal? TallaNac { get; set; }
        public decimal? EdadGes { get; set; }
        public decimal? TLechem { get; set; }
        public decimal? EComplem { get; set; }
        public string CrecDllo { get; set; }
        public string EsqVac { get; set; }
        public string CarneVac { get; set; }
        public decimal? PesoAct { get; set; }
        public decimal? TallaAct { get; set; }
        public decimal? PerBraqui { get; set; }
        public decimal? Imc { get; set; }
        public decimal? ZscorePt { get; set; }
        public string ClasPeso { get; set; }
        public decimal? ZscoreTe { get; set; }
        public string ClasTalla { get; set; }
        public bool? Edema { get; set; }
        public bool? Delgadez { get; set; }
        public bool? PielRese { get; set; }
        public bool? Hiperpigm { get; set; }
        public bool? LesCabel { get; set; }
        public bool? Palidez { get; set; }
        public string RutaAtenc { get; set; }
        public string TipoManej { get; set; }
        public string DiagMedic { get; set; }
        public int? Complicaciones { get; set; }

        public virtual IceDesnutricion NumIdeNavigation { get; set; }
        public virtual DatosCuidador DatosCuidador { get; set; }
    }
}
