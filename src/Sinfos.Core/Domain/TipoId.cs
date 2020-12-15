using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class TipoId
    {
        public TipoId()
        {
            DatosCuidador = new HashSet<DatosCuidador>();
        }

        public string TipoIde { get; set; }
        public string NomTipIde { get; set; }

        public virtual ICollection<DatosCuidador> DatosCuidador { get; set; }
    }
}
