﻿using System.Collections.Generic;

namespace CrewNodeLauncher.Utils.Models
{
    public class ConfigFile
    {
        public class Server
        {
            public string name { get; set; }
            public string instance { get; set; }
        }

        public IList<Server> servers { get; set; }
    }
}
