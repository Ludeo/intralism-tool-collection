using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using IntralismToolBox.Forms;
using IntralismToolBox.Interfaces;
using Newtonsoft.Json;

namespace IntralismToolBox
{
    /// <summary>
    ///     Class that contains helper functions.
    /// </summary>
    public static class Functions
    {
        private static void AddPlayerToDatabase(IntralismScoreChecker.Player player)
        {
            List<IntralismScoreChecker.Player> playerList = new();

            if (!File.Exists("playerdatabase.json"))
            {
                playerList.Add(player);
                string uncompressedFile2 = JsonConvert.SerializeObject(playerList);
                byte[] compressedFile2 = Compressor.Zip(uncompressedFile2);
                File.WriteAllBytes("playerdatabase.json", compressedFile2!);

                return;
            }

            byte[] compressedFile = File.ReadAllBytes("playerdatabase.json");
            string uncompressedFile = Compressor.Unzip(compressedFile);

            if (!string.IsNullOrEmpty(uncompressedFile))
            {
                playerList = JsonConvert.DeserializeObject<List<IntralismScoreChecker.Player>>(uncompressedFile);
            }

            playerList.Add(player);
            uncompressedFile = JsonConvert.SerializeObject(playerList);
            compressedFile = Compressor.Zip(uncompressedFile);
            File.WriteAllBytes("playerdatabase.json", compressedFile!);
        }

        /// <summary>
        ///     Changes the color of windows.forms components.
        /// </summary>
        /// <param name="scheme"> <see cref="IColorScheme"/> that contains the colors of the windows.forms components. </param>
        /// <param name="form"> The windows.forms class where colors should be changed. </param>
        public static void ChangeTheme<TColorScheme>(Form form)
            where TColorScheme : struct, IColorScheme
        {
            TColorScheme scheme = default;
            form.BackColor = scheme.FormBackgroundColor;
            form.ForeColor = scheme.FormForegroundColor;

            ChangeTheme(scheme, form.Controls);
        }

        private static void ChangeTheme(IColorScheme scheme, IEnumerable container)
        {
            foreach (Control component in container)
            {
                switch (component)
                {
                    case Button button:
                        button.BackColor = scheme.ButtonBackgroundColor;
                        button.FlatAppearance.BorderColor = scheme.ButtonBorderColor;

                        break;
                    case TextBox textBox:
                        textBox.BackColor = scheme.TextBoxBackgroundColor;
                        textBox.ForeColor = scheme.TextBoxForegroundColor;

                        break;
                    case GroupBox groupBox:
                        ChangeTheme(scheme, groupBox.Controls);
                        groupBox.ForeColor = scheme.GroupBoxForegroundColor;

                        break;
                    case ListBox listBox:
                        listBox.BackColor = scheme.ListBoxBackgroundColor;
                        listBox.ForeColor = scheme.ListBoxForegroundColor;

                        break;
                    case DataGridView dataGridView:
                        dataGridView.BackgroundColor = scheme.DataGridBackgroundColor;
                        dataGridView.ForeColor = scheme.DataGridForegroundColor;
                        dataGridView.GridColor = scheme.DataGridGridColor;

                        dataGridView.DefaultCellStyle.BackColor = scheme.DataGridCellBackgroundColor;
                        dataGridView.EnableHeadersVisualStyles = scheme.DataGridEnableHeadersVisualStyles;
                        dataGridView.RowHeadersDefaultCellStyle.BackColor = scheme.DataGridBackgroundColor;
                        dataGridView.RowHeadersDefaultCellStyle.ForeColor = scheme.DataGridForegroundColor;
                        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = scheme.DataGridBackgroundColor;
                        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = scheme.DataGridForegroundColor;

                        break;
                    case Chart chart:
                        chart.BackColor = scheme.ButtonBackgroundColor;
                        chart.ChartAreas[0].BackColor = scheme.ButtonBackgroundColor;
                        chart.Series[0].Color = scheme.GraphLineColor;

                        foreach (DataPoint dataPoint in chart.Series[0].Points)
                        {
                            dataPoint.MarkerColor = scheme.GraphMarkerColor;
                        }

                        break;
                }
            }
        }

        private static void CheckConfig()
        {
            if (!File.Exists("config.xml"))
            {
                StringBuilder sb = new();
                sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sb.AppendLine("<configuration xmlns=\"http://schemas.microsoft.com/.NetConfiguration/v2.0\"></configuration>");
                File.WriteAllText(@"config.xml", sb.ToString());

                ExeConfigurationFileMap configMap = new() { ExeConfigFilename = @"config.xml" };
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                config.AppSettings.Settings.Add("maniapath", $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\osu!\\Songs");
                config.AppSettings.Settings.Add("editorpath", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Intralism\\Editor");
                config.AppSettings.Settings.Add("audiopath", $"C:\\Users\\{Environment.UserName}\\Desktop");
                config.AppSettings.Settings.Add("lastchecked", "https://intralism.khb-soft.ru/?player=76561198143629166");
                config.AppSettings.Settings.Add("darkmode", "true");
                config.Save();
            }
        }

        /// <summary>
        ///     Function that creates a new instance of <see cref="IntralismScoreChecker.Player"/> and opens a <see cref="UserProfileForm"/>
        ///     and a <see cref="UserScoreForm"/> with the details of the player.
        /// </summary>
        /// <param name="link"> Link to the intralism player. </param>
        public static void CheckPlayer(string link)
        {
            IntralismScoreChecker.Player newPlayer = new(link, true);
            DisplayPlayer(newPlayer);
        }

        /// <summary>
        ///     Function that creates a new instance of <see cref="IntralismScoreChecker.Player"/> and opens a <see cref="UserProfileForm"/>
        ///     and a <see cref="UserScoreForm"/> with the details of the player.
        /// </summary>
        /// <param name="rank"> Global Rank of the intralism player. </param>
        public static void CheckPlayerByRank(int rank)
        {
            IntralismScoreChecker.Player newPlayer = new(rank);
            DisplayPlayer(newPlayer);
        }

        /// <summary>
        ///     Function that creates a new instance of <see cref="IntralismScoreChecker.Player"/> and opens a <see cref="UserProfileForm"/>
        ///     and a <see cref="UserScoreForm"/> with the details of the player.
        /// </summary>
        /// <param name="searchInput"> Searches for a intralism player and displays the first player that was found. </param>
        public static void CheckPlayerWithSearch(string searchInput)
        {
            IntralismScoreChecker.Player newPlayer = new(searchInput, false);
            DisplayPlayer(newPlayer);
        }

        /// <summary>
        ///     Useful for telling the user when they're being a dumbass.
        /// </summary>
        /// <param name="message">
        ///     The error message, provide information that can be useful for the user.
        ///     (i.e. WHY they got this message and how they can fix it).
        /// </param>
        /// <param name="title">The Title of the error box.</param>
        public static void DisplayErrorMessage(string message, string title = "You Dignus!") =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private static void DisplayPlayer(IntralismScoreChecker.Player player)
        {
            UserProfileForm profileUserProfileForm = new(player.GlobalRank,
                                                         player.TotalGlobalRank,
                                                         player.Country,
                                                         player.CountryRank,
                                                         player.TotalCountryRank,
                                                         player.AverageMisses,
                                                         player.AverageAccuracy,
                                                         player.Points,
                                                         player.RealPoints,
                                                         player.MaximumPoints,
                                                         player.Difference,
                                                         player.HundredPlays,
                                                         player.TotalMaps,
                                                         player.RankUpPoints,
                                                         player.PictureLink,
                                                         player.Name);

            profileUserProfileForm.Show();

            UserScoreForm userScore = new(player.Scores, player.Name);
            userScore.Show();

            SaveLastChecked(player.Link);
            AddPlayerToDatabase(player);
        }

        /// <summary>
        ///     Loads the config.xml file.
        /// </summary>
        /// <returns> A Configuration object with the data of the config.xml file. </returns>
        public static Configuration LoadConfig()
        {
            CheckConfig();
            ExeConfigurationFileMap configMap = new() { ExeConfigFilename = @"config.xml" };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

            return config;
        }

        /// <summary>
        ///     Opens a file dialog.
        /// </summary>
        /// <param name="initialDirectory"> Directory that get opens when the file dialog shows up. </param>
        /// <param name="filter"> Filter for the selected files. </param>
        /// <returns> The name of the selected file. </returns>
        public static string OpenFileAndGetName(string initialDirectory, string filter = "")
        {
            OpenFileDialog fileDialog = new()
            {
                InitialDirectory = initialDirectory,
                Filter = filter,
            };

            // If the user cancelled, return string.Empty
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                fileDialog.Dispose();

                return string.Empty;
            }

            // Return the path and dispose
            string fileName = fileDialog.FileName;
            fileDialog.Dispose();

            return fileName;
        }

        /// <summary>
        ///     Opens Folder Dialogue and returns the selected path or "" if cancelled.
        /// </summary>
        /// <param name="initialDirectory">The directory to start the folder dialogue in.</param>
        /// <returns>The Selected Path or "" if cancelled.</returns>
        public static string OpenFolderAndGetName(string initialDirectory)
        {
            FolderBrowserDialog folderDialog = new()
            {
                SelectedPath = initialDirectory,
            };

            // If the user cancelled, return string.Empty
            if (folderDialog.ShowDialog() != DialogResult.OK)
            {
                folderDialog.Dispose();

                return string.Empty;
            }

            // Return the path and dispose
            string folderName = folderDialog.SelectedPath;
            folderDialog.Dispose();

            return folderName;
        }

        private static void SaveLastChecked(string playerLink)
        {
            Configuration config = LoadConfig();
            config.AppSettings.Settings["lastchecked"].Value = playerLink;

            config.Save();
        }
    }
}