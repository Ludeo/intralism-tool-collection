using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormAddPlayer : Form
    {
        private const string SavedPlayersCsvPath = "savedplayers.csv";

        private readonly StringBuilder stringBuilder = new StringBuilder();
        private readonly string[][] players = CsvReader.GetCsvContent(SavedPlayersCsvPath);
        
        public FormAddPlayer() => this.InitializeComponent();

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
            this.CombineString(this.nameTextBox.Text, this.linkTextBox.Text);
        }

        private void CombineString(string a, string b) => this.stringBuilder.AppendLine(a + "," + b);

        private void SaveContents() => File.WriteAllText(SavedPlayersCsvPath, this.stringBuilder.ToString());
    }
}