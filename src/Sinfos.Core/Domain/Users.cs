using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class Users
    {
        public long Id { get; set; }
        public string TipoDoc { get; set; }
        public string Nit { get; set; }
        public string Name { get; set; }
        public string Telefono { get; set; }
        public string FechaIni { get; set; }
        public string FechaEnd { get; set; }
        public string Name2 { get; set; }
        public string Lastname { get; set; }
        public string Secondname2 { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Profesion { get; set; }
        public string Password { get; set; }
        public string RememberToken { get; set; }
    }
}
