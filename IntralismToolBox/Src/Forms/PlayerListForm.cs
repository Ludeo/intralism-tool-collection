using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IntralismScoreChecker;
using IntralismToolBox.ColorSchemes;

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
            Form addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();

            Form newPlayerListForm = new PlayerListForm();
            newPlayerListForm.Show();
            this.Close();
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerListListBox.SelectedItem;
            Functions.CheckPlayer(current.Link);
        }

        /// <summary>
        ///     Reloads the color theme of the form. It's public so <see cref="SettingsForm"/> can call it.
        /// </summary>
        public void ReloadTheme()
        {
            Configuration config = Functions.LoadConfig();

            switch (config.AppSettings.Settings["darkmode"].Value)
            {
                case "true":
                    Functions.ChangeTheme<DarkColorScheme>(this);

                    break;
                case "false":
                    Functions.ChangeTheme<LightColorScheme>(this);

                    break;
            }
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerListListBox.SelectedItem;
            string[][] players = CsvReader.GetCsvContent(SavedPlayersCsv);
            StringBuilder sb = new();

            foreach (string[] player in players)
            {
                if (player[0].Equals(current.Name)
                 && player[1].Equals(current.Link)) {}
                else
                {
                    sb.AppendLine(player[0] + "," + player[1]);
                }
            }

            File.WriteAllText(SavedPlayersCsv, sb.ToString());

            Form newPlayerList = new PlayerListForm();
            newPlayerList.Show();
            this.Close();
        }
    }
}