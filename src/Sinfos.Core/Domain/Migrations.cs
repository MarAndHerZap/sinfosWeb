using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class Migrations
    {
        public int Id { get; set; }
        public string Migration { get; set; }
        public int Batch { get; set; }
    }
}
