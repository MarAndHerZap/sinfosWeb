using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class IceDesnutricion
    {
        public string NumIde { get; set; }
        public string IceInstitucion { get; set; }
        public string IceDomicilio { get; set; }
        public DateTime? FechaInicioIec { get; set; }
        public string NombreUpegd { get; set; }
        public DateTime? FechanotUpgd { get; set; }
        public DateTime? FechaSisvan { get; set; }
        public string ServIdenti { get; set; }
        public string DireccionReci { get; set; }
        public byte[] Familograma { get; set; }
        public string Observaciones { get; set; }
        public string IngresosFamiliaresMes { get; set; }
        public int? Estrato { get; set; }
        public int? TipVivienda { get; set; }
        public string TipTenencia { get; set; }
        public int? FuenteAgua { get; set; }
        public int? Basuras { get; set; }
        public int? ManipuAlimento { get; set; }
        public int? EstadoHigvivienda { get; set; }
        public string Antecedentes { get; set; }
        public string AnteceCual { get; set; }
        public int? Alergias { get; set; }
        public int? AlergCual { get; set; }
        public int? AnteceNaci { get; set; }
        public string OtroanteceNutri { get; set; }
        public string Hospitalizacion { get; set; }
        public string ProgPriemerainfancia { get; set; }
        public string ProgApoyoalimen { get; set; }
        public string EstadoVacuna { get; set; }

        public virtual HabitosAlimentarios NumIdeNavigation { get; set; }
        public virtual DesnutricionFactores DesnutricionFactores { get; set; }
    }
}
