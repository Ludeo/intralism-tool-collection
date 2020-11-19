using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;
using IntralismScoreChecker;
using ManiaToIntralism.Forms;

namespace ManiaToIntralism
{
    public static class Functions
    {
        public static void CheckPlayer(string link)
        {
            IntralismScoreChecker.Player newPlayer = new IntralismScoreChecker.Player(link);

            UserProfileForm profileUserProfileForm = new UserProfileForm(
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

            UserScoreForm userScore = new UserScoreForm(newPlayer.Scores, newPlayer.Name);
            userScore.Show();

            SaveLastChecked(link);
        }

        private static void SaveLastChecked(string playerLink)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            string lastChecked = playerLink;

            foreach (XmlNode node in config.DocumentElement)
            {
                switch (node.Attributes[0].Value)
                {
                    case "lastchecked":
                        node.Attributes[1].Value = lastChecked;
                        break;
                }
            }

            config.Save("config.xml");
        }

        public static string OpenFileAndGetName(string initialDirectory, string filter = "")
        {
            OpenFileDialog fileDialog = new OpenFileDialog
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
        /// Opens Folder Dialogue and returns the selected path or "" if cancelled.
        /// </summary>
        /// <param name="initialDirectory">The directory to start the folder dialogue in.</param>
        /// <returns>The Selected Path or "" if cancelled.</returns>
        public static string OpenFolderAndGetName(string initialDirectory)
        {
            FolderBrowserDialog folderDialog = new ();
            folderDialog.SelectedPath = initialDirectory;

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
        /// Useful for telling the user when they're being a dumbass
        /// </summary>
        /// <param name="message">The error message, provide information that can be useful for the user.
        /// (i.e. WHY they got this message and how they can fix it).</param>
        /// <param name="title">The Title of the error box.</param>
        public static void DisplayErrorMessage(string message, string title = "You Dignus!")
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}