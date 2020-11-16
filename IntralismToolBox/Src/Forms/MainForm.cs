using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FFmpeg.NET;
using ManiaToIntralism.Enums;
using Newtonsoft.Json;
using static ManiaToIntralism.Functions;
using Formatting = Newtonsoft.Json.Formatting;

namespace ManiaToIntralism.Forms
{
    public partial class MainForm : Form
    {
        private readonly XmlDocument config = new XmlDocument();
        private readonly Engine ffmpeg = new Engine("ffmpeg\\bin\\ffmpeg.exe");
        private readonly Random rd = new Random();
        private ManiaMap maniaMap;
        private IntralismMap intralismMap;
        private string editorPath;
        private string maniaPath;
        private string maniaConfigPath;
        private string editorConfigPath;
        private string intralismMapPath;

        public MainForm()
        {
            CheckConfig();
            this.config.Load("config.xml");
            this.InitializeComponent();
            this.LoadConfig();
        }

        private static void CheckConfig()
        {
            if (!File.Exists("config.xml"))
            {
                XmlDocument config = new XmlDocument();

                XmlNode rootNode = config.CreateElement("config");
                config.AppendChild(rootNode);

                XmlNode nodeMania = config.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute maniaKey = config.CreateAttribute("key");
                maniaKey.Value = "maniapath";
                XmlAttribute maniaValue = config.CreateAttribute("value");
                maniaValue.Value = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\osu!\\Songs";
                nodeMania.Attributes.Append(maniaKey);
                nodeMania.Attributes.Append(maniaValue);

                XmlNode nodeEditor = config.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute editorKey = config.CreateAttribute("key");
                editorKey.Value = "editorpath";
                XmlAttribute editorValue = config.CreateAttribute("value");
                editorValue.Value = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Intralism\\Editor";
                nodeEditor.Attributes.Append(editorKey);
                nodeEditor.Attributes.Append(editorValue);

                XmlNode nodeLastPlayer = config.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute lastPlayerKey = config.CreateAttribute("key");
                lastPlayerKey.Value = "lastchecked";
                XmlAttribute lastPlayerValue = config.CreateAttribute("value");
                lastPlayerValue.Value = "https://intralism.khb-soft.ru/?player=76561198143629166";
                nodeLastPlayer.Attributes.Append(lastPlayerKey);
                nodeLastPlayer.Attributes.Append(lastPlayerValue);

                rootNode.AppendChild(nodeMania);
                rootNode.AppendChild(nodeEditor);
                rootNode.AppendChild(nodeLastPlayer);

                config.Save("config.xml");
            }
        }

        private void LoadConfig()
        {
            foreach (XmlNode node in this.config.DocumentElement)
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
                }
            }
        }

        private void ManiaMapClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            string mapPath = OpenFileAndGetName(this.maniaConfigPath);
            ManiaMap temp = new ManiaMap(mapPath);

            if (temp.Mode != Mode.Mania)
            {
                DisplayErrorMessage("This map is a {temp.Mode} map. Please select a mania map", "Error");
                return;
            }

            this.maniaMap = temp;
        }

        private void EditorFolderClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            this.editorPath = OpenFolderAndGetName(this.editorConfigPath);
        }

        private void ConvertToIntralismClicked(object sender, EventArgs e)
        {
            if (this.maniaMap == null)
            {
                DisplayErrorMessage("No mania map selected", "Error");
                return;
            }

            if (this.editorPath == null)
            {
                DisplayErrorMessage("No editor path selected", "Error");
                return;
            }

            if (!int.TryParse(this.SpeedTextBox.Text, out int speed))
            {
                speed = 25;
            }

            this.maniaMap.Speed = speed;

            StringBuilder intraFile = new StringBuilder();
            intraFile.Append("{\"configVersion\":2,\"name\":\"" + this.maniaMap.Artist + " - " + this.maniaMap.Title + " [" + this.maniaMap.Version
                             + "]\",\"info\":\"Mania map convert: https://osu.ppy.sh/beatmapsets/" + this.maniaMap.BeatmapsetId
                             + "/discussion/" + this.maniaMap.BeatmapId + " by " + this.maniaMap.Creator
                             + "\",\"levelResources\":[{\"name\":\"bg1\",\"type\":\"Sprite\","
                             + "\"path\":\"background.png\"}],\"tags\":[\"OneHand\"],\"handCount\":1,"
                             + "\"moreInfoURL\":\"\",\"speed\":" + this.maniaMap.Speed + ",\"lives\":" + this.maniaMap.Lives 
                             + ",\"maxLives\":" + this.maniaMap.Lives + ",\"musicFile\":\"music.ogg\",\"musicTime\":" + this.maniaMap.Length
                             + ",\"iconFile\":\"background.png\",\"environmentType\":1,\"unlockConditions\":[],"
                             + "\"hidden\":false,\"checkpoints\":[],\"events\":[{\"time\":0.0,"
                             + "\"data\":[\"SetBGColor\",\"0,0,0,2\"]},{\"time\":0.0,\"data\":[\"SetSpeed\",\"" + this.maniaMap.Speed
                             + "\"]},{\"time\":0.0,\"data\":[\"ShowSprite\",\"bg1,0,True,0,0,0\"]}");

            foreach (HitObject x in this.maniaMap.Arcs)
            {
                double time = x.Timing / 1000;
                intraFile.Append(",{\"time\":" + time + ",\"data\":[\"SpawnObj\",\"[" + x.Position + "],0\"]}");
            }

            intraFile.Append("]}");

            string newFolder = this.editorPath + "\\" + this.maniaMap.Artist + " - " + this.maniaMap.Title;

            while (Directory.Exists(newFolder))
            {
                newFolder += this.rd.Next(0, 9);
            }

            Directory.CreateDirectory(newFolder);

            File.Copy(this.maniaMap.Folder + "\\" + this.maniaMap.Background, newFolder + "\\background.png");

            File.WriteAllText(newFolder + "\\config.txt", intraFile.ToString());

            Task.Run(async () =>
                await this.ffmpeg.ConvertAsync(
                    new MediaFile(this.maniaMap.Folder + "\\" + this.maniaMap.Audio),
                    new MediaFile(newFolder + "\\music.ogg")));

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
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            string lastChecked = string.Empty;

            foreach (XmlNode node in config.DocumentElement)
            {
                switch (node.Attributes[0].Value)
                {
                    case "lastchecked":
                        lastChecked = node.Attributes[1].Value;
                        break;
                }
            }

            CheckPlayer(lastChecked);
        }

        private void PlayerListClicked(object sender, EventArgs e)
        {
            Form playerList = new PlayerListForm();
            playerList.Show();
        }

        private void IntralismMapClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            this.intralismMapPath = OpenFolderAndGetName(this.editorConfigPath);
            string configPath = this.intralismMapPath + @"\config.txt";

            if (!File.Exists(configPath) | string.IsNullOrEmpty(File.ReadAllText(configPath)))
            {
                DisplayErrorMessage("There is no map in this folder", @"Error");
                return;
            }

            this.intralismMap = IntralismMap.FromJson(this.intralismMapPath);
        }

        private void ManiaFolderClicked(object sender, EventArgs e)
        {
            this.LoadConfig();

            this.maniaPath = OpenFolderAndGetName(this.maniaConfigPath);
        }

        private void ConvertToManiaClicked(object sender, EventArgs e)
        {
            if (this.intralismMap == null)
            {
                DisplayErrorMessage("No intralism map selected", "Error");
                return;
            }

            if (this.maniaPath == null)
            {
                DisplayErrorMessage("No mania path selected", "Error");
                return;
            }

            string artist = "Intralism";
            string title = this.intralismMap.Name;

            if (!int.TryParse(this.OffsetTextBox.Text, out int offset))
            {
                offset = 40;
            }

            if (this.intralismMap.Name.Contains("-"))
            {
                artist = this.intralismMap.Name.Substring(0, this.intralismMap.Name.IndexOf("-", StringComparison.Ordinal));
                title = this.intralismMap.Name.Substring(
                    this.intralismMap.Name.IndexOf("-", StringComparison.Ordinal),
                    this.intralismMap.Name.Length - this.intralismMap.Name.IndexOf("-", StringComparison.Ordinal)).TrimStart('-');
            }

            StringBuilder sb = ConvertIntralismToMania(this.intralismMap, artist, title);

            foreach (Event ev in this.intralismMap.Events.Where(i => i.Data[0].Contains("SpawnObj")))
            {
                string rawArcs = ev.Data[1].Split(",")[0].TrimStart('[').TrimEnd(']');
                List<string> arcs = rawArcs.Split("-").ToList();
                int time = (int)TimeSpan.FromSeconds(ev.Time).TotalMilliseconds - offset;

                foreach (string arc in arcs)
                {
                    sb.AppendLine($"{(int)Enum.Parse(typeof(Position), arc)},192,{time},1,0,0:0:0:0:");
                }
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

            File.Copy(
                this.intralismMapPath + "\\" + this.intralismMap.IconFile,
                newFolder + "\\" + this.intralismMap.IconFile);

            File.WriteAllText(newFolder + "\\" +  this.intralismMap.Name + ".osu", sb.ToString());

            File.Copy(
                this.intralismMapPath + "\\" + this.intralismMap.MusicFile,
                newFolder + "\\" + this.intralismMap.MusicFile);

            MessageBox.Show(
                @"Successfully Converted",
                @"Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// just a button action event to try stuff out so you can just ignore this, it will be removed later
        /// </summary>
        private void TestButtonClicked(object sender, EventArgs e)
        {
            IntralismMap testMap = IntralismMap.FromJson(this.editorConfigPath + "\\seiyrubluedragon");

            // testMap.EventsToBetterEvents();
            testMap.SortEvents();

            foreach (Event ev in testMap.Events.Where(x => x.Data[0] != "SpawnObj"))
            {
                Console.WriteLine(JsonConvert.SerializeObject(ev, Formatting.Indented));
            }
        }
    }
}