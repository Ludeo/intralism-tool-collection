using System;
using System.IO;
using System.Text;
using IntralismScoreChecker;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="MainForm.PlayerListButton"/> was pressed.
    /// </summary>
    public partial class PlayerListForm : ThemedForm
    {
        private const string SavedPlayersCsv = "savedplayers.csv";

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlayerListForm"/> class.
        /// </summary>
        public PlayerListForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();

            this.PlayerListListBox.ScrollAlwaysVisible = true;

            string[][] players = CsvReader.GetCsvContent(SavedPlayersCsv);

            foreach (string[] player in players)
            {
                this.PlayerListListBox.Items.Add(new Player(player[0], player[1]));
            }

            if (players.Length >= 1)
            {
                this.PlayerListListBox.SelectedIndex = 0;
            }
        }

        private void AddClicked(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new();
            addPlayerForm.ShowDialog();

            PlayerListForm newPlayerListForm = new();
            newPlayerListForm.Show();
            this.Close();
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerListListBox.SelectedItem;
            Functions.CheckPlayer(current.Link);
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerListListBox.SelectedItem;
            string[][] players = CsvReader.GetCsvContent(SavedPlayersCsv);
            StringBuilder sb = new();

            foreach (string[] player in players)
            {
                if (player[0].Equals(current.Name) &&
                    player[1].Equals(current.Link)) {}
                else
                {
                    sb.AppendLine(player[0] + "," + player[1]);
                }
            }

            File.WriteAllText(SavedPlayersCsv, sb.ToString());

            PlayerListForm newPlayerList = new();
            newPlayerList.Show();
            this.Close();
        }
    }
}