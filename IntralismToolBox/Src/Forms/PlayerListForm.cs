using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IntralismScoreChecker;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="MainForm.PlayerListButton"/> was pressed.
    /// </summary>
    public partial class PlayerListForm : Form
    {
        private const string SavedPlayersCsv = "savedplayers.csv";

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlayerListForm"/> class.
        /// </summary>
        public PlayerListForm()
        {
            this.InitializeComponent();
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
            StringBuilder sb = new ();
            bool first = false;

            foreach (string[] t in players)
            {
                if (t[0].Equals(current.Name) &&
                    t[1].Equals(current.Link))
                {
                }
                else
                {
                    if (first)
                    {
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append(t[0] + "," + t[1]);
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