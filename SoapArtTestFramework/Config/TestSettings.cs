using EsFramework.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFramework.Config
{
    public class TestSettings
    {
        public BrowserType BrowserType { get; set; }
        public Uri AppUrl { get; set; }
        public float? TimeoutInterval { get; set; }
    }
}
