﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using IntralismScoreChecker;
using IntralismToolBox.ColorSchemes;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="MainForm.CheckPlayerButton"/>, <see cref="MainForm.LastCheckedPlayerButton"/> or
    ///     <see cref="PlayerListForm.CheckPlayerButton"/> was pressed.
    /// </summary>
    public partial class UserScoreForm : Form
    {
        private readonly Type doubleType = Type.GetType("System.Double");
        private readonly Type int32Type = Type.GetType("System.Int32");
        private readonly DataTable table = new();

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserScoreForm"/> class.
        /// </summary>
        /// <param name="allScores"> IEnumerable of <see cref="IntralismScoreChecker.MapScore"/> with the scores of a intralism player. </param>
        /// <param name="user"> Name of the intralism player. </param>
        public UserScoreForm(IEnumerable<MapScore> allScores, string user)
        {
            this.InitializeComponent();

            this.Text = user + @"'s Scores";
            this.table.Columns.Add("Map Name");
            this.table.Columns.Add("Score").DataType = this.doubleType!;
            this.table.Columns.Add("Accuracy").DataType = this.doubleType;
            this.table.Columns.Add("Miss").DataType = this.int32Type!;
            this.table.Columns.Add("My Points").DataType = this.doubleType;
            this.table.Columns.Add("Max Points").DataType = this.doubleType;
            this.table.Columns.Add("Difference").DataType = this.doubleType;
            this.table.Columns.Add("Broken?").DataType = typeof(BrokenType);

            foreach (MapScore score in allScores)
            {
                this.table.Rows.Add(score.MapName,
                                    score.Score,
                                    score.Accuracy,
                                    score.Miss,
                                    score.Points,
                                    score.MaximumPoints,
                                    score.Difference,
                                    score.BrokenStatus);
            }

            this.ScoreDataGridView.DataSource = this.table;
            this.ReloadTheme();
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
    }
}