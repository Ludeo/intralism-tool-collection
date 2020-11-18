using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IntralismScoreChecker;

namespace ManiaToIntralism.Forms
{
    public partial class AddPlayerForm : Form
    {
        private const string SavedPlayersCsvPath = "savedplayers.csv";

        private readonly StringBuilder stringBuilder = new StringBuilder();

        private readonly string[][] players = CsvReader.GetCsvContent(SavedPlayersCsvPath);

        public AddPlayerForm() => this.InitializeComponent();

        private void AddClicked(object sender, EventArgs e)
        {
            this.AppendTextBoxContents();
            this.SaveContents();
            this.Close();
        }

        private void AppendTextBoxContents()
        {
            foreach (string[] player in this.players)
            {
                this.CombineString(player[0], player[1]);
            }

            this.CombineString(this.PlayerNameTextBox.Text, this.PlayerLinkTextBox.Text);
        }

        private void CombineString(string a, string b) => this.stringBuilder.AppendLine(a + "," + b);

        private void SaveContents() => File.WriteAllText(SavedPlayersCsvPath, this.stringBuilder.ToString());
    }
}