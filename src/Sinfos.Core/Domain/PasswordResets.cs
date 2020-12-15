using System;
using System.Collections.Generic;

namespace Sinfos.Infrastructure.Data
{
    public partial class PasswordResets
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
