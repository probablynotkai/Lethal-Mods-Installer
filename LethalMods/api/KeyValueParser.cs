using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LethalMods.api
{
    public class KeyValueParser
    {
        public KeyValueParser() { }

        public List<string> LoadFilePairs(string path)
        {
            List<string> list = new List<string>();
            string line;

            try
            {
                StreamReader reader = new StreamReader(path);

                line = reader.ReadLine();

                while (line != null)
                {
                    if (!line.StartsWith("#"))
                    {
                        list.Add(line);
                    }
                    line = reader.ReadLine();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return list;
        }

        public T LoadObjectProperties<T>(T t, string path)
        {
            List<string> filePairs = LoadFilePairs(path);
            Dictionary<string, string> properties = GetKeyValuePairs(filePairs);

            return ObjectLoader(t, properties);
        }

        private T ObjectLoader<T>(T t, Dictionary<string, string> values)
        {
            foreach (string property in values.Keys)
            {
                PropertyInfo info = t.GetType().GetProperty(property);
                string value = values[property];

                info?.SetValue(t, value, null);
            }

            return t;
        }

        private Dictionary<string, string> GetKeyValuePairs(List<string> filePairs)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            foreach (string pair in filePairs)
            {
                string key = pair.Split(':')[0].Trim();
                string value = "";

                string[] args = pair.Split(':');
                for (int i = 0; i < args.Length; i++)
                {
                    if(i > 0)
                    {
                        if(i > 1)
                        {
                            value = value + ":" + args[i];
                        } else
                        {
                            value = value + args[i];
                        }
                    }
                }

                dic[key] = value.Trim();
            }

            return dic;
        }
    }
}
