using System;
using System.Data;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormUserScore : Form
    {
        public FormUserScore(object[][] allScores)
        {
            this.InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("Map Name");
            table.Columns.Add("Score").DataType = Type.GetType("System.Double");
            table.Columns.Add("Accuracy").DataType = Type.GetType("System.Double");
            table.Columns.Add("Miss").DataType = Type.GetType("System.Int32");
            table.Columns.Add("My Points").DataType = Type.GetType("System.Double");
            table.Columns.Add("Max Points").DataType = Type.GetType("System.Double");
            table.Columns.Add("Difference").DataType = Type.GetType("System.Double");
            table.Columns.Add("Broken?");

            for (int i = 0; i < allScores.Length; i++)
            {
                table.Rows.Add(allScores[i]);
            }
            
            DataGridView grid = new DataGridView();
            this.Controls.Add(grid);
            grid.DataSource = table;
            grid.AutoSize = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Anchor = AnchorStyles.Left;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.Dock = DockStyle.Fill;
        }
    }
}