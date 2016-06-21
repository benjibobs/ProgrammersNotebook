using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProgrammersNotebook
{
    class Util
    {

        public static bool createNewNotebook(string name, string displayName, string path)
        {
            string notebookPath = Path.Combine(path, name + ".qvnotebook");

            if (Directory.Exists(notebookPath))
            {
                return false;
            }
            else
            {
                Directory.CreateDirectory(notebookPath);
            }

            string meta = Path.Combine(notebookPath, "meta.json");

            Dictionary<string, string> metaJson = new Dictionary<string, string>();

            metaJson.Add("name", displayName);
            metaJson.Add("uuid", name);

            string actualJson = JsonConvert.SerializeObject(metaJson);

            if (!File.Exists(meta))
            {
                File.WriteAllText(meta, actualJson);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", meta);
                return false;
            }

            return true;
        }

        public static bool createNewNote(string title, string[] tags, string path)
        {
            string GUID = Guid.NewGuid().ToString().ToUpper();

            string notePath = Path.Combine(path, GUID + ".qvnote");

            if (Directory.Exists(notePath))
            {
                return false;
            }
            else
            {
                Directory.CreateDirectory(notePath);
            }

            string meta = Path.Combine(notePath, "meta.json");

            Dictionary<string, Object> metaJson = new Dictionary<string, Object>();

            metaJson.Add("created_at", UnixTimeNow());
            metaJson.Add("tags", tags);
            metaJson.Add("title", title);
            metaJson.Add("updated_at", UnixTimeNow());
            metaJson.Add("uuid", GUID);

            string actualJson = JsonConvert.SerializeObject(metaJson);

            if (!File.Exists(meta))
            {
                File.WriteAllText(meta, actualJson);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", meta);
                return false;
            }

            return true;
        }

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
                
                if (includeDefault)
                {
                    if(!createNewNotebook("Tutorial", "A Programmer's Notebook Tutorial", path))
                    {
                        return false;
                    }

                    string notebookPath = Path.Combine(path, "Tutorial.qvnotebook");
                    string[] tags = new string[2];
                    tags[0] = "Test 1";
                    tags[1] = "Test 2";
                    if (!createNewNote("Test", tags, notebookPath))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool createNewLibrary(string name, string path)
        {
            return createNewLibrary(name, path, true);
        }

        //Source: http://stackoverflow.com/questions/17632584/how-to-get-the-unix-timestamp-in-c-sharp
        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

    }
}
