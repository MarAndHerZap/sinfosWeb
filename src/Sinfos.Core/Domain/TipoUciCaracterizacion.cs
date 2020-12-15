using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class TipoUciCaracterizacion
    {
        public int IdCarac { get; set; }
        public string UciA { get; set; }
        public int? TotalCamasA { get; set; }
        public string SubtipoA { get; set; }
        public string ActivaA { get; set; }
        public string UciP { get; set; }
        public int? TotalCamasP { get; set; }
        public string SubtipoP { get; set; }
        public string ActivaP { get; set; }
        public string UciN { get; set; }
        public int? TotalCamasN { get; set; }
        public string SubtipoN { get; set; }
        public string ActivaN { get; set; }

        public virtual NotificaIaasCaracterizacion NotificaIaasCaracterizacion { get; set; }
    }
}
