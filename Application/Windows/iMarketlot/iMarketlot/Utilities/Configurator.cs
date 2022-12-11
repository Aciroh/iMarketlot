using iMarketlot.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMarketlot.Utilities
{
    static public class Configurator
    {
        private static String path = Directory.GetCurrentDirectory() + @"\Resources\Configuration.cfg";
        private enum Key
        {
            EXEPath,
            InstancePath,
            APIKey
        }
        private static Dictionary<Key, String> parameters = new Dictionary<Key, String> { { Key.EXEPath, ""}, {Key.InstancePath,"" }, {Key.APIKey, "" } };
        private static Boolean hasConfig = false;


        public static void run()
        {
            run(false);
        }
        public static void run(Boolean openForm)
        {
            checkAndCreateFiles();

            readConfigFile();

            if(!hasConfig) 
            {
                startConfigurationForm();
                return;
            }
            if(openForm)
            {
                startConfigurationForm();
            }
        }

        private static void startConfigurationForm()
        {
            FormConfiguration form = new FormConfiguration();
            form.setEXEPath(parameters[Key.EXEPath]);
            form.setInstancePath(parameters[Key.InstancePath]);
            form.setAPIKey(parameters[Key.APIKey]);
            Application.Run(form);
        }

        private static void checkAndCreateFiles()
        {
            String dir = Directory.GetCurrentDirectory() + @"\Resources";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path));
            }
        }

        private static void readConfigFile()
        {            
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] words = line.Replace(" ", "").Split(new string[] { "::" }, StringSplitOptions.None);

                switch (words[0])
                {
                    case "EXEPath":
                        parameters[Key.EXEPath] = words[1];
                        break;

                    case "InstancePath":
                        parameters[Key.InstancePath] = words[1];
                        break;
                    case "APIKey":
                        parameters[Key.APIKey] = words[1];
                        break;
                }
            }
            parameters[Key.EXEPath] = parameters[Key.EXEPath].Replace(" ", "");
            parameters[Key.InstancePath] = parameters[Key.InstancePath].Replace(" ", "");
            parameters[Key.APIKey] = parameters[Key.APIKey].Replace(" ", "");
            if(parameters[Key.EXEPath].Length > 0 && parameters[Key.InstancePath].Length > 0 && parameters[Key.APIKey].Length > 0)
            {
                hasConfig = true;
            }
        }

        private static void writeConfigFile()
        {
            // Create a list of strings to hold the lines of the config file
            List<string> lines = new List<string>();

            // Iterate over the settings dictionary and add each setting to the list of lines
            foreach (var setting in parameters)
            {
                lines.Add($"{setting.Key}:: {setting.Value}");
            }

            // Write the list of lines to the file
            System.IO.File.WriteAllLines(path, lines);
        }

        public static void saveParameters(FormConfiguration form)
        {
            parameters[Key.EXEPath] = form.getEXEPath();
            parameters[Key.InstancePath] = form.getInstancePath();
            parameters[Key.APIKey] = form.getAPIKey();
            writeConfigFile();
        }

        public static Boolean checkIfCorrectInstanceFolder(String path)
        {
            if (!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                path += Path.DirectorySeparatorChar;
            }

            if (Directory.Exists(Path.Combine(path, "config")) && Directory.Exists(Path.Combine(path, "mods")) && Directory.Exists(Path.Combine(path, "resourcepacks")))
            {
                return true;
            }

            return false;
        }
    }
    }

