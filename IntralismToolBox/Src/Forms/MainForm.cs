﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using IntralismManiaConverter;
using IntralismManiaConverter.Intralism;
using IntralismManiaConverter.Mania;
using Newtonsoft.Json;
using Octokit;
using OsuParsers.Enums;
using static IntralismToolBox.Functions;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when the program was started.
    /// </summary>
    public partial class MainForm : ThemedForm
    {
        private const string CurrentVersion = "v1.4.2";
        private readonly Random rd = new();
        private string audioConfigPath;
        private string audioOutputPath;
        private string audioPath;
        private string editorConfigPath;
        private string editorPath;
        private string intralismMapPath;
        private string lastCheckedLink;
        private string maniaConfigPath;
        private string maniaMapPath;
        private string maniaPath;
        private string speedChangerPath;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            Functions.LoadConfig();
            this.InitializeComponent();
            this.ReloadTheme();
            CheckForUpdate();
            this.CheckScoreCsvExist();
        }

        private void ChangeSpeedClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.speedChangerPath))
            {
                DisplayErrorMessage("No config file selected.", "Error");

                return;
            }

            IntralismBeatMap map = new(this.speedChangerPath);

            if (!map.Events!.Any(x => x.Data[0].Contains("SpawnObj")))
            {
                DisplayErrorMessage("Can't change speed on this map.", "Error");

                return;
            }

            if (this.SpeedCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(this.EachSpeedTextBox.Text) ||
                    !int.TryParse(this.EachSpeedTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int speed))
                {
                    DisplayErrorMessage("No speed selected.", "Error");

                    return;
                }

                foreach (Event ev in map.Events)
                {
                    if (ev.Data[0].Equals("SetSpeed"))
                    {
                        int newSpeed = int.Parse(ev.Data[1]!, NumberStyles.Integer, CultureInfo.InvariantCulture) + speed;
                        ev.Data[1] = newSpeed.ToString();
                    }
                }

                double newBaseSpeed = map.Speed + speed;
                map.Speed = newBaseSpeed;
            }
            else
            {
                if (string.IsNullOrEmpty(this.AllSpeedTextBox.Text) ||
                    !int.TryParse(this.AllSpeedTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int speed))
                {
                    DisplayErrorMessage("No speed selected.", "Error");

                    return;
                }

                foreach (Event ev in map.Events)
                {
                    if (ev.Data[0].Equals("SetSpeed"))
                    {
                        ev.Data[1] = speed.ToString();
                    }
                }

                map.Speed = speed;
            }

            map.SaveToFile(this.speedChangerPath);

            MessageBox.Show(@"Speed successfully changed.",
                            @"Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            string playerLink = this.PlayerLinkTextBox.Text;

            if (this.CheckRankCheckBox.Checked)
            {
                if (int.TryParse(playerLink, NumberStyles.Integer, CultureInfo.InvariantCulture, out int rank))
                {
                    CheckPlayerByRank(rank);
                }
                else
                {
                    DisplayErrorMessage("The entered rank is not valid.", "Error");
                }
            }
            else
            {
                if (playerLink.StartsWith("https://intralism.khb-soft.ru/?player="))
                {
                    CheckPlayer(playerLink);
                }
                else
                {
                    CheckPlayerWithSearch(playerLink);
                }
            }
        }

        private static void CheckForUpdate()
        {
            GitHubClient client = new(new ProductHeaderValue("intralism-tool-collection"));
            Release release = client.Repository.Release.GetLatest("Ludeo", "intralism-tool-collection").Result;

            if (!release.TagName.Equals(CurrentVersion))
            {
                UpdateForm updateForm = new(release);
                updateForm.Show();
            }
        }

        private void CheckScoreCsvExist()
        {
            if (!File.Exists("scores.csv"))
            {
                this.UpdateCsvClicked(this, new EventArgs());
            }
        }

        private void ConvertAudioClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.audioPath))
            {
                DisplayErrorMessage("No audio selected", "Error");

                return;
            }

            if (string.IsNullOrEmpty(this.audioOutputPath))
            {
                DisplayErrorMessage("No output path selected", "Error");

                return;
            }

            AudioFileHelper.AsyncSaveAudio(this.audioPath, this.audioOutputPath + "/");

            MessageBox.Show(@"Successfully Converted",
                            @"Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private async void ConvertToIntralismClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.maniaMapPath))
            {
                DisplayErrorMessage("No mania map selected", "Error");

                return;
            }

            if (string.IsNullOrEmpty(this.editorPath))
            {
                DisplayErrorMessage("No editor path selected", "Error");

                return;
            }

            if (!int.TryParse(this.SpeedTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int speed))
            {
                speed = 25;
            }

            ManiaBeatMap temp = new(this.maniaMapPath);

            string newFolder = this.editorPath + "\\" + temp.MetadataSection.Artist + " - " + temp.MetadataSection.Title;

            while (Directory.Exists(newFolder))
            {
                newFolder += this.rd.Next(0, 9);
            }

            Directory.CreateDirectory(newFolder);

            await Converter.AsyncConvertManiaToIntralism(this.maniaMapPath, newFolder, speed);

            MessageBox.Show(@"Successfully Converted",
                            @"Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private async void ConvertToManiaClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.intralismMapPath))
            {
                DisplayErrorMessage("No intralism map selected", "Error");

                return;
            }

            if (string.IsNullOrEmpty(this.maniaPath))
            {
                DisplayErrorMessage("No mania path selected", "Error");

                return;
            }

            IntralismBeatMap temp = new(this.intralismMapPath);

            string artist = "Intralism";
            string title = temp.Name;

            if (!int.TryParse(this.OffsetTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int offset))
            {
                offset = 40;
            }

            if (temp.Name.Contains("-"))
            {
                artist = temp.Name[..temp.Name.IndexOf("-", StringComparison.InvariantCulture)];

                title = temp.Name.Substring(temp.Name.IndexOf("-", StringComparison.InvariantCulture),
                                            temp.Name.Length - temp.Name.IndexOf("-", StringComparison.InvariantCulture)).TrimStart('-');
            }

            if (!Directory.Exists(this.maniaPath + "\\intralismconverts\\"))
            {
                Directory.CreateDirectory(this.maniaPath + "\\intralismconverts\\");
            }

            string newFolder = this.maniaPath + "\\intralismconverts\\" + artist + " - " + title;

            while (Directory.Exists(newFolder))
            {
                newFolder += this.rd.Next(0, 9);
            }

            Directory.CreateDirectory(newFolder);

            await Converter.AsyncConvertIntralismToMania(this.intralismMapPath, newFolder, offset);

            MessageBox.Show(@"Successfully Converted",
                            @"Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void EditorFolderClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            this.editorPath = OpenFolderAndGetName(this.editorConfigPath);
        }

        private void IntralismMapClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            this.intralismMapPath = OpenFileAndGetName(this.editorConfigPath);

            if (string.IsNullOrEmpty(this.intralismMapPath))
            {
                return;
            }

            if (string.IsNullOrEmpty(File.ReadAllText(this.intralismMapPath)))
            {
                DisplayErrorMessage("There is no map in this folder", @"Error");
                this.intralismMapPath = string.Empty;
            }
        }

        private void LastCheckedClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            CheckPlayer(this.lastCheckedLink);
        }

        private void LoadConfig()
        {
            Configuration config = Functions.LoadConfig();

            this.maniaConfigPath = config.AppSettings.Settings["maniapath"].Value;
            this.editorConfigPath = config.AppSettings.Settings["editorpath"].Value;
            this.audioConfigPath = config.AppSettings.Settings["audiopath"].Value;
            this.lastCheckedLink = config.AppSettings.Settings["lastchecked"].Value;
        }

        private void ManiaFolderClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            this.maniaPath = OpenFolderAndGetName(this.maniaConfigPath);
        }

        private void ManiaMapClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            string mapPath = OpenFileAndGetName(this.maniaConfigPath);

            if (string.IsNullOrEmpty(mapPath))
            {
                return;
            }

            ManiaBeatMap temp = new(mapPath);

            if (temp.GeneralSection.Mode != Ruleset.Mania)
            {
                DisplayErrorMessage($"This map is a {temp.GeneralSection.Mode} map. Please select a mania map", "Error");

                return;
            }

            if (Math.Abs(temp.DifficultySection.CircleSize - 4) > float.Epsilon)
            {
                DisplayErrorMessage($"This mania map is a {temp.DifficultySection.CircleSize} key map. Please select a mania map with 4 keys",
                                    "Error");

                return;
            }

            this.maniaMapPath = mapPath;
        }

        private void MapEditorClicked(object sender, EventArgs e)
        {
            MapEditorForm editor = new(this.editorConfigPath);
            editor.ShowDialog();
        }

        private void OpenSetting(object sender, EventArgs e)
        {
            SettingsForm setting = new();
            setting.ShowDialog();
        }

        private void PlayerListClicked(object sender, EventArgs e)
        {
            PlayerListForm playerList = new();
            playerList.Show();
        }

        private void ReportBugButtonClicked(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo("cmd", "/c start https://github.com/Ludeo/intralism-tool-collection/issues")
            {
                CreateNoWindow = true,
            });

        private void SelectAudioClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            this.audioPath = OpenFileAndGetName(this.audioConfigPath);
        }

        private void SelectAudioOutputClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            this.audioOutputPath = OpenFolderAndGetName(this.audioConfigPath);
        }

        private void SelectSpeedChangerConfigClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            this.speedChangerPath = OpenFileAndGetName(this.editorConfigPath);
        }

        private void SpeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SpeedCheckBox.Checked)
            {
                this.EachSpeedTextBox.Enabled = true;
                this.AllSpeedTextBox.Enabled = false;
            }
            else
            {
                this.EachSpeedTextBox.Enabled = false;
                this.AllSpeedTextBox.Enabled = true;
            }
        }

        private void StatisticsClicked(object sender, EventArgs e)
        {
            if (!File.Exists("playerdatabase.json"))
            {
                DisplayErrorMessage("No player got checked yet.", "Error");

                return;
            }

            StatisticsPlayerListForm statisticsPlayerListForm = new();
            statisticsPlayerListForm.Show();
        }

        private void TestButtonClicked(object sender, EventArgs e)
        {
            // IntralismMap testMap = IntralismMap.FromJson(this.editorConfigPath + "\\seiyrubluedragon");

            // testMap.EventsToBetterEvents();
            // testMap.SortEvents();

            // foreach (Event ev in testMap.Events.Where(x => x.Data[0] != "SpawnObj"))
            // {
            // Console.WriteLine(JsonConvert.SerializeObject(ev, Formatting.Indented));
            // }
            List<IntralismScoreChecker.Player> players =
                JsonConvert.DeserializeObject<List<IntralismScoreChecker.Player>>(File.ReadAllText("old_playerdatabase.json"));

            string uncompressedFile = JsonConvert.SerializeObject(players);
            byte[] compressedFile = Compressor.Zip(uncompressedFile);
            File.WriteAllBytes("playerdatabase.json", compressedFile!);
        }

        private void UpdateCsvClicked(object sender, EventArgs e)
        {
            WebClient client = new();
            string scoreCsvRaw = client.DownloadString("https://pastebin.com/raw/2cFCax2g");
            File.WriteAllText("scores.csv", scoreCsvRaw);
        }

        private void StoryboardAssistantClicked(object sender, EventArgs e)
        {
            StoryboardAssistantForm storyboardAssistantForm = new();
            storyboardAssistantForm.Show();
        }
    }
}