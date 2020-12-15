using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class Agenda
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Hallazgo { get; set; }
        public string AccionMejora { get; set; }
        public int Estado { get; set; }
    }
}
