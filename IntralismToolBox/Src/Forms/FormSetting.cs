using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ManiaToIntralism.Forms
{
    /// <summary>
    /// Form that lets the user change the settings, values for that are saved in <include file='config.xml' path='[@name=""]'/>>
    /// </summary>
    public partial class FormSetting : Form
    {
        // creating a new XmlDocument object since the config is in xml format
        private readonly XmlDocument config = new XmlDocument();
        
        public FormSetting() => this.InitializeComponent();

        // when a FormSetting instance is opened, it will load the config file and saves it in config
        private void FormSetting_Load(object sender, EventArgs e)
        {
            this.config.Load("config.xml");
            this.LoadConfig();
        }
        
        /// <summary>
        /// loads the config file <include file='config.xml' path='[@name=""]'/> and sets the text of <see cref="maniaPathTxt"/> to value of maniapath
        /// and it will set the text of <see cref="editorPathTxt"/> to the value of editorpath
        /// </summary>
        private void LoadConfig()
        {
            // goes through every node in the config file
            foreach (XmlNode node in this.config.DocumentElement)
            {
                string firstValue = node.Attributes[0].Value;
                string secondValue = node.Attributes[1].Value;

                // changes the text of the Textboxes to the value from the config file
                switch (firstValue)
                {
                    case "maniapath": 
                        this.maniaPathTxt.Text = secondValue;
                        break;
                    case "editorpath": 
                        this.editorPathTxt.Text = secondValue;
                        break;
                }
            }
        }
        
        /// <summary>
        /// saves the config to the config file <include file='config.xml' path='[@name=""]'/> when <see cref="saveBtn"/> was pressed
        /// </summary>
        private void SaveConfig(object sender, EventArgs e)
        {
            // goes through every node in the config file
            foreach (XmlNode node in this.config.DocumentElement)
            {
                //it will change maniapath and editorpath to the corresponding TextBoxes, every other values in the config will just be copied
                node.Attributes[1].Value = node.Attributes[0].Value switch
                {
                    "maniapath"  => this.maniaPathTxt.Text,
                    "editorpath" => this.editorPathTxt.Text,
                    var _        => node.Attributes[1].Value,
                };
            }

            // saves the config to the config.xml
            this.config.Save("config.xml");
        }

        /// <summary>
        /// opens a folder picker in the initial directory that is written in the textbox <see cref="maniaPathTxt"/> and changes the text of that
        /// textbox to the selected folder
        /// </summary>
        private void SelectManiaFolder(object sender, EventArgs e) => this.maniaPathTxt.Text = GetFolderName(this.maniaPathTxt.Text);

        /// <summary>
        /// opens a folder picker in the initial directory that is written in the textbox <see cref="editorPathTxt"/> and changes the text of that 
        /// textbox to the selected folder
        /// </summary>
        private void SelectEditorFolder(object sender, EventArgs e) => this.editorPathTxt.Text = GetFolderName(this.editorPathTxt.Text);

        /// <summary>
        /// opens a folder picker in the initial directory that was provided to the function and returns the path of that folder
        /// </summary>
        private static string GetFolderName(string initialDirectory)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = initialDirectory,
                IsFolderPicker = true,
            };
            folderDialog.ShowDialog();
            
            return folderDialog.FileName;
        }
    }
}