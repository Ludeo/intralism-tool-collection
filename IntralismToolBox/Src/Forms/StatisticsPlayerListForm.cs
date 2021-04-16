using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IntralismToolBox.ColorSchemes;
using Newtonsoft.Json;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="MainForm.StatisticsButton"/> was pressed.
    /// </summary>
    public partial class StatisticsPlayerListForm : Form
    {
        private List<IntralismScoreChecker.Player> playerList = new();

        /// <summary>
        ///     Initializes a new instance of the <see cref="StatisticsPlayerListForm"/> class.
        /// </summary>
        public StatisticsPlayerListForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();

            this.PlayerListListBox.ScrollAlwaysVisible = true;
            this.LoadPlayers();

            if (this.PlayerListListBox.Items.Count >= 1)
            {
                this.PlayerListListBox.SelectedIndex = 0;
            }
        }

        private void LoadPlayers()
        {
            byte[] compressedFile = File.ReadAllBytes("playerdatabase.json");
            string uncompressedFile = Compressor.Unzip(compressedFile);
            this.playerList = JsonConvert.DeserializeObject<List<IntralismScoreChecker.Player>>(uncompressedFile!);

            foreach (string itemName in this.playerList?
                                            .Select(player => player.Name + " (" + player.Id + ")")
                                            .Where(itemName => this.PlayerListListBox.FindString(itemName) == -1))
            {
                this.PlayerListListBox.Items.Add(itemName!);
            }
        }

        /// <summary>
        ///     Function that will reload the <see cref="PlayerListListBox"/>.
        /// </summary>
        public void ReloadData()
        {
            this.PlayerListListBox.Items.Clear();
            this.LoadPlayers();
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
                    Functions.ChangeTheme(new DarkColorScheme(), this);

                    break;
                case "false":
                    Functions.ChangeTheme(new LightColorScheme(), this);

                    break;
            }
        }

        private void ShowStatisticsClicked(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new(this.PlayerListListBox.SelectedItem.ToString(), this.playerList);
            statisticsForm.Show();
        }
    }
}