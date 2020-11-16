using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ManiaToIntralism
{
    public class CsvReader
    {
        public static string[][] GetCsvContent(string path)
        {
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