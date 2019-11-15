using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmi
{
    class WriteTxt
    {
        private string Name;
        private string Path;
        public WriteTxt(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }
        public WriteTxt(string path)
        {
            this.Name = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
            this.Path = path;
        }
        public void saveFile(string text)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path + Name + ".txt",true))
            {
                file.WriteLine(text);
            }
        }
    }
}
