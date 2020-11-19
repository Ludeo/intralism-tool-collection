using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IntralismToolBox.Forms;

namespace IntralismToolBox
{
    /// <summary>
    ///     Class that contains helper functions.
    /// </summary>
    public static class Functions
    {
        /// <summary>
        ///     Function that creates a new instance of <see cref="IntralismScoreChecker.Player"/> and opens a <see cref="UserProfileForm"/>
        ///     and a <see cref="UserScoreForm"/> with the details of the player.
        /// </summary>
        /// <param name="link"> Link to the intralism player. </param>
        public static void CheckPlayer(string link)
        {
            IntralismScoreChecker.Player newPlayer = new　(link);

            UserProfileForm profileUserProfileForm = new　(
                newPlayer.GlobalRank,
                newPlayer.TotalGlobalRank,
                newPlayer.Country,
                newPlayer.CountryRank,
                newPlayer.TotalCountryRank,
                newPlayer.AverageMisses,
                newPlayer.AverageAccuracy,
                newPlayer.Points,
                newPlayer.RealPoints,
                newPlayer.MaximumPoints,
                newPlayer.Difference,
                newPlayer.HundredPlays,
                newPlayer.TotalMaps,
                newPlayer.RankUpPoints,
                newPlayer.PictureLink,
                newPlayer.Name);

            profileUserProfileForm.Show();

            UserScoreForm userScore = new　(newPlayer.Scores, newPlayer.Name);
            userScore.Show();

            SaveLastChecked(link);
        }

        /// <summary>
        ///     Opens a file dialog.
        /// </summary>
        /// <param name="initialDirectory"> Directory that get opens when the file dialog shows up. </param>
        /// <param name="filter"> Filter for the selected files. </param>
        /// <returns> The name of the selected file. </returns>
        public static string OpenFileAndGetName(string initialDirectory, string filter = "")
        {
            OpenFileDialog fileDialog = new ()
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
            FolderBrowserDialog folderDialog = new ()
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

        /// <summary>
        ///     Loads the config.xml file.
        /// </summary>
        /// <returns> A Configuration object with the data of the config.xml file. </returns>
        public static Configuration LoadConfig()
        {
            CheckConfig();
            ExeConfigurationFileMap configMap = new ();
            configMap.ExeConfigFilename = @"config.xml";
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

            return config;
        }

        private static void SaveLastChecked(string playerLink)
        {
            Configuration config = LoadConfig();
            config.AppSettings.Settings["lastchecked"].Value = playerLink;

            config.Save();
        }

        private static void CheckConfig()
        {
            if (!File.Exists("config.xml"))
            {
                StringBuilder sb = new ();
                sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sb.AppendLine("<configuration xmlns=\"http://schemas.microsoft.com/.NetConfiguration/v2.0\"></configuration>");
                File.WriteAllText(@"config.xml", sb.ToString());

                ExeConfigurationFileMap configMap = new ();
                configMap.ExeConfigFilename = @"config.xml";
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                config.AppSettings.Settings.Add("maniapath", $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\osu!\\Songs");
                config.AppSettings.Settings.Add("editorpath", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Intralism\\Editor");
                config.AppSettings.Settings.Add("lastchecked", "https://intralism.khb-soft.ru/?player=76561198143629166");
                config.Save();
            }
        }
    }
}