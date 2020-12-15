using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class DesnutricionFactoresVisita
    {
        public string NumIde { get; set; }
        public decimal? PesoAct { get; set; }
        public decimal? TallaAct { get; set; }
        public decimal? PerBraqui { get; set; }
        public decimal? Imc { get; set; }
        public decimal? ZscorePt { get; set; }
        public string ClasPeso { get; set; }
        public decimal? ZscoreTe { get; set; }
        public string ClasTalla { get; set; }
        public int? Clasifi2 { get; set; }
        public DateTime? AjusteSivigila { get; set; }
        public string SignosDnt { get; set; }
        public string Conclusiones { get; set; }
        public string PlanInter { get; set; }
        public string RecomenIndivi { get; set; }
        public string SeCanalizo { get; set; }
        public string EntiCanalizada { get; set; }
        public string ProgCanalizo { get; set; }
        public string NombreProfecional { get; set; }
        public string Subred { get; set; }
        public byte[] FirmaCui { get; set; }
        public string NombRetroali { get; set; }
        public string Cargo { get; set; }

        public virtual HabitosAlimentarios HabitosAlimentarios { get; set; }
    }
}
