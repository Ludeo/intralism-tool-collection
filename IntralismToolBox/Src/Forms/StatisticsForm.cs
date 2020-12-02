using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using IntralismScoreChecker;
using IntralismToolBox.ColorSchemes;
using Newtonsoft.Json;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="StatisticsPlayerListForm.ShowStatisticsButton"/> was pressed.
    /// </summary>
    public partial class StatisticsForm : Form
    {
        private static readonly Type DoubleType = Type.GetType("System.Double");
        private static readonly Type Int32Type = Type.GetType("System.Int32");
        private static List<IntralismScoreChecker.Player> players;
        private static List<IntralismScoreChecker.Player> remainingPlayers;

        /// <summary>
        ///     Initializes a new instance of the <see cref="StatisticsForm"/> class.
        /// </summary>
        /// <param name="playerName"> Name of the player which statistics should be shown. </param>
        /// <param name="allPlayers"> List of all players that got checked. </param>
        public StatisticsForm(string playerName, List<IntralismScoreChecker.Player> allPlayers)
        {
            this.InitializeComponent();
            FillPlayerLists(playerName, allPlayers);
            this.LoadGlobalRankChart();
            this.LoadCountryRankChart();
            this.LoadRankedPointsChart();
            this.LoadRealPointsChart();
            this.LoadAverageAccuracyChart();
            this.LoadAverageMissesChart();
            this.LoadDateComboBox();
            ReloadDataGridView(0);
            this.ReloadTheme();
            this.Text = players[0].Name + @"'s Statistics";
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
                    Functions.ChangeTheme(new DarkColorScheme(), this);

                    break;
                case "false":
                    Functions.ChangeTheme(new LightColorScheme(), this);

                    break;
            }
        }

        private static void FillPlayerLists(string playerName, List<IntralismScoreChecker.Player> allPlayers)
        {
            players = allPlayers.FindAll(
                x => playerName
                         .Contains(x.Id.ToString()));
            remainingPlayers = allPlayers.FindAll(
                x => !playerName
                    .Contains(x.Id.ToString()));
        }

        private static void ReloadDataGridView(int index)
        {
            DataTable table = new ();

            table.Columns.Add("Map Name");
            table.Columns.Add("Score").DataType = DoubleType!;
            table.Columns.Add("Accuracy").DataType = DoubleType;
            table.Columns.Add("Miss").DataType = Int32Type!;
            table.Columns.Add("My Points").DataType = DoubleType;
            table.Columns.Add("Max Points").DataType = DoubleType;
            table.Columns.Add("Difference").DataType = DoubleType;
            table.Columns.Add("Broken?").DataType = typeof(BrokenType);

            foreach (MapScore score in players[index].Scores)
            {
                table.Rows.Add(
                    score.MapName,
                    score.Score,
                    score.Accuracy,
                    score.Miss,
                    score.Points,
                    score.MaximumPoints,
                    score.Difference,
                    score.BrokenStatus);
            }

            ScoreDataGridView.DataSource = table;
        }

        private void LoadGlobalRankChart()
        {
            ChartArea chartArea = new ();
            this.GlobalRankChart.ChartAreas[0] = chartArea;

            this.GlobalRankChart.Series[0].Name = "Global Rank";
            this.GlobalRankChart.Series[0].ChartType = SeriesChartType.Spline;
            this.GlobalRankChart.Series[0].IsVisibleInLegend = false;

            int maxGlobalRank = 0;
            int minGlobalRank = players[0].TotalGlobalRank;

            foreach (IntralismScoreChecker.Player player in players)
            {
                if (player.GlobalRank > maxGlobalRank)
                {
                    maxGlobalRank = player.GlobalRank;
                }

                if (player.GlobalRank < minGlobalRank)
                {
                    minGlobalRank = player.GlobalRank;
                }

                DataPoint dataPoint = new ()
                {
                  XValue = this.GlobalRankChart.Series[0].Points.Count + 1,
                  YValues = new double[] { player.GlobalRank },
                  ToolTip = player.GlobalRank + "\n" + player.TimeChecked.ToLocalTime(),
                  MarkerStyle = MarkerStyle.Circle,
                };

                this.GlobalRankChart.Series[0].Points.Add(dataPoint);
            }

            if (maxGlobalRank == minGlobalRank)
            {
                maxGlobalRank += 1;
            }

            chartArea.AxisY.Minimum = minGlobalRank - 1;
            chartArea.AxisY.Maximum = maxGlobalRank + 1;
            chartArea.AxisY.Interval = (maxGlobalRank - minGlobalRank) / 4;
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = players.Count;
            chartArea.AxisX.Interval = 1;
        }

        private void LoadCountryRankChart()
        {
            ChartArea chartArea = new ();
            this.CountryRankChart.ChartAreas[0] = chartArea;

            this.CountryRankChart.Series[0].Name = "Country Rank";
            this.CountryRankChart.Series[0].ChartType = SeriesChartType.Spline;
            this.CountryRankChart.Series[0].IsVisibleInLegend = false;

            int maxCountryRank = 0;
            int minCountryRank = players[0].TotalCountryRank;

            foreach (IntralismScoreChecker.Player player in players)
            {
                if (player.CountryRank > maxCountryRank)
                {
                    maxCountryRank = player.CountryRank;
                }

                if (player.CountryRank < minCountryRank)
                {
                    minCountryRank = player.CountryRank;
                }

                DataPoint dataPoint = new ()
                {
                    XValue = this.CountryRankChart.Series[0].Points.Count + 1,
                    YValues = new double[] { player.CountryRank },
                    ToolTip = player.CountryRank + "\n" + player.TimeChecked.ToLocalTime(),
                    MarkerStyle = MarkerStyle.Circle,
                };

                this.CountryRankChart.Series[0].Points.Add(dataPoint);
            }

            if (maxCountryRank == minCountryRank)
            {
                maxCountryRank += 1;
            }

            chartArea.AxisY.Minimum = minCountryRank - 1;
            chartArea.AxisY.Maximum = maxCountryRank + 1;
            chartArea.AxisY.Interval = (maxCountryRank - minCountryRank) / 4;
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = players.Count;
            chartArea.AxisX.Interval = 1;
        }

        private void LoadRankedPointsChart()
        {
            ChartArea chartArea = new ();
            this.RankedPointsChart.ChartAreas[0] = chartArea;

            this.RankedPointsChart.Series[0].Name = "Ranked Points";
            this.RankedPointsChart.Series[0].ChartType = SeriesChartType.Spline;
            this.RankedPointsChart.Series[0].IsVisibleInLegend = false;

            double maxRankedPoints = 0;
            double minRankedPoints = players[0].MaximumPoints;

            foreach (IntralismScoreChecker.Player player in players)
            {
                if (player.Points > maxRankedPoints)
                {
                    maxRankedPoints = player.Points;
                }

                if (player.Points < minRankedPoints)
                {
                    minRankedPoints = player.Points;
                }

                DataPoint dataPoint = new ()
                {
                    XValue = this.RankedPointsChart.Series[0].Points.Count + 1,
                    YValues = new[] { player.Points },
                    ToolTip = player.Points + "\n" + player.TimeChecked.ToLocalTime(),
                    MarkerStyle = MarkerStyle.Circle,
                };

                this.RankedPointsChart.Series[0].Points.Add(dataPoint);
            }

            if (maxRankedPoints.Equals(minRankedPoints))
            {
                maxRankedPoints += 1;
            }

            chartArea.AxisY.Minimum = minRankedPoints - 1;
            chartArea.AxisY.Maximum = maxRankedPoints + 1;
            chartArea.AxisY.Interval = Math.Round((maxRankedPoints - minRankedPoints) / 4);
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = players.Count;
            chartArea.AxisX.Interval = 1;
        }

        private void LoadRealPointsChart()
        {
            ChartArea chartArea = new ();
            this.RealPointsChart.ChartAreas[0] = chartArea;

            this.RealPointsChart.Series[0].Name = "Real Points";
            this.RealPointsChart.Series[0].ChartType = SeriesChartType.Spline;
            this.RealPointsChart.Series[0].IsVisibleInLegend = false;

            double maxRealPoints = 0;
            double minRealPoints = players[0].MaximumPoints;

            foreach (IntralismScoreChecker.Player player in players)
            {
                if (player.RealPoints > maxRealPoints)
                {
                    maxRealPoints = player.RealPoints;
                }

                if (player.RealPoints < minRealPoints)
                {
                    minRealPoints = player.RealPoints;
                }

                DataPoint dataPoint = new ()
                {
                    XValue = this.RealPointsChart.Series[0].Points.Count + 1,
                    YValues = new[] { player.RealPoints },
                    ToolTip = player.RealPoints + "\n" + player.TimeChecked.ToLocalTime(),
                    MarkerStyle = MarkerStyle.Circle,
                };

                this.RealPointsChart.Series[0].Points.Add(dataPoint);
            }

            if (maxRealPoints.Equals(minRealPoints))
            {
                maxRealPoints += 1;
            }

            chartArea.AxisY.Minimum = minRealPoints - 1;
            chartArea.AxisY.Maximum = maxRealPoints + 1;
            chartArea.AxisY.Interval = Math.Round((maxRealPoints - minRealPoints) / 4);
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = players.Count;
            chartArea.AxisX.Interval = 1;
        }

        private void LoadAverageAccuracyChart()
        {
            ChartArea chartArea = new ();
            this.AverageAccuracyChart.ChartAreas[0] = chartArea;

            this.AverageAccuracyChart.Series[0].Name = "Average Accuracy";
            this.AverageAccuracyChart.Series[0].ChartType = SeriesChartType.Spline;
            this.AverageAccuracyChart.Series[0].IsVisibleInLegend = false;

            double maxAverageAccuracy = 0;
            double minAverageAccuracy = players[0].AverageAccuracy;

            foreach (IntralismScoreChecker.Player player in players)
            {
                if (double.IsNaN(player.AverageAccuracy))
                {
                    player.AverageAccuracy = 0;
                }

                if (player.AverageAccuracy > maxAverageAccuracy)
                {
                    maxAverageAccuracy = player.AverageAccuracy;
                }

                if (player.AverageAccuracy < minAverageAccuracy)
                {
                    minAverageAccuracy = player.AverageAccuracy;
                }

                DataPoint dataPoint = new ()
                {
                    XValue = this.AverageAccuracyChart.Series[0].Points.Count + 1,
                    YValues = new[] { player.AverageAccuracy },
                    ToolTip = player.AverageAccuracy + "\n" + player.TimeChecked.ToLocalTime(),
                    MarkerStyle = MarkerStyle.Circle,
                };

                this.AverageAccuracyChart.Series[0].Points.Add(dataPoint);
            }

            if (maxAverageAccuracy.Equals(minAverageAccuracy))
            {
                maxAverageAccuracy += 1;
            }

            chartArea.AxisY.Minimum = minAverageAccuracy - 1;
            chartArea.AxisY.Maximum = maxAverageAccuracy + 1;
            chartArea.AxisY.Interval = Math.Round((maxAverageAccuracy - minAverageAccuracy) / 4);
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = players.Count;
            chartArea.AxisX.Interval = 1;
        }

        private void LoadAverageMissesChart()
        {
            ChartArea chartArea = new ();
            this.AverageMissesChart.ChartAreas[0] = chartArea;

            this.AverageMissesChart.Series[0].Name = "Average Misses";
            this.AverageMissesChart.Series[0].ChartType = SeriesChartType.Spline;
            this.AverageMissesChart.Series[0].IsVisibleInLegend = false;

            double maxAverageMisses = 0;
            double minAverageMisses = players[0].AverageMisses;

            foreach (IntralismScoreChecker.Player player in players)
            {
                if (double.IsNaN(player.AverageMisses))
                {
                    player.AverageMisses = 0;
                }

                if (player.AverageMisses > maxAverageMisses)
                {
                    maxAverageMisses = player.AverageMisses;
                }

                if (player.AverageMisses < minAverageMisses)
                {
                    minAverageMisses = player.AverageMisses;
                }

                DataPoint dataPoint = new ()
                {
                    XValue = this.AverageMissesChart.Series[0].Points.Count + 1,
                    YValues = new[] { player.AverageMisses },
                    ToolTip = player.AverageMisses + "\n" + player.TimeChecked.ToLocalTime(),
                    MarkerStyle = MarkerStyle.Circle,
                };

                this.AverageMissesChart.Series[0].Points.Add(dataPoint);
            }

            if (maxAverageMisses.Equals(minAverageMisses))
            {
                maxAverageMisses += 1;
            }

            chartArea.AxisY.Minimum = minAverageMisses - 1;
            chartArea.AxisY.Maximum = maxAverageMisses + 1;
            chartArea.AxisY.Interval = Math.Round((maxAverageMisses - minAverageMisses) / 4);
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = players.Count;
            chartArea.AxisX.Interval = 1;
        }

        private void LoadDateComboBox()
        {
            foreach (IntralismScoreChecker.Player player in players)
            {
                this.ScoresDateComboBox.Items.Add(player.TimeChecked.ToLocalTime());
            }

            this.ScoresDateComboBox.SelectedIndex = 0;
        }

        private void NewDateSelected(object sender, EventArgs e) => ReloadDataGridView(this.ScoresDateComboBox.SelectedIndex);

        private void DeleteEntryClicked(object sender, EventArgs e)
        {
            int selectedIndex = this.ScoresDateComboBox.SelectedIndex;
            players.RemoveAt(selectedIndex);
            this.ScoresDateComboBox.Items.RemoveAt(selectedIndex);
            bool close = true;

            if (this.ScoresDateComboBox.Items.Count > 0)
            {
                this.ScoresDateComboBox.SelectedIndex = 0;
                ReloadDataGridView(0);
                close = false;
            }

            List<IntralismScoreChecker.Player> allPlayers = remainingPlayers;
            players.ForEach(allPlayers.Add);
            byte[] compressedFile = Compressor.Zip(JsonConvert.SerializeObject(allPlayers));
            File.WriteAllBytes("playerdatabase.json", compressedFile!);

            foreach (StatisticsPlayerListForm statisticsPlayerListForm in Application.OpenForms.OfType<StatisticsPlayerListForm>())
            {
                statisticsPlayerListForm.ReloadData();
            }

            if (close)
            {
                this.Close();
            }
        }
    }
}