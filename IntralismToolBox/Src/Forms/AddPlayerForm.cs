﻿using System;
using System.IO;
using System.Text;
using IntralismScoreChecker;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="PlayerListForm.AddPlayerButton"/> was pressed.
    /// </summary>
    public partial class AddPlayerForm : ThemedForm
    {
        private const string SavedPlayersCsvPath = "savedplayers.csv";

        private readonly string[][] players = CsvReader.GetCsvContent(SavedPlayersCsvPath);

        private readonly StringBuilder stringBuilder = new();

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddPlayerForm"/> class.
        /// </summary>
        public AddPlayerForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            this.AppendTextBoxContents();
            this.SaveContents();
            this.Close();
        }

        private void AppendTextBoxContents()
        {
            foreach (string[] player in this.players)
            {
                this.CombineString(player[0], player[1]);
            }

            this.CombineString(this.PlayerNameTextBox.Text, this.PlayerLinkTextBox.Text);
        }

        private void CombineString(string a, string b) => this.stringBuilder.AppendLine(a + "," + b);

        private void SaveContents() => File.WriteAllText(SavedPlayersCsvPath, this.stringBuilder.ToString());
    }
}