using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProgrammersNotebook
{
    class Util
    {
        
        /* Create new notebook */
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

        /* Create new note */
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

            string actualMetaJson = JsonConvert.SerializeObject(metaJson);

            if (!File.Exists(meta))
            {
                File.WriteAllText(meta, actualMetaJson);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", meta);
                return false;
            }
            
            //Work in progress - does NOT work in current state, will NOT compile. To fix this, temporarily comment the code
            string content = Path.Combine(notePath, "content.json");

            Dictionary<string, Object> contentJson = new Dictionary<string, Object>();

            Dictionary<string, Dictionary<string, string>> dummyCell = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> cellInfo = new Dictionary<string, string>();

            cellInfo.Add("type", "text");
            cellInfo.Add("data", "Hello! This is my attempt to mimic Quiver for Windows. If an official port is ever released, I am sure it will be much better!");

            dummyCell[0] = cellInfo;
            cellInfo.Clear();

            cellInfo.Add("type", "text");
            cellInfo.Add("data", "For example, this is a <b>text cell</b> with <i>some <u>formatting</u> applied</i>.");

            dummyCell[1] = cellInfo;
            cellInfo.Clear();

            contentJson.Add("title", title);
            contentJson.Add("cells", dummyCell);

            string actualContentJson = JsonConvert.SerializeObject(contentJson);

            if (!File.Exists(content))
            {
                File.WriteAllText(content, actualContentJson);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", content);
                return false;
            }

            return true;
        }

        /* Create new library */
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
                    //make tutorial notebook
                    if(!createNewNotebook("Tutorial", "A Programmer's Notebook Tutorial", path))
                    {
                        return false;
                    }
                    //add notes to tutorial notebook
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

        /* Create new library with defaults */
        public static bool createNewLibrary(string name, string path)
        {
            return createNewLibrary(name, path, true);
        }

        //Source: http://stackoverflow.com/questions/17632584/how-to-get-the-unix-timestamp-in-c-sharp
        /* Gets current UNIX timestamp */
        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

    }
}
