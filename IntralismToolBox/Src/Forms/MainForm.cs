using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IntralismManiaConverter;
using IntralismManiaConverter.Intralism;
using IntralismManiaConverter.Mania;
using IntralismToolBox.ColorSchemes;
using Octokit;
using OsuParsers.Enums;
using static IntralismToolBox.Functions;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when the program was started.
    /// </summary>
    public partial class MainForm : Form
    {
        private const string CurrentVersion = "v1.2";
        private readonly Random rd = new ();
        private string editorConfigPath;
        private string editorPath;
        private string intralismMapPath;
        private string lastCheckedLink;
        private string maniaConfigPath;
        private string maniaMapPath;
        private string maniaPath;
        private string audioConfigPath;
        private string audioPath;
        private string audioOutputPath;
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
                    ChangeTheme(new DarkColorScheme(), this);

                    break;
                case "false":
                    ChangeTheme(new LightColorScheme(), this);

                    break;
            }
        }

        private static void CheckForUpdate()
        {
            GitHubClient client = new (new ProductHeaderValue("intralism-tool-collection"));
            Release release = client.Repository.Release.GetLatest("Ludeo", "intralism-tool-collection").Result;

            if (!release.TagName.Equals(CurrentVersion))
            {
                UpdateForm updateForm = new (release);
                updateForm.ShowDialog();
            }
        }

        private void LoadConfig()
        {
            Configuration config = Functions.LoadConfig();

            this.maniaConfigPath = config.AppSettings.Settings["maniapath"].Value;
            this.editorConfigPath = config.AppSettings.Settings["editorpath"].Value;
            this.audioConfigPath = config.AppSettings.Settings["audiopath"].Value;
            this.lastCheckedLink = config.AppSettings.Settings["lastchecked"].Value;
        }

        private void ManiaMapClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            string mapPath = OpenFileAndGetName(this.maniaConfigPath);

            if (string.IsNullOrEmpty(mapPath))
            {
                return;
            }

            ManiaBeatMap temp = new (mapPath);

            if (temp.GeneralSection.Mode != Ruleset.Mania)
            {
                DisplayErrorMessage($"This map is a {temp.GeneralSection.Mode} map. Please select a mania map", "Error");

                return;
            }

            if (Math.Abs(temp.DifficultySection.CircleSize - 4) > float.Epsilon)
            {
                DisplayErrorMessage(
                    $"This mania map is a {temp.DifficultySection.CircleSize} key map. Please select a mania map with 4 keys",
                    "Error");

                return;
            }

            this.maniaMapPath = mapPath;
        }

        private void EditorFolderClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            this.editorPath = OpenFolderAndGetName(this.editorConfigPath);
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

            if (!int.TryParse(this.SpeedTextBox.Text, out int speed))
            {
                speed = 25;
            }

            // TODO add speed attribute to Converter.ConvertManiaToIntralism(pathToBeatmapFile, outputFolder, speed)
            ManiaBeatMap temp = new (this.maniaMapPath);

            string newFolder = this.editorPath + "\\" + temp.MetadataSection.Artist + " - " + temp.MetadataSection.Title;

            while (Directory.Exists(newFolder))
            {
                newFolder += this.rd.Next(0, 9);
            }

            Directory.CreateDirectory(newFolder);

            await Converter.AsyncConvertManiaToIntralism(this.maniaMapPath, newFolder);

            MessageBox.Show(
                @"Successfully Converted",
                @"Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OpenSetting(object sender, EventArgs e)
        {
            Form setting = new SettingsForm();
            setting.ShowDialog();
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            string playerLink = this.PlayerLinkTextBox.Text;
            CheckPlayer(playerLink);
        }

        private void LastCheckedClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            CheckPlayer(this.lastCheckedLink);
        }

        private void PlayerListClicked(object sender, EventArgs e)
        {
            Form playerList = new PlayerListForm();
            playerList.Show();
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

        private void ManiaFolderClicked(object sender, EventArgs e)
        {
            this.LoadConfig();
            this.maniaPath = OpenFolderAndGetName(this.maniaConfigPath);
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

            IntralismBeatMap temp = new (this.intralismMapPath);

            string artist = "Intralism";
            string title = temp.Name;

            if (!int.TryParse(this.OffsetTextBox.Text, out int offset))
            {
                offset = 40;
            }

            // TODO add offset attribute to Converter.ConvertIntralismToMania(pathToBeatmapFile, outputFolder, offset)
            if (temp.Name.Contains("-"))
            {
                artist = temp.Name.Substring(0, temp.Name.IndexOf("-", StringComparison.Ordinal));

                title = temp.Name.Substring(
                    temp.Name.IndexOf("-", StringComparison.Ordinal),
                    temp.Name.Length - temp.Name.IndexOf("-", StringComparison.Ordinal)).TrimStart('-');
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

            await Converter.AsyncConvertIntralismToMania(this.intralismMapPath, newFolder);

            MessageBox.Show(
                @"Successfully Converted",
                @"Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ReportBugButtonClicked(object sender, EventArgs e) =>
            Process.Start(
                new ProcessStartInfo("cmd", $"/c start https://github.com/Ludeo/intralism-tool-collection/issues")
                {
                    CreateNoWindow = true,
                });

        private void TestButtonClicked(object sender, EventArgs e)
        {
            // IntralismMap testMap = IntralismMap.FromJson(this.editorConfigPath + "\\seiyrubluedragon");

            // testMap.EventsToBetterEvents();
            // testMap.SortEvents();

            // foreach (Event ev in testMap.Events.Where(x => x.Data[0] != "SpawnObj"))
            // {
            // Console.WriteLine(JsonConvert.SerializeObject(ev, Formatting.Indented));
            // }
            Cancer(this).Start();
            this.TestButtonClicked(sender, e);
        }

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

            MessageBox.Show(
                @"Successfully Converted",
                @"Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

        private void ChangeSpeedClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.speedChangerPath))
            {
                DisplayErrorMessage("No config file selected.", "Error");

                return;
            }

            IntralismBeatMap map = new (this.speedChangerPath);

            if (!map.Events!.Any(x => x.Data[0].Contains("SpawnObj")))
            {
                DisplayErrorMessage("Can't change speed on this map.", "Error");

                return;
            }

            if (this.SpeedCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(this.EachSpeedTextBox.Text) || !int.TryParse(this.EachSpeedTextBox.Text, out int speed))
                {
                    DisplayErrorMessage("No speed selected.", "Error");

                    return;
                }

                Console.WriteLine(speed);
            }
            else
            {
                if (string.IsNullOrEmpty(this.AllSpeedTextBox.Text) || !int.TryParse(this.AllSpeedTextBox.Text, out int speed))
                {
                    DisplayErrorMessage("No speed selected.", "Error");

                    return;
                }

                Console.WriteLine(speed);
            }
        }
    }
}