﻿using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using HtmlAgilityPack;
using ManiaToIntralism.Forms;

namespace ManiaToIntralism
{
    public static class Functions
    {
        public static void CheckPlayer(string link)
        {
            WebClient wc = new WebClient();
            string profileInfo = wc.DownloadString(link);
            profileInfo = Regex.Replace(profileInfo, @"^\s*$[\r\n]*", "", RegexOptions.Multiline);

            StringReader sr = new StringReader(profileInfo);
            string line;

            CsvReader reader = new CsvReader();
            string[][] mapData = reader.GetCsvContent("scores.csv");
            object[][] allScores = FillAllScores(mapData);

            string user;
            string globalRank = string.Empty;
            string totalGlobalRank = string.Empty;
            string countryRank = string.Empty;
            string totalCountryRank = string.Empty;
            string country = string.Empty;
            string pictureLink = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("/sharedfiles/filedetails/") &&
                    !line.Contains("Random") &&
                    !line.Contains("Hidden") &&
                    !line.Contains("Endless"))
                {
                    int i = FindIForAllScores(line, mapData);

                    if (i == int.MaxValue) continue;
                    
                    string score = sr.ReadLine();
                    while (!score.Contains("text-center")) score = sr.ReadLine();
                    string acc = sr.ReadLine();
                    string miss = sr.ReadLine();
                    string points = sr.ReadLine();

                    string[] mapDetail = GetMapDetail(score, acc, miss, points);
                    allScores[i][1] = int.Parse(mapDetail[0]);
                    allScores[i][2] = double.Parse(mapDetail[1]);
                    allScores[i][3] = int.Parse(mapDetail[2]);
                    allScores[i][4] = double.Parse(mapDetail[3]);

                }
                else if (line.Contains("<title>"))
                {
                    user = line;
                    int aNumber = user.IndexOf(">");
                    int bNumber = user.IndexOf("<", aNumber);
                    user = user[(aNumber + 13)..bNumber];

                }
                else if (line.Contains("strong>Global Rank"))
                {
                    globalRank = line;

                    if (globalRank == null) continue;
                    int aNumber = globalRank.IndexOf("\">");
                    int bNumber = globalRank.IndexOf("</span", aNumber);
                    globalRank = globalRank[(aNumber + 2)..bNumber];

                    totalGlobalRank = line;
                    aNumber = totalGlobalRank.IndexOf("</span>");
                    totalGlobalRank = totalGlobalRank[(aNumber + 10)..(line.Length - 4)];

                }
                else if (line.Contains("Country Rank"))
                {
                    countryRank = line;

                    if (countryRank == null) continue;
                    int aNumber = countryRank.IndexOf("\">");
                    int bNumber = countryRank.IndexOf("</span", aNumber);
                    countryRank = countryRank[(aNumber + 2)..bNumber];

                    totalCountryRank = line;
                    aNumber = totalCountryRank.IndexOf("</span");
                    totalCountryRank = totalCountryRank[(aNumber + 10)..(line.Length - 4)];

                }
                else if (line.Contains(">#"))
                {
                    country = sr.ReadLine();
                    int aNumber = country.IndexOf("title=\"");
                    int bNumber = country.IndexOf("><span", aNumber);
                    country = country[(aNumber + 7)..(bNumber - 3)];

                }
                else if (line.Contains("og:image"))
                {
                    pictureLink = line;
                    int aNumber = pictureLink.IndexOf("content");
                    int bNumber = pictureLink.IndexOf(">");
                    pictureLink = pictureLink[(aNumber + 9)..(bNumber - 3)];
                    
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

            int hundredCount = (int)recalcResult[6];
            int mapCount = allScores.Length;

            FormUserProfile profileForm = new FormUserProfile(
                globalRank,
                totalGlobalRank,
                country,
                countryRank,
                totalCountryRank,
                avgMiss,
                avgAcc,
                rankedPoints,
                realPoints,
                maximumPoints,
                totalDifference,
                hundredCount,
                mapCount,
                rankUpPoints,
                pictureLink);
            
            profileForm.Show();
            
            FormUserScore userScore = new FormUserScore(allScores);
            userScore.Show();
            
            SaveLastChecked(link);
        }

        private static object[][] FillAllScores(string[][] mapData)
        {
            object[][] allScores = new object[mapData.Length][];

            for (int i = 0; i < mapData.Length; i++)
            {
                mapData[i][0] = mapData[i][0].Replace("COMMA", ",");
                mapData[i][0] = mapData[i][0].Replace("QUOTE", "\"");
                allScores[i] = new object[8];
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
            string[] inputValues = { score, acc, miss, points };
            string[] outputValues = new string[4];

            for (int i = 0; i < inputValues.Length; i++)
            {
                string value = inputValues[i];
                int aNumber = value.IndexOf(">");
                int bNumber = value.IndexOf("<", aNumber);
                value = value[(aNumber + 1)..bNumber];

                if (i != 1)
                {
                    outputValues[i] = value.Replace(" ", "");
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

                double points = (double)allScores[i][4];
                double maxPoints = (double)allScores[i][5];
                double actPoints = points;
                realPoints += points;
                maximumPoints += maxPoints;

                if (allScores[i][7].ToString().Equals("Broken"))
                {
                    if (points == maxPoints)
                    {
                        actPoints = points - 0.01;
                        allScores[i][4] = Math.Round(actPoints * 100) / 100;
                    }

                    rankedPoints += actPoints;

                }
                else
                {
                    rankedPoints += points;
                }

                totalAcc += (double)allScores[i][2];
                totalMiss += (int)allScores[i][3];

                double a = (double)allScores[i][5];
                double b = (double)allScores[i][4];
                allScores[i][6] = Math.Round((a - b) * 100) / 100;
                totalDifference += (double)allScores[i][6];

                if ((double)allScores[i][2] == 100.00)
                {
                    hundredCount++;
                }

                if ((int)allScores[i][1] == 0)
                {
                    notPlayed++;
                }
            }

            double avgAccExact = totalAcc / (mapCount - notPlayed);
            double avgAcc = (double)Math.Round(avgAccExact * 10000) / 10000;
            
            double avgMiss = (double)totalMiss / mapCount;
            avgMiss = (double)Math.Round(avgMiss * 100) / 100;

            totalDifference = (double)Math.Round(totalDifference * 100) / 100;

            realPoints = (double)Math.Round(realPoints * 100) / 100;
            rankedPoints = (double)Math.Round(rankedPoints * 100) / 100;
            maximumPoints = (double)Math.Round(maximumPoints * 100) / 100;

            return new double[]
            {
                avgMiss, avgAcc, rankedPoints, realPoints, maximumPoints, totalDifference, hundredCount,
            };

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
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//tr");
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

            double currentPoints;

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

            if (globalRankInt == 1) return 0;
            
            return Math.Round((beforePoints - currentPoints) * 10000) / 10000;
        }

        public static void SaveLastChecked(string playerLink)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            string lastChecked = playerLink;

            foreach (XmlNode node in config.DocumentElement)
            {
                switch (node.Attributes[0].Value)
                {
                    case "lastchecked":
                        node.Attributes[1].Value = lastChecked;
                        break;
                }
            }
            
            config.Save("config.xml");
        }
    }
}