using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class HabitosAlimentarios
    {
        public string NumIde { get; set; }
        public int? InicioLact { get; set; }
        public int? EdaLacExcu { get; set; }
        public int? EdaLacComple { get; set; }
        public string FormLac { get; set; }
        public string CualFormLac { get; set; }
        public int? HstaEdaForm { get; set; }
        public int? EdaOtrasBebidas { get; set; }
        public int? EdaAlimeSoli { get; set; }
        public string AlimMayorFre { get; set; }
        public string AlimMenorFre { get; set; }
        public int? Grupo1 { get; set; }
        public int? Grupo2 { get; set; }
        public int? Grupo3 { get; set; }
        public int? Grupo4 { get; set; }
        public int? Grupo5 { get; set; }
        public int? Grupo6 { get; set; }
        public int? ConsisMayor { get; set; }
        public string AlimeDiaAnte { get; set; }
        public string IntoleAlimen { get; set; }
        public string AnaliAlimen { get; set; }
        public string AnaliAlimenPorque { get; set; }
        public int? Intrahospitalario { get; set; }
        public int? AcidoFolico { get; set; }
        public int? Antibiotico { get; set; }
        public int? EgresoFtlc { get; set; }
        public int? EntregaFtlc { get; set; }
        public int? ConsumoFtlc { get; set; }
        public string Observaciones { get; set; }
        public string OtraFormula { get; set; }

        public virtual DesnutricionFactoresVisita NumIdeNavigation { get; set; }
        public virtual IceDesnutricion IceDesnutricion { get; set; }
    }
}
