using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using IntralismManiaConverter;
using IntralismManiaConverter.Intralism;
using IntralismManiaConverter.Mania;
using OsuParsers.Enums;
using static IntralismToolBox.Functions;

namespace IntralismToolBox.Forms
{
    public partial class MainForm : Form
    {
        private readonly Random rd = new ();
        private string editorConfigPath;
        private string editorPath;
        private string intralismMapPath;
        private string lastCheckedLink;
        private string maniaConfigPath;
        private string maniaMapPath;
        private string maniaPath;

        public MainForm()
        {
            this.CheckConfig();
            this.InitializeComponent();
            this.LoadConfig();
        }

        private void CheckConfig()
        {
            if (!File.Exists("config.xml"))
            {
                XmlDocument newConfig = new ();

                XmlNode rootNode = newConfig.CreateElement("config");
                newConfig.AppendChild(rootNode);

                XmlNode nodeMania = newConfig.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute maniaKey = newConfig.CreateAttribute("key");
                maniaKey.Value = "maniapath";
                XmlAttribute maniaValue = newConfig.CreateAttribute("value");
                maniaValue.Value = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\osu!\\Songs";
                nodeMania.Attributes.Append(maniaKey);
                nodeMania.Attributes.Append(maniaValue);

                XmlNode nodeEditor = newConfig.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute editorKey = newConfig.CreateAttribute("key");
                editorKey.Value = "editorpath";
                XmlAttribute editorValue = newConfig.CreateAttribute("value");
                editorValue.Value = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Intralism\\Editor";
                nodeEditor.Attributes.Append(editorKey);
                nodeEditor.Attributes.Append(editorValue);

                XmlNode nodeLastPlayer = newConfig.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute lastPlayerKey = newConfig.CreateAttribute("key");
                lastPlayerKey.Value = "lastchecked";
                XmlAttribute lastPlayerValue = newConfig.CreateAttribute("value");
                lastPlayerValue.Value = "https://intralism.khb-soft.ru/?player=76561198143629166";
                nodeLastPlayer.Attributes.Append(lastPlayerKey);
                nodeLastPlayer.Attributes.Append(lastPlayerValue);

                rootNode.AppendChild(nodeMania);
                rootNode.AppendChild(nodeEditor);
                rootNode.AppendChild(nodeLastPlayer);

                newConfig.Save("config.xml");
            }
        }

        private void LoadConfig()
        {
            XmlDocument newConfig = new ();
            newConfig.Load("config.xml");

            foreach (XmlNode node in newConfig.DocumentElement)
            {
                string firstValue = node.Attributes[0].Value;
                string secondValue = node.Attributes[1].Value;

                switch (firstValue)
                {
                    case "maniapath":
                        this.maniaConfigPath = secondValue;

                        break;
                    case "editorpath":
                        this.editorConfigPath = secondValue;

                        break;
                    case "lastchecked":
                        this.lastCheckedLink = secondValue;

                        break;
                }
            }
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

        /// <summary>
        ///     just a button action event to try stuff out so you can just ignore this, it will be removed later.
        /// </summary>
        private void TestButtonClicked(object sender, EventArgs e)
        {
            //IntralismMap testMap = IntralismMap.FromJson(this.editorConfigPath + "\\seiyrubluedragon");

            // testMap.EventsToBetterEvents();
            //testMap.SortEvents();

            //foreach (Event ev in testMap.Events.Where(x => x.Data[0] != "SpawnObj"))
            //{
            //Console.WriteLine(JsonConvert.SerializeObject(ev, Formatting.Indented));
            //}
        }
    }
}