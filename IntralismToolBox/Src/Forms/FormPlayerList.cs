using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    /// <summary>
    /// form that will display a list of players saved in the <include file='savedplayers.csv' path='[@name=""]'/>
    /// </summary>
    public partial class FormPlayerList : Form
    {
        public FormPlayerList()
        {
            this.InitializeComponent();
            // enables the scroll bar 
            this.PlayerList.ScrollAlwaysVisible = true;
            
            // reads the player informations from savedplayers.csv and saves it in a variable
            string[][] players = CsvReader.GetCsvContent("savedplayers.csv");
            
            // adding every player from the player array to the listbox PlayerList, it will be converted to a Player object before that though
            for(int i = 0; i < players.Length; i++)
            {
                this.PlayerList.Items.Add(new Player(players[i][0], players[i][1]));
            }
            
            // this will select the first player of the list, the purpose of this is that if you click on the check or remove button, then a player
            // will always be select and it won't lead to errors
            if(players.Length >= 1)
            {
                this.PlayerList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// checks the player that was selected in <see cref="PlayerList"/> when <see cref="checkBtn"/> was pressed
        /// </summary>
        private void CheckClicked(object sender, EventArgs e)
        {
            // gets the selected player from the PlayerList listbox
            Player current = (Player)this.PlayerList.SelectedItem;
            // checks the selected player with the link to his profile
            Functions.CheckPlayer(current.Link);
        }

        /// <summary>
        /// opens a addplayer form <see cref="FormAddPlayer"/> when <see cref="addBtn"/> is clicked
        /// when the addplayer form is closed, a new FormPlayerList will be shown and the current one will be closed
        /// </summary>
        private void AddClicked(object sender, EventArgs e)
        {
            // creating a FormAddPlayer form and shows it
            Form addPlayerForm = new FormAddPlayer();
            addPlayerForm.ShowDialog();
            
            // when the addPlayerForm will be closed, newPlayerListForm will be created and shown, the old FormPlayerList will be closed
            // reason for this is, that it will be refreshed and has the newly added player shown
            Form newPlayerListForm = new FormPlayerList();
            newPlayerListForm.Show();
            this.Close();
        }

        /// <summary>
        /// removes the player that was selected in <see cref="PlayerList"/> from the csv file <include file='savedplayers.csv' path='[@name=""]'/>
        /// when <see cref="removeBtn"/> was pressed
        /// </summary>
        private void RemoveClicked(object sender, EventArgs e)
        {
            // gets the player that was selected in the PlayerList
            Player current = (Player)this.PlayerList.SelectedItem;
            // creates a array that contains the content of the savedplayers.csv file
            string[][] players = CsvReader.GetCsvContent("savedplayers.csv");
            // creating a stringbuilder for the new savedplayers.csv content
            StringBuilder sb = new StringBuilder();
            // boolean to save if the removed player was the first player in the list
            bool first = false;

            for (int i = 0; i < players.Length; i++)
            {
                // checks if the player at the index of i has matching name and link with the player that should be removed
                // if yes, then the player won't get added to the string builder
                if (players[i][0].Equals(current.Name) &&
                    players[i][1].Equals(current.Link))
                {
                    
                }
                else
                {
                    // adds a line break at the end of the latest line, its true when a player was added to the stringbuilder before
                    if (first)
                    {
                        sb.Append("\n");
                    }
                    
                    // adds the player at the index of i to the stringbuilder
                    sb.Append(players[i][0] + "," + players[i][1]);
                    first = true;

                }
            }

            // saves the savedplayers.csv with the content of the stringbuilder
            File.WriteAllText("savedplayers.csv", sb.ToString());

            // creating a new FormPlayerList and shows it, then the old FormPlayerList will be closed
            // purpose of this is to refresh the FormPlayerList after a player was removed
            Form newPlayerList = new FormPlayerList();
            newPlayerList.Show();
            this.Close();
        }
    }
}