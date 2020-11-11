using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormAddPlayer : Form
    {
        public FormAddPlayer()
        {
            InitializeComponent();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            CsvReader reader = new CsvReader();
            string[][] players = reader.GetCsvContent("savedplayers.csv");
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < players.Length; i++)
            {
                sb.Append(players[i][0] + "," + players[i][1] + "\n");
            }

            sb.Append(this.nameTextBox.Text + "," + this.linkTextBox.Text);
            
            File.WriteAllText("savedplayers.csv", sb.ToString());
            
            this.Close();
        }
    }
}