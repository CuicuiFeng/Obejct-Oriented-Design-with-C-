using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AssignmentTwo
{
    public class FileUtil : IReadable, IWriteable
    {
        public FileUtil()
        {
        }

        public List<string> ReadAll(string fileName, List<string> readData)
        {
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    readData.Add(s);
                }
            }
            return readData;
        }

        public void WriteAll(string fileName, List<string> data)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                foreach (var s in data)
                {
                    sw.WriteLine(s);
                }
            }

        }
    }
}
