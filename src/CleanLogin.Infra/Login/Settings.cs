using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Infra.Login
{
    public static class Settings
    {
        public static string Secret => "amor#nanana$alada18";

        public static DateTime ExpireTime => DateTime.Now.AddHours(8);
    }
}
