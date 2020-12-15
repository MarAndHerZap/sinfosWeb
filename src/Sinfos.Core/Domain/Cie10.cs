using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class Cie10
    {
        public Cie10()
        {
            CompleNotificacion = new HashSet<CompleNotificacion>();
        }

        public string CodCie { get; set; }
        public string NomCie { get; set; }
        public string TranProt1 { get; set; }
        public string TranProt2 { get; set; }

        public virtual ICollection<CompleNotificacion> CompleNotificacion { get; set; }
    }
}
