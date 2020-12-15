using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            CompleNotificacion = new HashSet<CompleNotificacion>();
        }

        public string CodDep { get; set; }
        public string NomDep { get; set; }

        public virtual ICollection<CompleNotificacion> CompleNotificacion { get; set; }
    }
}
