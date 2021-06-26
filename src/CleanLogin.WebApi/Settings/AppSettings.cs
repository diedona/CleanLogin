using CleanLogin.Application.Interfaces.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanLogin.WebApi.Settings
{
    public class AppSettings : IAppSettings
    {
        public string Secret { get; set; }

        public int HoursAllowed { get; set; }
    }
}
