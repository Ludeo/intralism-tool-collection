using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using IntralismScoreChecker;

namespace ManiaToIntralism.Forms
{
    public partial class UserScoreForm : Form
    {
        private readonly DataTable table = new DataTable();
        private readonly Type doubleType = Type.GetType("System.Double");
        private readonly Type int32Type = Type.GetType("System.Int32");

        public UserScoreForm(List<MapScore> allScores, string user)
        {
            this.InitializeComponent();
            this.Text = user + "'s Scores";
            this.table.Columns.Add("Map Name");
            this.table.Columns.Add("Score").DataType = this.doubleType;
            this.table.Columns.Add("Accuracy").DataType = this.doubleType;
            this.table.Columns.Add("Miss").DataType = this.int32Type;
            this.table.Columns.Add("My Points").DataType = this.doubleType;
            this.table.Columns.Add("Max Points").DataType = this.doubleType;
            this.table.Columns.Add("Difference").DataType = this.doubleType;
            this.table.Columns.Add("Broken?").DataType = typeof(BrokenType);

            foreach (MapScore score in allScores)
            {
                this.table.Rows.Add(
                    score.MapName,
                    score.Score,
                    score.Accuracy,
                    score.Miss,
                    score.Points,
                    score.MaximumPoints,
                    score.Difference,
                    score.BrokenStatus);
            }

            DataGridView grid = new DataGridView();
            this.Controls.Add(grid);
            grid.DataSource = this.table;
            grid.AutoSize = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Anchor = AnchorStyles.Left;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.Dock = DockStyle.Fill;
        }
    }
}