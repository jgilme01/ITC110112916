using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ITC110112916
{
    class WriteFile
    {
        private StreamWriter writer;
        string filepath = null;




        public WriteFile(string path)//constructor, always same name as class, never has return type
        {
            try
            {
                filepath = path;
                writer = new StreamWriter(path, true);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddText(string line)
        {
            writer.Write(line);
        }


        public void CloseFile()
        {
            writer.Close();
        }
    }
}


