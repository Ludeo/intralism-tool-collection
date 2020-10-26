using System.Data;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormUserScore : Form
    {
        public FormUserScore(object[][] allScores)
        {
            //TODO not working right now
            InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("Map Name");
            table.Columns.Add("Score");
            table.Columns.Add("Accuracy");
            table.Columns.Add("Miss");
            table.Columns.Add("My Points");
            table.Columns.Add("Max Points");
            table.Columns.Add("Difference");
            table.Columns.Add("Broken?");

            for (int i = 0; i < allScores.Length; i++)
            {
                table.Rows.Add(allScores[i]);
            }
            DataGridView grid = new DataGridView();
            this.Controls.Add(grid);
            grid.DataSource = table;
        }
    }
}