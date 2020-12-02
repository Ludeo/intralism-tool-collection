using System.ComponentModel;
using System.Windows.Forms;

namespace IntralismToolBox.Forms
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.GlobalRankChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GlobalRankLabel = new System.Windows.Forms.Label();
            this.CountryRankChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CountryRankLabel = new System.Windows.Forms.Label();
            this.RankedPointsLabel = new System.Windows.Forms.Label();
            this.RankedPointsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RealPointsLabel = new System.Windows.Forms.Label();
            this.RealPointsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageAccuracyLabel = new System.Windows.Forms.Label();
            this.AverageAccuracyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageMissLabel = new System.Windows.Forms.Label();
            this.AverageMissesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ScoresDateComboBox = new System.Windows.Forms.ComboBox();
            this.ShowScoreLabel = new System.Windows.Forms.Label();
            ScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryRankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankedPointsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPointsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageAccuracyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageMissesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GlobalRankChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GlobalRankChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GlobalRankChart.Legends.Add(legend1);
            this.GlobalRankChart.Location = new System.Drawing.Point(12, 27);
            this.GlobalRankChart.Name = "GlobalRankChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GlobalRankChart.Series.Add(series1);
            this.GlobalRankChart.Size = new System.Drawing.Size(372, 136);
            this.GlobalRankChart.TabIndex = 0;
            this.GlobalRankChart.Text = "chart1";
            // 
            // GlobalRankLabel
            // 
            this.GlobalRankLabel.Location = new System.Drawing.Point(12, 9);
            this.GlobalRankLabel.Name = "GlobalRankLabel";
            this.GlobalRankLabel.Size = new System.Drawing.Size(100, 15);
            this.GlobalRankLabel.TabIndex = 1;
            this.GlobalRankLabel.Text = "Global Rank";
            // 
            // CountryRankChart
            // 
            chartArea2.Name = "ChartArea1";
            this.CountryRankChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CountryRankChart.Legends.Add(legend2);
            this.CountryRankChart.Location = new System.Drawing.Point(12, 197);
            this.CountryRankChart.Name = "CountryRankChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.CountryRankChart.Series.Add(series2);
            this.CountryRankChart.Size = new System.Drawing.Size(372, 136);
            this.CountryRankChart.TabIndex = 2;
            this.CountryRankChart.Text = "chart1";
            // 
            // CountryRankLabel
            // 
            this.CountryRankLabel.Location = new System.Drawing.Point(12, 179);
            this.CountryRankLabel.Name = "CountryRankLabel";
            this.CountryRankLabel.Size = new System.Drawing.Size(100, 15);
            this.CountryRankLabel.TabIndex = 3;
            this.CountryRankLabel.Text = "Country Rank";
            // 
            // RankedPointsLabel
            // 
            this.RankedPointsLabel.Location = new System.Drawing.Point(406, 9);
            this.RankedPointsLabel.Name = "RankedPointsLabel";
            this.RankedPointsLabel.Size = new System.Drawing.Size(100, 15);
            this.RankedPointsLabel.TabIndex = 5;
            this.RankedPointsLabel.Text = "Ranked Points";
            // 
            // RankedPointsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.RankedPointsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.RankedPointsChart.Legends.Add(legend3);
            this.RankedPointsChart.Location = new System.Drawing.Point(406, 27);
            this.RankedPointsChart.Name = "RankedPointsChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.RankedPointsChart.Series.Add(series3);
            this.RankedPointsChart.Size = new System.Drawing.Size(372, 136);
            this.RankedPointsChart.TabIndex = 4;
            this.RankedPointsChart.Text = "chart1";
            // 
            // RealPointsLabel
            // 
            this.RealPointsLabel.Location = new System.Drawing.Point(406, 179);
            this.RealPointsLabel.Name = "RealPointsLabel";
            this.RealPointsLabel.Size = new System.Drawing.Size(100, 15);
            this.RealPointsLabel.TabIndex = 7;
            this.RealPointsLabel.Text = "Real Points";
            // 
            // RealPointsChart
            // 
            chartArea4.Name = "ChartArea1";
            this.RealPointsChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.RealPointsChart.Legends.Add(legend4);
            this.RealPointsChart.Location = new System.Drawing.Point(406, 197);
            this.RealPointsChart.Name = "RealPointsChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.RealPointsChart.Series.Add(series4);
            this.RealPointsChart.Size = new System.Drawing.Size(372, 136);
            this.RealPointsChart.TabIndex = 6;
            this.RealPointsChart.Text = "chart1";
            // 
            // AverageAccuracyLabel
            // 
            this.AverageAccuracyLabel.Location = new System.Drawing.Point(797, 9);
            this.AverageAccuracyLabel.Name = "AverageAccuracyLabel";
            this.AverageAccuracyLabel.Size = new System.Drawing.Size(100, 15);
            this.AverageAccuracyLabel.TabIndex = 9;
            this.AverageAccuracyLabel.Text = "Average Accuracy";
            // 
            // AverageAccuracyChart
            // 
            chartArea5.Name = "ChartArea1";
            this.AverageAccuracyChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.AverageAccuracyChart.Legends.Add(legend5);
            this.AverageAccuracyChart.Location = new System.Drawing.Point(797, 27);
            this.AverageAccuracyChart.Name = "AverageAccuracyChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.AverageAccuracyChart.Series.Add(series5);
            this.AverageAccuracyChart.Size = new System.Drawing.Size(372, 136);
            this.AverageAccuracyChart.TabIndex = 8;
            this.AverageAccuracyChart.Text = "chart1";
            // 
            // AverageMissLabel
            // 
            this.AverageMissLabel.Location = new System.Drawing.Point(797, 179);
            this.AverageMissLabel.Name = "AverageMissLabel";
            this.AverageMissLabel.Size = new System.Drawing.Size(100, 15);
            this.AverageMissLabel.TabIndex = 11;
            this.AverageMissLabel.Text = "Average Misses";
            // 
            // AverageMissesChart
            // 
            chartArea6.Name = "ChartArea1";
            this.AverageMissesChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.AverageMissesChart.Legends.Add(legend6);
            this.AverageMissesChart.Location = new System.Drawing.Point(797, 197);
            this.AverageMissesChart.Name = "AverageMissesChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.AverageMissesChart.Series.Add(series6);
            this.AverageMissesChart.Size = new System.Drawing.Size(372, 136);
            this.AverageMissesChart.TabIndex = 10;
            this.AverageMissesChart.Text = "chart1";
            // 
            // ScoresDateComboBox
            // 
            this.ScoresDateComboBox.FormattingEnabled = true;
            this.ScoresDateComboBox.Location = new System.Drawing.Point(12, 357);
            this.ScoresDateComboBox.Name = "ScoresDateComboBox";
            this.ScoresDateComboBox.Size = new System.Drawing.Size(244, 21);
            this.ScoresDateComboBox.TabIndex = 12;
            this.ScoresDateComboBox.SelectedIndexChanged += new System.EventHandler(this.NewDateSelected);
            // 
            // ShowScoreLabel
            // 
            this.ShowScoreLabel.Location = new System.Drawing.Point(12, 339);
            this.ShowScoreLabel.Name = "ShowScoreLabel";
            this.ShowScoreLabel.Size = new System.Drawing.Size(100, 15);
            this.ShowScoreLabel.TabIndex = 13;
            this.ShowScoreLabel.Text = "Show Scores from:";
            // 
            // ScoreDataGridView
            // 
            ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScoreDataGridView.Location = new System.Drawing.Point(12, 384);
            ScoreDataGridView.Name = "ScoreDataGridView";
            ScoreDataGridView.ReadOnly = true;
            ScoreDataGridView.Size = new System.Drawing.Size(1157, 309);
            ScoreDataGridView.TabIndex = 14;
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEntryButton.Location = new System.Drawing.Point(406, 357);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteEntryButton.TabIndex = 15;
            this.DeleteEntryButton.Text = "Delete Selected Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = true;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryClicked);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 705);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(ScoreDataGridView);
            this.Controls.Add(this.ShowScoreLabel);
            this.Controls.Add(this.ScoresDateComboBox);
            this.Controls.Add(this.AverageMissLabel);
            this.Controls.Add(this.AverageMissesChart);
            this.Controls.Add(this.AverageAccuracyLabel);
            this.Controls.Add(this.AverageAccuracyChart);
            this.Controls.Add(this.RealPointsLabel);
            this.Controls.Add(this.RealPointsChart);
            this.Controls.Add(this.RankedPointsLabel);
            this.Controls.Add(this.RankedPointsChart);
            this.Controls.Add(this.CountryRankLabel);
            this.Controls.Add(this.CountryRankChart);
            this.Controls.Add(this.GlobalRankLabel);
            this.Controls.Add(this.GlobalRankChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.GlobalRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryRankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankedPointsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPointsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageAccuracyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageMissesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ScoreDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button DeleteEntryButton;

        private static System.Windows.Forms.DataGridView ScoreDataGridView;

        private System.Windows.Forms.Label ShowScoreLabel;

        private System.Windows.Forms.ComboBox ScoresDateComboBox;

        private System.Windows.Forms.DataVisualization.Charting.Chart AverageAccuracyChart;
        private System.Windows.Forms.Label AverageAccuracyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart AverageMissesChart;
        private System.Windows.Forms.Label AverageMissLabel;

        private System.Windows.Forms.DataVisualization.Charting.Chart RankedPointsChart;
        private System.Windows.Forms.Label RankedPointsLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RealPointsChart;
        private System.Windows.Forms.Label RealPointsLabel;

        private System.Windows.Forms.DataVisualization.Charting.Chart CountryRankChart;
        private System.Windows.Forms.Label CountryRankLabel;
        private System.Windows.Forms.Label GlobalRankLabel;

        private System.Windows.Forms.DataVisualization.Charting.Chart GlobalRankChart;

        #endregion
    }
}