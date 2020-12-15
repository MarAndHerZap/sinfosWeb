using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class InfoUpgdCaracterizacion
    {
        public int IdCarac { get; set; }
        public int? CodPre { get; set; }
        public int? CodSub { get; set; }
        public DateTime? FecCar { get; set; }
        public DateTime? FecSivigila { get; set; }
        public string RazSoc { get; set; }
        public string NitUpgd { get; set; }
        public string Dir { get; set; }
        public string RepLeg { get; set; }
        public string CorEle { get; set; }
        public string ResNot { get; set; }
        public string Tel { get; set; }
        public DateTime? FecActivi { get; set; }
        public string NatJur { get; set; }
        public string NivComplejidad { get; set; }
        public string EsUniInfo { get; set; }
        public string Estadoupgd { get; set; }
        public string NotifIaas { get; set; }
        public int Localidad { get; set; }
        public string NotifAcc { get; set; }
    }
}
