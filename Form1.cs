using System;
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
        private String _editorpath;
        private String _maniaconfigpath;
        private String _editorconfigpath;
        private readonly Engine _ffmpeg = new Engine("ffmpeg\\bin\\ffmpeg.exe");
        
        public Form1()
        {
            InitializeComponent();
            checkConfig();
            LoadConfig();
        }

        private void checkConfig()
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
                if (node.Attributes[0].Value == "maniapath")
                { 
                    _maniaconfigpath = node.Attributes[1].Value;
                    
                } else if (node.Attributes[0].Value == "editorpath")
                { 
                    _editorconfigpath = node.Attributes[1].Value;
                }
            }

        }
        
        private void Maniaclicked(object sender, EventArgs e)
        {

            var maniaDialog = new System.Windows.Forms.OpenFileDialog
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
            CommonOpenFileDialog editorDialog = new CommonOpenFileDialog
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

            if (int.TryParse(speedbox.Text, out _))
            {
                _map.Speed = speedbox.Text;
            }
            else
            {
                _map.Speed = "25";
            }

            StringBuilder intrafl = new StringBuilder();
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

            foreach (HitObject x in _map.Arcs)
            {
                double time = Double.Parse(x.Timing) / 1000;
                intrafl.Append(",{\"time\":" + time + ",\"data\":[\"SpawnObj\",\"[" + x.Pos + "],0\"]}");
            }

            intrafl.Append("]}");
            
            string newfolder = _editorpath + "\\" + _map.Artist + " - "
                               + _map.Title;
            
            Random rd = new Random();
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
            string playerLink = playerLinkTxt.Text;
            checkPlayer(playerLink);
        }

        private void LastCheckedClicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PlayerListClicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void checkPlayer(string link)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string profileInfo = wc.DownloadString(link);
            
            StringReader sr = new StringReader(profileInfo);
            string line;
            
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("/sharedfiles/filedetails/") && !line.Contains("Random") && !line.Contains("Hidden")
                    && !line.Contains("Endless"))
                {
                    
                }
            }
        }
    }
}