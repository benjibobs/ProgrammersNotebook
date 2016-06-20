using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ProgrammersNotebook
{
    class Util
    {

        public static bool createNewLibrary(string name, string path, bool includeDefault)
        {
            try
            {
                if (!name.EndsWith(".qvlibrary"))
                {
                    name = name + ".qvlibrary";
                }

                path = Path.Combine(path, name);

                if (Directory.Exists(path))
                {
                    return false;
                }

                Directory.CreateDirectory(path);

                name = Path.Combine(path, name);

                string meta = Path.Combine(path, "meta.json");

                Dictionary<string, string> metaJson = new Dictionary<string, string>();

                metaJson.Add("name", "Programmers Notebook Tutorial");
                metaJson.Add("uuid", "Tutorial");

                string actualJson = JsonConvert.SerializeObject(metaJson);

                if (!File.Exists(meta))
                {
                    File.WriteAllText(meta, actualJson);
                }
                else
                {
                    Console.WriteLine("File \"{0}\" already exists.", name);
                }

                if (includeDefault)
                {
                    path = Path.Combine(path, "Tutorial.qvnotebook");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static bool createNewLibrary(string name, string path)
        {
            return createNewLibrary(name, path, true);
        }

    }
}
