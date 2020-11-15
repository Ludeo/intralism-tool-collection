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
    /// <summary>
    /// main form that is displayed when the program is started
    /// </summary>
    public partial class Form1 : Form
    {
        //variables that are needed for map converting
        private ManiaMap maniaMap;
        private IntralismMap intralismMap;
        private string editorPath;
        private string maniaPath;
        private string maniaConfigPath;
        private string editorConfigPath;
        private string intralismMapPath;
        /// <summary>
        /// config file that will save the settings, <include file='config.xml' path='[@name=""]'/>
        /// </summary>
        private readonly XmlDocument config = new XmlDocument();
        // Engine instance of ffmpeg to convert mp3 to ogg
        private readonly Engine ffmpeg = new Engine("ffmpeg\\bin\\ffmpeg.exe");
        private readonly Random rd = new Random();
        
        /// <summary>
        /// when the main form is started, it will check if a config exist <see cref="CheckConfig"/> and then loads the config <see cref="LoadConfig"/>
        /// </summary>
        public Form1()
        {
            CheckConfig();
            this.config.Load("config.xml");
            this.InitializeComponent();
            this.LoadConfig();
        }

        /// <summary>
        /// checks if a config file exist, if not it will create a new config 
        /// </summary>
        private static void CheckConfig()
        {
            if (!File.Exists("config.xml"))
            {
                XmlDocument config = new XmlDocument();

                XmlNode rootNode = config.CreateElement("config");
                config.AppendChild(rootNode);
                
                // config node that will contain the maniaConfigPath
                XmlNode nodeMania = config.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute maniaKey = config.CreateAttribute("key");
                maniaKey.Value = "maniapath";
                XmlAttribute maniaValue = config.CreateAttribute("value");
                maniaValue.Value = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\osu!\\Songs";
                nodeMania.Attributes.Append(maniaKey);
                nodeMania.Attributes.Append(maniaValue);

                // config node that will contain the editorConfigPath
                XmlNode nodeEditor = config.CreateNode(XmlNodeType.Element, "entry", null);
                XmlAttribute editorKey = config.CreateAttribute("key");
                editorKey.Value = "editorpath";
                XmlAttribute editorValue = config.CreateAttribute("value");
                editorValue.Value = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Intralism\\Editor";
                nodeEditor.Attributes.Append(editorKey);
                nodeEditor.Attributes.Append(editorValue);

                // config node that will contain the last checked player
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

        /// <summary>
        /// loads the config and saves the maniapath into <see cref="maniaConfigPath"/> and the editorpath into <see cref="editorConfigPath"/>
        /// </summary>
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
        
        /// <summary>
        /// function that is getting called when <see cref="maniaSelect"/> is pressed
        /// you can select the maniamap here that you want to convert to intralism
        /// </summary>
        private void ManiaMapClicked(object sender, EventArgs e)
        {
            // loads the config again so the latest maniaConfigPath is loaded
            this.LoadConfig();

            // opens a file dialog with the initial directory saved in maniaConfigPath
            string mapPath = OpenFileAndGetName(this.maniaConfigPath);
            // creates a maniamap object with the path selected in the dialog
            ManiaMap temp = new ManiaMap(mapPath);

            // checks if the selected mania map is a mania map
            if (temp.Mode != Mode.Mania)
            {
                DisplayErrorMessage("This map is a {temp.Mode} map. Please select a mania map", "Error");
                return;
            }

            // sets the maniaMap variable to the above selected map so ConvertToIntralismClicked can have access to it 
            this.maniaMap = temp;
        }

        /// <summary>
        /// selects the directory of the editor folder of intralism when <see cref="editorSelect"/> is pressed
        /// </summary>
        private void EditorFolderClicked(object sender, EventArgs e)
        {
            // loads the config again so the latest editorConfigPath is loaded
            this.LoadConfig();

            // sets editorPath to the selected editor folder
            // it will try to open with the initial directory that is saved in editorConfigPath
            this.editorPath = OpenFolderAndGetName(this.editorConfigPath);
        }

        /// <summary>
        /// converts the mania map <see cref="maniaMap"/> to intralism and saves it in the editor folder <see cref="editorPath"/>
        /// its getting called when <see cref="ConvertToIntralism"/> is pressed
        /// </summary>
        private void ConvertToIntralismClicked(object sender, EventArgs e)
        {
            // checks if a mania map is selected
            if(this.maniaMap == null) {
                DisplayErrorMessage("No mania map selected", "Error");
                return;
            }

            // checks if a editor folder is selected
            if (this.editorPath == null)
            {
                DisplayErrorMessage("No editor path selected", "Error");
                return;
            }

            // tries to parse the content of the textbox speedbox, if the value is not an integer, it will set it will set the speed to the default 
            // value to 25
            if (!int.TryParse(this.speedbox.Text, out int speed))
            {
                speed = 25;
            }

            // sets the speed of the mania map to the speed that was parsed above
            this.maniaMap.Speed = speed;

            // stringbuilder for the config.txt file for the new intralism map of the converted mania map
            StringBuilder intraFile = new StringBuilder();
            // appending basic values as well as value that are given from the mania map to the config.txt
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

            // adds all hitobjects from the maniamap to the config.txt
            foreach (HitObject x in this.maniaMap.Arcs)
            {
                double time = x.Timing / 1000;
                intraFile.Append(",{\"time\":" + time + ",\"data\":[\"SpawnObj\",\"[" + x.Position + "],0\"]}");
            }

            // completing the config.txt to match a valid json format
            intraFile.Append("]}");
            
            // creating a string for the path for a new folder in the editor path for the converted map
            string newFolder = this.editorPath + "\\" + this.maniaMap.Artist + " - " + this.maniaMap.Title;
            
            // adds a random number to the folder name if a folder exists with that name already
            while (Directory.Exists(newFolder))
            {
                newFolder += this.rd.Next(0, 9);
            }
            
            // creating the new directory
            Directory.CreateDirectory(newFolder);

            // copies the background image of the mania map into the new folder
            File.Copy(this.maniaMap.Folder + "\\" + this.maniaMap.Background, newFolder + "\\background.png");
            
            // writes the config.txt file into the new folder
            File.WriteAllText(newFolder + "\\config.txt", intraFile.ToString());

            // converting the music file of the mania map to a .ogg format - because intralism only accepts that - and puts it into the new folder
            Task.Run(async () =>
                await this.ffmpeg.ConvertAsync(new MediaFile(this.maniaMap.Folder + "\\" + this.maniaMap.Audio),
                                     new MediaFile(newFolder + "\\music.ogg"))
            );
            
            // letting the user know, that the conversion is done
            MessageBox.Show(@"Successfully Converted", @"Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// opens a settings form <see cref="FormSetting"/> when <see cref="settingsButton"/> is pressed
        /// </summary>
        private void OpenSetting(object sender, EventArgs e)
        {
            // creating a new FormSetting
            Form setting = new FormSetting();
            // shows the form
            setting.ShowDialog();
        }

        /// <summary>
        /// checks the player that was given in <see cref="playerLinkText"/> when <see cref="checkButton"/> was pressed
        /// </summary>
        private void CheckClicked(object sender, EventArgs e)
        {
            // saving the link of the player from the text box playerLinkText
            string playerLink = this.playerLinkText.Text;
            // calls the CheckPlayer function with the link to the player
            CheckPlayer(playerLink);
        }

        /// <summary>
        /// checks the player that was saved in <include file='config.xml' path='[@name=""]'/> when <see cref="lastCheckedButton"/> was pressed
        /// </summary>
        private void LastCheckedClicked(object sender, EventArgs e)
        {
            // loads the config and saves the lastchecked player link in a variable
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
            
            // calls the CheckPlayer function with the player link from the config
            CheckPlayer(lastChecked);
        }

        /// <summary>
        /// opens a player list <see cref="FormPlayerList"/> when <see cref="playerListButton"/> was pressed
        /// </summary>
        private void PlayerListClicked(object sender, EventArgs e)
        {
            // creating a new FormPlayerList and shows it
            Form playerList = new FormPlayerList();
            playerList.Show();
        }

        /// <summary>
        /// selects the folder of a intralism map when <see cref="intralismSelect"/> is pressed
        /// </summary>
        private void IntralismMapClicked(object sender, EventArgs e)
        {
            // loads the config so editorConfigPath will have the most recent value
            this.LoadConfig();

            // opens a folder picker with the initial directory saved in editorConfigPath and sets the intralismMapPath to the path of the selected map
            this.intralismMapPath = OpenFolderAndGetName(this.editorConfigPath);
            string configPath = intralismMapPath + @"\config.txt";

            // checks if there is a config.txt file in the selected map folder
            if (!File.Exists(configPath) | string.IsNullOrEmpty(File.ReadAllText(configPath)))
            {
                DisplayErrorMessage("There is no map in this folder", @"Error");
                return;
            }

            // sets the intralismMap to a new intralism map object with the values given from the config.txt file
            this.intralismMap = IntralismMap.FromJson(this.intralismMapPath);
        }

        /// <summary>
        /// selects the osu song folder when <see cref="maniaFolderSelect"/> was pressed
        /// </summary>
        private void ManiaFolderClicked(object sender, EventArgs e)
        {
            // loads the config to the most recent maniaConfigPath
            this.LoadConfig();

            // opens a folder picker with the initial directory in maniaConfigPath and saves the select folder in maniaPath
            this.maniaPath = OpenFolderAndGetName(this.maniaConfigPath);
        }

        /// <summary>
        /// converts the intralism map <see cref="intralismMap"/> to a mania map in the osu song folder <see cref="maniaPath"/>
        /// when <see cref="ConvertToMania"/> was pressed
        /// </summary>
        private void ConvertToManiaClicked(object sender, EventArgs e)
        {
            // checks if a intralism was selected
            if (this.intralismMap == null)
            {
                DisplayErrorMessage("No intralism map selected", "Error");
                return;
            }

            // checks if a song folder was selected
            if (this.maniaPath == null)
            {
                DisplayErrorMessage("No mania path selected", "Error");
                return;
            }

            // sets default values to the artist and the title
            string artist = "Intralism";
            string title = this.intralismMap.Name;
            
            // trying to parse the offset from the textbox offsetBox to an integer, if that fails the base value of 40 will be selected
            int offset;

            if (!int.TryParse(this.offsetBox.Text, out offset))
            {
                offset = 40;
            }
            
            // tries to figure out if you can find a artist and a title in the intralis map name | usually its in the format "artist - title"
            if (this.intralismMap.Name.Contains("-"))
            {
                artist = this.intralismMap.Name.Substring(0, this.intralismMap.Name.IndexOf("-", StringComparison.Ordinal));
                title = this.intralismMap.Name.Substring(this.intralismMap.Name.IndexOf("-", StringComparison.Ordinal), 
                                                                this.intralismMap.Name.Length - this.intralismMap.Name.IndexOf("-", 
                                                                    StringComparison.Ordinal)).TrimStart('-');
            }

            // stringbuilder for the .osu file of the converted map, it applies all the values already, except the hit objects
            StringBuilder sb = Functions.ConvertIntralismToMania(this.intralismMap, artist, title);

            // goes through every event in the intralism map that is of the type SpawnObj (that are the arcs)
            foreach (Event ev in this.intralismMap.Events.Where(i => i.Data[0].Contains("SpawnObj")))
            {
                // splits the arcs, so the string will only contain the arcs and not additional information
                string rawArcs = ev.Data[1].Split(",")[0].TrimStart('[').TrimEnd(']');
                // splits the arcs into single arcs (for example Up-Right into Up and Right)
                List<string> arcs = rawArcs.Split("-").ToList();
                // converts the time from seconds into milliseconds and applies the offset
                int time = (int)TimeSpan.FromSeconds(ev.Time).TotalMilliseconds - offset;
                
                // adding the arcs to the stringbuilder
                foreach (string arc in arcs)
                {
                    sb.AppendLine($"{(int)Enum.Parse(typeof(Position), arc)},192,{time},1,0,0:0:0:0:");
                }
            }

            // creates a new directory inside the osu song folder called intralismconverts if it does not exist
            if (!Directory.Exists(this.maniaPath + "\\intralismconverts\\"))
            {
                Directory.CreateDirectory(this.maniaPath + "\\intralismconverts\\");
            }
            
            // sets the directory path to the path of a new folder inside intralismconverts titled by the artist and the title of the map
            string newFolder = this.maniaPath + "\\intralismconverts\\" + artist + " - " + title;
            
            //if the directory already exists, a random number will be attached at the end of the folder name
            while (Directory.Exists(newFolder))
            {
                newFolder += this.rd.Next(0, 9);
            }
            
            //creates the new directory
            Directory.CreateDirectory(newFolder);

            // copies the icon file of the intralism map to the new folder
            File.Copy(this.intralismMapPath + "\\" + this.intralismMap.IconFile, 
                      newFolder + "\\" + this.intralismMap.IconFile);
            
            // writes the content of the stringbuilder to a map file in the new folder
            File.WriteAllText(newFolder + "\\" +  this.intralismMap.Name + ".osu", sb.ToString());

            // copies the music file of the intralism map to the new folder | we dont have to care about file format because .ogg format also works 
            // in osu
            File.Copy(this.intralismMapPath + "\\" + this.intralismMap.MusicFile
                    , newFolder + "\\" + this.intralismMap.MusicFile);
            
            // lets the user know that the conversion is done
            MessageBox.Show(@"Successfully Converted", @"Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// just a button action event to try stuff out so you can just ignore this, it will be removed later
        /// </summary>
        private void TestButtonClicked(object sender, EventArgs e)
        {
            IntralismMap testMap = IntralismMap.FromJson(this.editorConfigPath + "\\seiyrubluedragon");

            //testMap.EventsToBetterEvents();
            testMap.SortEvents();

            foreach (Event ev in testMap.Events.Where(x => x.Data[0] != "SpawnObj"))
            {
                Console.WriteLine(JsonConvert.SerializeObject(ev, Formatting.Indented));
            }
            
        }
    }
}