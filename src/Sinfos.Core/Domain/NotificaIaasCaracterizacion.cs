using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class NotificaIaasCaracterizacion
    {
        public int IdCarac { get; set; }
        public string HospUnive { get; set; }
        public string RegExcepc { get; set; }
        public string TotCamas { get; set; }
        public string ComiteInf { get; set; }
        public string BiProfesi { get; set; }
        public string IaasUltim { get; set; }
        public string InfTenden { get; set; }
        public string SocialTen { get; set; }
        public string LabMicrob { get; set; }
        public string LabPropio { get; set; }
        public string LabsContr { get; set; }
        public string IdentGye { get; set; }
        public string PrueSucep { get; set; }
        public string LabAutoma { get; set; }
        public string Vitek { get; set; }
        public string Microscan { get; set; }
        public string Phoenix { get; set; }
        public string LabCci { get; set; }
        public string LabCce { get; set; }
        public string MicrCdi { get; set; }
        public string Whonet { get; set; }
        public string InformPat { get; set; }
        public string LabConPe { get; set; }
        public string LabRemCe { get; set; }
        public string LabReport { get; set; }
        public string QuienVcab { get; set; }
        public string SerCirgen { get; set; }
        public string SerGineco { get; set; }
        public string SerCircar { get; set; }

        public virtual TipoUciCaracterizacion IdCaracNavigation { get; set; }
    }
}
