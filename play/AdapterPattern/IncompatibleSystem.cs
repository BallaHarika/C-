using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdapterPattern
{
    public class FileLogger
    {
        public void CreateLog(string text)
        {
            FileStream fs = new FileStream(@"C:\Users\admin\Documents\FileLog.txt",FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write);
            fs.Write(Encoding.UTF8.GetBytes(text));

            fs.Close();

            Console.WriteLine(@"Filelog created at C:\Users\admin\Documents\FileLog.txt");
            Console.ResetColor();

        }
    }
}
