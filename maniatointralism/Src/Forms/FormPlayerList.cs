using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormPlayerList : Form
    {
        public FormPlayerList()
        {
            this.InitializeComponent();
            this.PlayerList.ScrollAlwaysVisible = true;
            
            CsvReader reader = new CsvReader();
            string[][] players = reader.GetCsvContent("savedplayers.csv");
            
            for(int i = 0; i < players.Length; i++)
            {
                this.PlayerList.Items.Add(new Player(players[i][0], players[i][1]));
            }
            
            if(players.Length >= 1)
            {
                this.PlayerList.SelectedIndex = 0;
            }
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerList.SelectedItem;
            Functions.CheckPlayer(current.link);
        }

        private void AddClicked(object sender, EventArgs e)
        {
            Form addPlayerForm = new FormAddPlayer();
            addPlayerForm.ShowDialog();
            
            Form newPlayerListForm = new FormPlayerList();
            newPlayerListForm.Show();
            this.Close();
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            Player current = (Player)this.PlayerList.SelectedItem;
            CsvReader reader = new CsvReader();
            string[][] players = reader.GetCsvContent("savedplayers.csv");
            
            StringBuilder sb = new StringBuilder();
            bool first = false;

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i][0].Equals(current.name) &&
                    players[i][1].Equals(current.link))
                {
                    
                }
                else
                {
                    if (first) sb.Append("\n");
                    sb.Append(players[i][0] + "," + players[i][1]);
                    first = true;

                }
            }

            File.WriteAllText("savedplayers.csv", sb.ToString());

            Form newPlayerList = new FormPlayerList();
            newPlayerList.Show();
            this.Close();
        }
    }
}