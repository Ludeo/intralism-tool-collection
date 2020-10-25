using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FFmpeg.NET;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ManiaToIntralism.Forms
{
    public partial class Form1 : Form
    {
        private ManiaMap _map;
        private string _editorPath;
        private string _maniaConfigPath;
        private string _editorConfigPath;
        private readonly Engine _ffmpeg = new Engine("FFmpeg.NET.dll");
        
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
                        this._maniaConfigPath = nodeAttributeValue;
                        break;
                    case "editorpath":
                        this._editorConfigPath = nodeAttributeValue;
                        break;
                }
            }
        }
        
        private void ManiaClicked(object sender, EventArgs e)
        {
            OpenFileDialog maniaDialog = new OpenFileDialog
            {
                InitialDirectory = this._maniaConfigPath,
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

                this._map = temp;
            }
        }

        private void EditorClicked(object sender, EventArgs e)
        {
            CommonOpenFileDialog editorDialog = new CommonOpenFileDialog
            {
                InitialDirectory = this._editorConfigPath,
                IsFolderPicker = true,
            };
            editorDialog.ShowDialog();

            this._editorPath = editorDialog.FileName;
        }

        private void ConvertClicked(object sender, EventArgs e)
        {
            if(this._map == null) {
                MessageBox.Show(@"No mania map selected", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this._editorPath == null)
            {
                MessageBox.Show(@"No editor path selected", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(this.speedbox.Text, out int speed))
            {
                speed = 25;
            }

            this._map.Speed = speed;

            StringBuilder intraFile = new StringBuilder();
            intraFile.Append("{\"configVersion\":2,\"name\":\"" + this._map.Artist + " - " + this._map.Title + " [" + this._map.Version
                           + "]\",\"info\":\"Mania map convert: https://osu.ppy.sh/beatmapsets/" + this._map.BeatmapsetId
                           + "/discussion/" + this._map.BeatmapId + " by " + this._map.Creator
                           + "\",\"levelResources\":[{\"name\":\"bg1\",\"type\":\"Sprite\","
                           + "\"path\":\"background.png\"}],\"tags\":[\"OneHand\"],\"handCount\":1,"
                           + "\"moreInfoURL\":\"\",\"speed\":" + this._map.Speed + ",\"lives\":" + this._map.Lives 
                           + ",\"maxLives\":" + this._map.Lives + ",\"musicFile\":\"music.ogg\",\"musicTime\":" + this._map.Length
                           + ",\"iconFile\":\"background.png\",\"environmentType\":1,\"unlockConditions\":[],"
                           + "\"hidden\":false,\"checkpoints\":[],\"events\":[{\"time\":0.0,"
                           + "\"data\":[\"SetBGColor\",\"0,0,0,2\"]},{\"time\":0.0,\"data\":[\"SetSpeed\",\"" + this._map.Speed
                           + "\"]},{\"time\":0.0,\"data\":[\"ShowSprite\",\"bg1,0,True,0,0,0\"]}");

            foreach (HitObject x in this._map.Arcs)
            {
                double time = x.Timing / 1000;
                intraFile.Append(",{\"time\":" + time + ",\"data\":[\"SpawnObj\",\"[" + x.Position + "],0\"]}");
            }

            intraFile.Append("]}");
            
            string newFolder = this._editorPath + "\\" + this._map.Artist + " - " + this._map.Title;
            
            Random rd = new Random();
            while (Directory.Exists(newFolder))
            {
                newFolder += rd.Next(0, 9);
            }
            
            Directory.CreateDirectory(newFolder);

            File.Copy(this._map.Folder + "\\" + this._map.Background, newFolder + "\\background.png");
            
            File.WriteAllText(newFolder + "\\config.txt", intraFile.ToString());

            this._ffmpeg.ConvertAsync(new MediaFile(this._map.Folder + "\\" + this._map.Audio),
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
        }

        private void LastCheckedClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PlayerListClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void CheckPlayer(string link)
        {
            WebClient wc = new WebClient();
            string profileInfo = wc.DownloadString(link);
            
            StringReader sr = new StringReader(profileInfo);
            string line;

            string[][] mapData = CsvReader.GetCsvContent("scores.csv");
            object[][] allScores = FillAllScores(mapData);
            
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("/sharedfiles/filedetails/") && !line.Contains("Random") && !line.Contains("Hidden")
                    && !line.Contains("Endless"))
                {
                    int i = FindIForAllScores(line, mapData);

                    if (i != int.MaxValue)
                    {
                        string[] mapDetail = GetMapDetail(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                        allScores[i][1] = int.Parse(mapDetail[0]);
                        allScores[i][2] = double.Parse(mapDetail[1]);
                        allScores[i][3] = int.Parse(mapDetail[2]);
                        allScores[i][4] = double.Parse(mapDetail[3]);
                    }
                }
            }
        }

        private static object[][] FillAllScores(string[][] mapData)
        {
            object[][] allScores = new object[mapData.Length][];
            for (int i = 0; i < allScores.Length; i++)
            {
                mapData[i][0] = mapData[i][0].Replace("COMMA", ",");
                mapData[i][0] = mapData[i][0].Replace("QUOTE", "\"");
                allScores[i][0] = mapData[i][0];
                allScores[i][1] = 0;
                allScores[i][2] = 0.0;
                allScores[i][3] = 0;
                allScores[i][4] = 0.0;
                allScores[i][5] = double.Parse(mapData[i][1]);
                allScores[i][6] = 0.0;
                allScores[i][7] = mapData[i][2];
            }

            return allScores;
        }

        private static int FindIForAllScores(string line, string[][] mapData)
        {
            for (int i = 0; i < mapData.Length; i++)
            {
                if (line.Contains("id=" + mapData[i][3]))
                {
                    return i;
                }
            }

            return int.MaxValue;
        }

        private static string[] GetMapDetail(string score, string acc, string miss, string points)
        {
            string[] inputValues = {score, acc, miss, points};
            string[] outputValues = new string[4];

            for (int i = 0; i < inputValues.Length; i++)
            {
                string value = inputValues[i];
                int aNumber = value.IndexOf(">", StringComparison.Ordinal);
                int bNumber = value.IndexOf("<", aNumber, StringComparison.Ordinal);
                value = value.Substring(aNumber + 1, bNumber);

                if (i != 1)
                {
                    outputValues[i] = value.Replace("\\s+", "");
                }
                else
                {
                    value = value.Replace("\\n+", "");
                    outputValues[i] = value.Replace("%", "");
                }
            }

            return outputValues;
        }
    }
}