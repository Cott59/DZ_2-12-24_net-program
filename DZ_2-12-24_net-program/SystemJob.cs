using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;

namespace DZ_2_12_24_net_program
{
    internal class SystemJob
    {
        private string path = "output_log.txt";

        public  void SaveStringToFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {                
                writer.WriteLine(text);
            }
        }

        public void OpenLogFile()
        {
            //"notepad.exe"
            Process.Start(path);
        }

    }
}
