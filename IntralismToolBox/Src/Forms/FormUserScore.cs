using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    /// <summary>
    /// Form that will show the scores of a player in a table style
    /// </summary>
    public partial class FormUserScore : Form
    {
        // table that will contain the scores
        private readonly DataTable table = new DataTable();
        private readonly Type doubleType = Type.GetType("System.Double");
        private readonly Type int32Type = Type.GetType("System.Int32");
        
        public FormUserScore(IEnumerable<IEnumerable<object>> allScores, string user)
        {
            this.InitializeComponent();
            this.Text = user + "'s Scores";
            // creates the columns of the table with the correct data types
            this.table.Columns.Add("Map Name");
            this.table.Columns.Add("Score").DataType = this.doubleType;
            this.table.Columns.Add("Accuracy").DataType = this.doubleType;
            this.table.Columns.Add("Miss").DataType = this.int32Type;
            this.table.Columns.Add("My Points").DataType = this.doubleType;
            this.table.Columns.Add("Max Points").DataType = this.doubleType;
            this.table.Columns.Add("Difference").DataType = this.doubleType;
            this.table.Columns.Add("Broken?");
            
            // add a row to the table for each score
            foreach (IEnumerable<object> score in allScores)
            {
                this.table.Rows.Add((object[]) score);
            }

            // creates a datagridview that will display the table
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