using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntralismToolBox.Forms;
using IntralismToolBox.Interfaces;

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

        /// <summary>
        ///     Changes the color of windows.forms components.
        /// </summary>
        /// <param name="scheme"> <see cref="IColorScheme"/> that contains the colors of the windows.forms components. </param>
        /// <param name="form"> The windows.forms class where colors should be changed. </param>
        public static void ChangeTheme(IColorScheme scheme, Form form)
        {
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
                }
            }
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
                config.AppSettings.Settings.Add("darkmode", "true");
                config.Save();
            }
        }

        /// <summary>
        ///     Just a troll.
        /// </summary>
        /// <param name="form"> e e e e e e e e e e e e e e. </param>
        /// <returns> yes. </returns>
        public static async Task Cancer(MainForm form)
        {
            Random rd = new ();

            while (true)
            {
                SystemSounds.Beep.Play();
                form.BackColor = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                form.ForeColor = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));

                foreach (Control c in form.Controls)
                {
                    switch (c)
                    {
                        case Button:
                            c.BackColor = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                            c.ForeColor = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));

                            break;
                        case GroupBox:
                        {
                            foreach (Control cd in c.Controls)
                            {
                                if (cd is Button)
                                {
                                    cd.BackColor = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                                    cd.ForeColor = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                                }
                            }

                            break;
                        }
                    }
                }

                await Task.Delay(100);
            }
        }
    }
}