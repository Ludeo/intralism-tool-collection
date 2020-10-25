using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FFmpeg.NET;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace maniatointralism
{
    public partial class Form1 : Form
    {
        private ManiaMap _map;
        private string _editorpath;
        private string _maniaconfigpath;
        private string _editorconfigpath;
        private readonly Engine _ffmpeg = new Engine("ffmpeg\\bin\\ffmpeg.exe");
        
        public Form1()
        {
            InitializeComponent();
            CheckConfig();
            LoadConfig();
        }

        private static void CheckConfig()
        {
            if (File.Exists("config.xml")) return;
            
            var config = new XmlDocument();
            //TODO
            //add maniapath
            //add editorpath
            config.Save("config.xml");
        }

        private void LoadConfig()
        {
            var config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                switch (node.Attributes[0].Value)
                {
                    case "maniapath":
                        _maniaconfigpath = node.Attributes[1].Value;
                        break;
                    case "editorpath":
                        _editorconfigpath = node.Attributes[1].Value;
                        break;
                }
            }

        }
        
        private void Maniaclicked(object sender, EventArgs e)
        {

            var maniaDialog = new OpenFileDialog
            {
                InitialDirectory = _maniaconfigpath,
                Filter = @"osu! files (*.osu)|*.osu"
            };
            maniaDialog.ShowDialog();
            
            if (maniaDialog.FileName == "") return;
            
            var maniamap = maniaDialog.FileName;

            var temp = new ManiaMap(maniamap);
            if (temp.Mode != "Mania")
            {
                MessageBox.Show(@"This map is a " + temp.Mode + @" map. Please select a mania map", @"Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            
            this._map = temp;
            
        }

        private void EditorClicked(object sender, EventArgs e)
        {
            var editorDialog = new CommonOpenFileDialog
            {
                InitialDirectory = _editorconfigpath,
                IsFolderPicker = true
            };
            editorDialog.ShowDialog();

            try
            {
                _editorpath = editorDialog.FileName;
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception);
            }
            
        }

        private void ConvertClicked(object sender, EventArgs e)
        {
            if(_map == null) {
                MessageBox.Show(@"No mania map selected", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_editorpath == null)
            {
                MessageBox.Show(@"No editor path selected", @"Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _map.Speed = int.TryParse(speedbox.Text, out _) ? speedbox.Text : "25";

            var intrafl = new StringBuilder();
            intrafl.Append("{\"configVersion\":2,\"name\":\"" + _map.Artist + " - " + _map.Title + " [" + _map.Version
                           + "]\",\"info\":\"Mania map convert: https://osu.ppy.sh/beatmapsets/" + _map.Beatmapsetid
                           + "/discussion/" + _map.Beatmapid + " by " + _map.Creator
                           + "\",\"levelResources\":[{\"name\":\"bg1\",\"type\":\"Sprite\","
                           + "\"path\":\"background.png\"}],\"tags\":[\"OneHand\"],\"handCount\":1,"
                           + "\"moreInfoURL\":\"\",\"speed\":" + _map.Speed + ",\"lives\":" + _map.Lives 
                           + ",\"maxLives\":" + _map.Lives + ",\"musicFile\":\"music.ogg\",\"musicTime\":" + _map.Length
                           + ",\"iconFile\":\"background.png\",\"environmentType\":1,\"unlockConditions\":[],"
                           + "\"hidden\":false,\"checkpoints\":[],\"events\":[{\"time\":0.0,"
                           + "\"data\":[\"SetBGColor\",\"0,0,0,2\"]},{\"time\":0.0,\"data\":[\"SetSpeed\",\"" + _map
                               .Speed
                           + "\"]},{\"time\":0.0,\"data\":[\"ShowSprite\",\"bg1,0,True,0,0,0\"]}");

            foreach (var x in _map.Arcs)
            {
                var time = double.Parse(x.Timing) / 1000;
                intrafl.Append(",{\"time\":" + time + ",\"data\":[\"SpawnObj\",\"[" + x.Pos + "],0\"]}");
            }

            intrafl.Append("]}");
            
            var newfolder = _editorpath + "\\" + _map.Artist + " - "
                               + _map.Title;
            
            var rd = new Random();
            while (Directory.Exists(newfolder))
            {
                newfolder += rd.Next(0, 9);
            }
            
            Directory.CreateDirectory(newfolder);

            File.Copy(_map.Folder + "\\" + _map.Background, newfolder + "\\background.png");
            
            File.WriteAllText(newfolder + "\\config.txt", intrafl.ToString());

            _ffmpeg.ConvertAsync(new MediaFile(_map.Folder + "\\" + _map.Audio),
                new MediaFile(newfolder + "\\music.ogg"));
            
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
            var playerLink = playerLinkTxt.Text;
            CheckPlayer(playerLink);
        }

        private void LastCheckedClicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PlayerListClicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private static void CheckPlayer(string link)
        {
            var wc = new System.Net.WebClient();
            var profileInfo = wc.DownloadString(link);
            
            var sr = new StringReader(profileInfo);
            string line;
            
            var reader = new CsvReader();
            var mapData = reader.GetCsvContent("scores.csv");
            var allScores = FillAllScores(mapData);
            
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("/sharedfiles/filedetails/") && !line.Contains("Random") && !line.Contains("Hidden")
                    && !line.Contains("Endless"))
                {
                    int i = FindIForAllscores(line, mapData);

                    if (i != int.MaxValue)
                    {
                        var mapDetail = GetMapDetail(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
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
            var allScores = new object[mapData.Length][];
            for (var i = 0; i < allScores.Length; i++)
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

        private static int FindIForAllscores(string line, string[][] mapData)
        {
            for (var i = 0; i < mapData.Length; i++)
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
            var outputValues = new string[4];

            for (var i = 0; i < inputValues.Length; i++)
            {
                var value = inputValues[i];
                var aNumber = value.IndexOf(">", StringComparison.Ordinal);
                var bNumber = value.IndexOf("<", aNumber, StringComparison.Ordinal);
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