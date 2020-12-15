using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class ServiciosUpgdCaracterizacion
    {
        public int IdCarac { get; set; }
        public int? ConsultaGnrl { get; set; }
        public int? ConsultaEsp { get; set; }
        public int? Urgencias { get; set; }
        public int? Vacunacion { get; set; }
        public int? MedGnrl { get; set; }
        public int? MedInt { get; set; }
        public int? Pediatria { get; set; }
        public int? Neurologia { get; set; }
        public int? Ginecobstetricia { get; set; }
        public int? CuidIntensivos { get; set; }
        public int? Hematologia { get; set; }
        public int? Microbiologia { get; set; }
        public int? Quimica { get; set; }
        public int? Inmunologia { get; set; }
        public int? Patologia { get; set; }
        public int? Toxicologia { get; set; }
        public int? Parasitologia { get; set; }
        public int? Virologia { get; set; }

        public virtual TalhumUpgdCaracterizacion TalhumUpgdCaracterizacion { get; set; }
    }
}
