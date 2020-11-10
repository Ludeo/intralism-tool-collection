using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FFmpeg.NET;
using Microsoft.WindowsAPICodePack.Dialogs;
using static ManiaToIntralism.Functions;

namespace ManiaToIntralism.Forms
{
    public partial class Form1 : Form
    {
        private ManiaMap map;
        private string editorPath;
        private string maniaConfigPath;
        private string editorConfigPath;
        private readonly Engine ffmpeg = new Engine("FFmpeg.NET.dll");
        
        public Form1()
        {
            this.InitializeComponent();
            CheckConfig();
            this.LoadConfig();
        }

        private static void CheckConfig()
        {
            if (!File.Exists("config.xml"))
            {
                XmlDocument config = new XmlDocument();
                //TODO
                //add maniapath
                //add editorpath
                config.Save("config.xml");
            }
        }

        private void LoadConfig()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                string nodeAttributeValue = node.Attributes[1].Value;

                switch (node.Attributes[0].Value)
                {
                    case "maniapath":
                        this.maniaConfigPath = nodeAttributeValue;
                        break;
                    case "editorpath":
                        this.editorConfigPath = nodeAttributeValue;
                        break;
                }
            }
        }
        
        private void ManiaClicked(object sender, EventArgs e)
        {
            OpenFileDialog maniaDialog = new OpenFileDialog
            {
                InitialDirectory = this.maniaConfigPath,
                Filter = @"osu! files (*.osu)|*.osu",
            };
            maniaDialog.ShowDialog();

            if (maniaDialog.FileName != "")
            {
                string maniaMap = maniaDialog.FileName;

                ManiaMap temp = new ManiaMap(maniaMap);

                if (temp.Mode != Mode.Mania)
                {
                    MessageBox.Show(
                        $@"This map is a {temp.Mode} map. Please select a mania map",
                        @"Error", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                this.map = temp;
            }
        }

        private void EditorClicked(object sender, EventArgs e)
        {
            CommonOpenFileDialog editorDialog = new CommonOpenFileDialog
            {
                InitialDirectory = this.editorConfigPath,
                IsFolderPicker = true,
            };
            editorDialog.ShowDialog();

            this.editorPath = editorDialog.FileName;
        }

        private void ConvertClicked(object sender, EventArgs e)
        {
            if(this.map == null) {
                MessageBox.Show(@"No mania map selected", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.editorPath == null)
            {
                MessageBox.Show(@"No editor path selected", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(this.speedbox.Text, out int speed))
            {
                speed = 25;
            }

            this.map.Speed = speed;

            StringBuilder intraFile = new StringBuilder();
            intraFile.Append("{\"configVersion\":2,\"name\":\"" + this.map.Artist + " - " + this.map.Title + " [" + this.map.Version
                           + "]\",\"info\":\"Mania map convert: https://osu.ppy.sh/beatmapsets/" + this.map.BeatmapsetId
                           + "/discussion/" + this.map.BeatmapId + " by " + this.map.Creator
                           + "\",\"levelResources\":[{\"name\":\"bg1\",\"type\":\"Sprite\","
                           + "\"path\":\"background.png\"}],\"tags\":[\"OneHand\"],\"handCount\":1,"
                           + "\"moreInfoURL\":\"\",\"speed\":" + this.map.Speed + ",\"lives\":" + this.map.Lives 
                           + ",\"maxLives\":" + this.map.Lives + ",\"musicFile\":\"music.ogg\",\"musicTime\":" + this.map.Length
                           + ",\"iconFile\":\"background.png\",\"environmentType\":1,\"unlockConditions\":[],"
                           + "\"hidden\":false,\"checkpoints\":[],\"events\":[{\"time\":0.0,"
                           + "\"data\":[\"SetBGColor\",\"0,0,0,2\"]},{\"time\":0.0,\"data\":[\"SetSpeed\",\"" + this.map.Speed
                           + "\"]},{\"time\":0.0,\"data\":[\"ShowSprite\",\"bg1,0,True,0,0,0\"]}");

            foreach (HitObject x in this.map.Arcs)
            {
                double time = x.Timing / 1000;
                intraFile.Append(",{\"time\":" + time + ",\"data\":[\"SpawnObj\",\"[" + x.Position + "],0\"]}");
            }

            intraFile.Append("]}");
            
            string newFolder = this.editorPath + "\\" + this.map.Artist + " - " + this.map.Title;
            
            Random rd = new Random();
            while (Directory.Exists(newFolder))
            {
                newFolder += rd.Next(0, 9);
            }
            
            Directory.CreateDirectory(newFolder);

            File.Copy(this.map.Folder + "\\" + this.map.Background, newFolder + "\\background.png");
            
            File.WriteAllText(newFolder + "\\config.txt", intraFile.ToString());

            this.ffmpeg.ConvertAsync(new MediaFile(this.map.Folder + "\\" + this.map.Audio),
                                      new MediaFile(newFolder + "\\music.ogg"));
            
            MessageBox.Show(@"Successfully Converted", @"Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenSetting(object sender, EventArgs e)
        {
            Form setting = new FormSetting();
            setting.ShowDialog();
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            string playerLink = this.playerLinkText.Text;
            CheckPlayer(playerLink);
            SaveLastChecked(playerLink);
        }

        private void LastCheckedClicked(object sender, EventArgs e)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            string lastChecked = "";

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
            throw new NotImplementedException();
        }
        
    }
}