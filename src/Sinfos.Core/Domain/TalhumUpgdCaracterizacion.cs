using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class TalhumUpgdCaracterizacion
    {
        public int IdCarac { get; set; }
        public TimeSpan? Epidemiologo { get; set; }
        public TimeSpan? MedEspecialista { get; set; }
        public TimeSpan? MedGeneral { get; set; }
        public TimeSpan? Enfermero { get; set; }
        public TimeSpan? Bacteriologo { get; set; }
        public TimeSpan? Tecnico { get; set; }
        public TimeSpan? PromotSalud { get; set; }
        public TimeSpan? Otro { get; set; }
        public TimeSpan? EnferIaas { get; set; }
        public TimeSpan? Infectologo { get; set; }
        public TimeSpan? Microbiologo { get; set; }

        public virtual ServiciosUpgdCaracterizacion IdCaracNavigation { get; set; }
    }
}
