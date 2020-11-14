using CrewNode.Launcher.Utils.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CrewNode.Launcher.Utils
{
    class Configuration
    {
        private static Configuration _instance;
        private static string _configPath = $"{Application.StartupPath}\\crewnode.config.json";
        private ConfigFile _config;

        public static Configuration instance()
        {
            if (_instance != null)
                return _instance;
            return _instance = new Configuration();
        }

        public Configuration()
        {
            try
            {
                string configContents = File.ReadAllText(_configPath);
                _config = JsonConvert.DeserializeObject<ConfigFile>(configContents);
            }
            catch
            {
                // Create new file
                this.createConfig();
            }
        }

        public IList<ConfigFile.Server> getServers() => _config.servers;

        private void createConfig()
        {
            _config = new ConfigFile();
            _config.servers = new List<ConfigFile.Server>();
            this.writeConfig();
        }

        private void writeConfig()
        {
            File.WriteAllText(_configPath, JsonConvert.SerializeObject(_config, Formatting.Indented));
        }
    }
}
