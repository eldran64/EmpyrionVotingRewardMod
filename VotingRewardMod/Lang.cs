using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace VotingRewardMod
{
    public static class Lang
    {
        private static Dictionary<string, string> _texts = new Dictionary<string, string>();
        public static string CurrentLanguage { get; private set; } = "en";

        public static void Load(string lang = "en")
        {
            string filename = Path.Combine("lang", $"lang.{lang}.json");
            
            if (File.Exists(filename))
                _texts = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filename));
            else
                _texts = new Dictionary<string, string>(); // fallback vide
            CurrentLanguage = lang;
        }

        public static string T(string key, params object[] args)
        {
            if (_texts.TryGetValue(key, out var value))
                return args.Length > 0 ? string.Format(value, args) : value;
            // fallback
            return $"[{key}]";
        }
    }
}
