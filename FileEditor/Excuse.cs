using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Excuse(Random random,string folder)
        {
            string[] fileNames = Directory.GetFiles(folder,"*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        private void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            using (StreamReader sr = new StreamReader(excusePath))
            {
                Description = sr.ReadLine();
                Result = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
        }
        public void Save(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path)) {
                streamWriter.WriteLine(Description);
                streamWriter.WriteLine(Result);
                streamWriter.WriteLine(LastUsed.ToString());
            }
        }
    }
}
