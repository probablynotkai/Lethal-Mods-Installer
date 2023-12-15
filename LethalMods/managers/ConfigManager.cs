using LethalMods.api;
using LethalMods.models.configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LethalMods.managers
{
    public class ConfigManager
    {
        private KeyValueParser Parser = new KeyValueParser();
        public MenuConfig MenuConfig { get; }

        public ConfigManager() 
        {
            MenuConfig = Parser.LoadObjectProperties(new MenuConfig(), "config.yml");
        }
    }
}
