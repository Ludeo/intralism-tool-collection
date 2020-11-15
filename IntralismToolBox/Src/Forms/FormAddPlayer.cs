using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    /// <summary>
    /// Form to add players to the player list that is saved in <see cref="SavedPlayersCsvPath"/>
    /// </summary>
    public partial class FormAddPlayer : Form
    {
        /// <summary>
        /// path to the csv file where all the players are saved which got added to the <see cref="FormPlayerList"/>
        /// </summary>
        private const string SavedPlayersCsvPath = "savedplayers.csv";
        
        /// <summary>
        /// stringbuilder that will contain all the players from <see cref="SavedPlayersCsvPath"/> and the newly added player
        /// </summary>
        private readonly StringBuilder stringBuilder = new StringBuilder();
        
        /// <summary>
        ///  loading all players that are saved in <see cref="SavedPlayersCsvPath"/>
        /// </summary>
        private readonly string[][] players = CsvReader.GetCsvContent(SavedPlayersCsvPath);
        
        public FormAddPlayer() => this.InitializeComponent();

        /// <summary>
        /// function that is getting called when <see cref="addBtn"/> is pressed
        /// </summary>
        private void AddClicked(object sender, EventArgs e)
        {
            this.AppendTextBoxContents();
            this.SaveContents();
            this.Close();
        }

        /// <summary>
        /// adds the players from <see cref="SavedPlayersCsvPath"/> to the string builder <see cref="stringBuilder"/> and
        /// gets the player name from <see cref="nameTextBox"/> and the player link from <see cref="linkTextBox"/> and adds it to the
        /// <see cref="stringBuilder"/> as well
        /// </summary>
        private void AppendTextBoxContents()
        {
            foreach (string[] player in this.players)
            {
                this.CombineString(player[0], player[1]);
            }
            this.CombineString(this.nameTextBox.Text, this.linkTextBox.Text);
        }

        /// <summary>
        /// combines the string a and b together in the correct csv format and appends it to the <see cref="stringBuilder"/>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void CombineString(string a, string b) => this.stringBuilder.AppendLine(a + "," + b);

        /// <summary>
        /// writes all the players from <see cref="stringBuilder"/> to the csv file <see cref="SavedPlayersCsvPath"/>
        /// </summary>
        private void SaveContents() => File.WriteAllText(SavedPlayersCsvPath, this.stringBuilder.ToString());
    }
}