using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FFmpeg.NET;
using HtmlAgilityPack;
using Microsoft.WindowsAPICodePack.Dialogs;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

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
            
            CsvReader reader = new CsvReader();
            string[][] mapData = reader.GetCsvContent("scores.csv");
            object[][] allScores = FillAllScores(mapData);

            string user;
            string globalRank = "";
            string totalGlobalRank;
            string countryRank;
            string totalCountryRank;
            string country;
            string pictureLink;
            
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("/sharedfiles/filedetails/") && !line.Contains("Random") && !line.Contains("Hidden")
                    && !line.Contains("Endless"))
                {
                    int i = FindIForAllScores(line, mapData);

                    if (i == int.MaxValue) continue;
                    
                    string[] mapDetail = GetMapDetail(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                    allScores[i][1] = int.Parse(mapDetail[0]);
                    allScores[i][2] = double.Parse(mapDetail[1]);
                    allScores[i][3] = int.Parse(mapDetail[2]);
                    allScores[i][4] = double.Parse(mapDetail[3]);
                    
                } else if (line.Contains("<title>"))
                {
                    user = line;
                    int aNumber = user.IndexOf(">");
                    int bNumber = user.IndexOf("<", aNumber);
                    user = user.Substring(aNumber + 13, bNumber);
                    
                } else if (line.Contains("strong>Global Rank"))
                {
                    line = sr.ReadLine();
                    globalRank = line;
                    if (globalRank == null) continue;
                    int aNumber = globalRank.IndexOf("\">");
                    int bNumber = globalRank.IndexOf("</span", aNumber);
                    globalRank = globalRank.Substring(aNumber + 2, bNumber);
                    
                    totalGlobalRank = line;
                    aNumber = totalGlobalRank.IndexOf("</span>");
                    totalGlobalRank = totalGlobalRank.Substring(aNumber + 10, line.Length);
                    
                } else if (line.Contains("Country Rank"))
                {
                    line = sr.ReadLine();
                    countryRank = line;
                    if(countryRank == null) continue;
                    int aNumber = countryRank.IndexOf("\">");
                    int bNumber = countryRank.IndexOf("</span", aNumber);
                    countryRank = countryRank.Substring(aNumber + 2, bNumber);

                    totalCountryRank = line;
                    aNumber = totalCountryRank.IndexOf("</span");
                    totalCountryRank = totalCountryRank.Substring(aNumber + 10, line.Length);
                    
                } else if (line.Contains(">#"))
                {
                    country = sr.ReadLine();
                    int aNumber = country.IndexOf("title=\"");
                    int bNumber = country.IndexOf("><span", aNumber);
                    country = country.Substring(aNumber + 7, bNumber - 1);
                    
                } else if (line.Contains("og:image"))
                {
                    pictureLink = sr.ReadLine();
                    int aNumber = pictureLink.IndexOf("content");
                    int bNumber = pictureLink.IndexOf(">");
                    pictureLink = pictureLink.Substring(aNumber + 9, bNumber - 1);
                }
            }

            double[] recalcResult = Recalc(allScores);
            double avgMiss = recalcResult[0];
            double avgAcc = recalcResult[1];
            double rankedPoints = recalcResult[2];
            double realPoints = recalcResult[3];
            double maximumPoints = recalcResult[4];
            double totalDifference = recalcResult[5];
            double rankUpPoints = GetRankUpPoints(link, globalRank, rankedPoints);

            int hundredCount = (int) recalcResult[6];
            int mapCount = allScores.Length;
            
            //TODO SaveLastChecked(link)
            
            //TODO create Window with the information
            
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
                int aNumber = value.IndexOf(">");
                int bNumber = value.IndexOf("<", aNumber);
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
        
        private static double[] Recalc(object[][] allScores)
        {
            double totalAcc = 0.0;
            double totalDifference = 0.0;
            double realPoints = 0.0;
            double rankedPoints = 0.0;
            double maximumPoints = 0.0;
            int totalMiss = 0;
            int hundredCount = 0;
            int mapCount = allScores.Length;
            int notPlayed = 0;

            for (int i = 0; i < allScores.Length; i++)
            {
                if (allScores[i][0] == null) continue;

                double points = (double) allScores[i][4];
                double maxPoints = (double) allScores[i][5];
                double actPoints = points;
                realPoints += points;
                maximumPoints += maxPoints;

                if (allScores[i][7].ToString().Equals("Broken"))
                {
                    if (points == maxPoints)
                    {
                        actPoints = points - 0.01;
                        allScores[i][4] = actPoints;
                    }

                    rankedPoints += actPoints;

                }
                else
                {
                    rankedPoints += points;
                }

                totalAcc += (double) allScores[i][2];
                totalMiss += (int) allScores[i][3];

                double a = (double) allScores[i][5];
                double b = (double) allScores[i][4];
                allScores[i][6] = a - b;
                totalDifference = +(double) allScores[i][6];

                if ((double) allScores[i][2] == 100.00)
                {
                    hundredCount++;
                }

                if ((int) allScores[i][1] == 0)
                {
                    notPlayed++;
                }
            }

            double avgAccExact = totalAcc / (mapCount - notPlayed);
            double avgAcc = (double) Math.Round(avgAccExact * 10000) / 10000;

            double avgMiss = (double) totalMiss / mapCount;
            avgMiss = (double) Math.Round(avgMiss * 100) / 100;

            totalDifference = (double) Math.Round(totalDifference * 100) / 100;

            realPoints = (double) Math.Round(realPoints * 100) / 100;
            rankedPoints = (double) Math.Round(rankedPoints * 100) / 100;
            maximumPoints = (double) Math.Round(maximumPoints * 100) / 100;

            return new double[] { avgMiss, avgAcc, rankedPoints, realPoints, maximumPoints, totalDifference, 
                hundredCount};

        }
        
        private static double GetRankUpPoints(string link, string globalRank, double points)
        {
            string playerId = link.Split("=")[1];
            int globalRankInt = int.Parse(globalRank);
            int n = ((globalRankInt - 1) / 100) + 1;

            if (globalRankInt % 100 == 1)
            {
                n -= 1;
            }
            
            string url = "https://intralism.khb-soft.ru/?page=ranks&n=" + n;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("tr");
            HtmlNode before = nodes[0];
            HtmlNode current = nodes[0];

            if (globalRankInt % 100 == 1)
            {
                before = nodes[^1];
                
            }
            else
            {
                foreach (HtmlNode e in nodes)
                {
                    if (e.Id.Contains(playerId))
                    {
                        current = e;
                        break;
                    }

                    before = e;
                }
            }

            double currentPoints = 0;
            if (globalRankInt % 100 == 1)
            {
                before = nodes[^1];
                currentPoints = points;
                
            }
            else
            {
                currentPoints = double.Parse(current.SelectNodes("td")[3].InnerText.Replace(" ", ""));
            }

            double beforePoints = double.Parse(before.SelectNodes("td")[3].InnerText.Replace(" ", ""));

            return Math.Round((beforePoints - currentPoints) * 10000) / 10000;
        }
    }
}