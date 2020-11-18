using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IntralismScoreChecker;

namespace ManiaToIntralism.Forms
{
    public partial class PlayerListForm : Form
    {
        private const string SavedPlayersCsv = "savedplayers.csv";

        public PlayerListForm()
        {
            this.InitializeComponent();
            this.PlayerListListBox.ScrollAlwaysVisible = true;

            string[][] players = CsvReader.GetCsvContent(SavedPlayersCsv);

            for (int i = 0; i < players.Length; i++)
            {
                this.PlayerListListBox.Items.Add(new Player(players[i][0], players[i][1]));
            }

            if (players.Length >= 1)
            {
                this.PlayerListListBox.SelectedIndex = 0;
            }
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerListListBox.SelectedItem;
            Functions.CheckPlayer(current.Link);
        }

        private void AddClicked(object sender, EventArgs e)
        {
            Form addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();

            Form newPlayerListForm = new PlayerListForm();
            newPlayerListForm.Show();
            this.Close();
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerListListBox.SelectedItem;
            string[][] players = CsvReader.GetCsvContent(SavedPlayersCsv);
            StringBuilder sb = new StringBuilder();
            bool first = false;

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i][0].Equals(current.Name) &&
                    players[i][1].Equals(current.Link))
                {
                }
                else
                {
                    if (first)
                    {
                        sb.Append("\n");
                    }

                    sb.Append(players[i][0] + "," + players[i][1]);
                    first = true;
                }
            }

            File.WriteAllText(SavedPlayersCsv, sb.ToString());

            Form newPlayerList = new PlayerListForm();
            newPlayerList.Show();
            this.Close();
        }
    }
}