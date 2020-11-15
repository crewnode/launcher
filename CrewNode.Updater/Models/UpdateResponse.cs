using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewNode.Updater.Models
{
    internal class UpdateResponse
    {
        public string appId { get; set; }
        public string fileName { get; set; }
        public string version { get; set; }
        public string versionUrl { get; set; }
        public string shaHash { get; set; }
        public string launchArgs { get; set; }
    }
}
