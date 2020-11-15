using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ManiaToIntralism
{
    /// <summary>
    /// the csvreader is an instance to read through csv files
    /// </summary>
    public class CsvReader
    {
        /// <summary>
        /// reads the file inside the given path and returns it in a 2d string array
        /// </summary>
        public static string[][] GetCsvContent(string path)
        {
            // checks if the file exists or if the file is empty
            if (File.Exists(path) && !string.IsNullOrWhiteSpace(File.ReadAllText(path)))
            {
                return File.ReadLines(path).Select(line => line.Split(",")).ToArray();
            }

            MessageBox.Show(
                @"CSV-File missing or is empty",
                @"Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return new string[0][];
        }
    }
}