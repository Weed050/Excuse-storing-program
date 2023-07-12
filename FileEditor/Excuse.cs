using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileEditor
{
    class Excuse
    {
        public string Description { get; set; }
        public string Result { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }
        public Excuse()
        {
            ExcusePath = "";
        }
        public Excuse(string excusePath)
        => OpenFile(excusePath);

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        private void OpenFile(string excusePath)
        {
                ExcusePath = excusePath;
            using (StreamReader sr = new StreamReader(excusePath))
            {
                Excuse temporarlyExcuse = JsonConvert.DeserializeObject<Excuse>(sr.ReadToEnd());
                Description = temporarlyExcuse.Description;
                LastUsed = temporarlyExcuse.LastUsed;
                Result = temporarlyExcuse.Result;
            }
        }

        public void Save(string path)
        {

            //var file1 = File.OpenWrite(path);
            //file1.Write(JsonConvert.SerializeObject(this));
            using (StreamWriter streamWriter = new StreamWriter(path))
                streamWriter.Write(JsonConvert.SerializeObject(this));


        }
    }
}
