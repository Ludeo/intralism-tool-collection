using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="MainForm.StatisticsButton"/> was pressed.
    /// </summary>
    public partial class StatisticsPlayerListForm : ThemedForm
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

        private void ShowStatisticsClicked(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new(this.PlayerListListBox.SelectedItem.ToString(), this.playerList);
            statisticsForm.Show();
        }
    }
}