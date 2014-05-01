using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
namespace Dota2ModManager
{
    public class Mod
    {
        public string data_location;

        public List<string> affected_files;
        public Info info;
        private string info_loc;
        public Mod(string location)
        {
            data_location = location;
            info_loc = data_location + "/info.json";
            affected_files = (
                from file in Directory.EnumerateFiles(data_location, "*", SearchOption.AllDirectories).ToList<string>()
                where !file.EndsWith("info.json")
                select file.Replace('\\', '/').Replace(data_location + "/", "")
                ).ToList<string>();

            //    Console.WriteLine(JsonConvert.SerializeObject(info));
            DeserializeInfo();
            info.order = 9999;
            
        }
        string sanitize(string s)
        {
          
            return s.Replace("\\", "\\\\");
        }
        public void SaveInfo()
        {
            File.WriteAllText(info_loc, JsonConvert.SerializeObject(info));
        }
        void DeserializeInfo()
        {
            
            try
            {
                info = JsonConvert.DeserializeObject<Info>(File.ReadAllText(info_loc));

            }
            catch (Exception)
            {
                
                info.name = data_location.Split('/').Last();
                info.author = "";
                info.description = "";
                info.order = 256;
                var result = DialogResult.Yes;
                if(File.Exists(info_loc))
                result = MessageBox.Show("Error while parsing info.json of " + data_location + "! Overwrite with basic info.json?", "Invalid info.json", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    SaveInfo();
            }

        }
        public string AboutBox()
        {


            string template = "{{\\rtf1 \\ansi \\fs24 {0} \\fs16 \\line \\i {1} \\i0 \\page \\page {2} \\page\\page \\b Affected files: \\b0 \\fs18 \\i \\line {3} \\i0 \\fs21 }}"; //how i wish i could just use html or markdown...
            string author = info.author == "" ? "Anonymous" : info.author;
            string description = info.description == "" ? "No description." : info.description;

            return String.Format(template, sanitize(info.name), sanitize(author), sanitize(description), string.Join(" \\line ", affected_files));
        }
        public override string ToString()
        {
            return info.name;
        }
       public struct Info
        {
           
           public int order;
            public string name;
            public string author;
            public string description;
        }
    }
}
