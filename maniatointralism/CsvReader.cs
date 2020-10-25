using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace maniatointralism
{
    public class CsvReader
    {
        
        public string[][] GetCsvContent(string path)
        {
            try
            {
                var fileLength = File.ReadLines(path).Count() + 1;
                var result = new string[fileLength][];
                var count = 0;

                foreach (var line in File.ReadLines(""))
                {
                    var entry = line.Split(",");
                    result[count] = entry;
                    count++;
                }

                return result;
            }
            catch (Exception)
            {
                MessageBox.Show(@"CSV-File missing or is empty", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new string[0][];

        }
    }
}