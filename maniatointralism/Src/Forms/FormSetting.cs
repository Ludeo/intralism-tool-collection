using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ManiaToIntralism.Forms
{
    public partial class FormSetting : Form
    {
        private readonly XmlDocument config = new XmlDocument();
        
        public FormSetting() => this.InitializeComponent();

        private void FormSetting_Load(object sender, EventArgs e)
        {
            this.config.Load("config.xml");
            this.LoadConfig();
        }
        
        private void LoadConfig()
        {
            foreach (XmlNode node in this.config.DocumentElement)
            {
                string firstValue = node.Attributes[0].Value;
                string secondValue = node.Attributes[1].Value;

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
        
        private void SaveConfig(object sender, EventArgs e)
        {

            foreach (XmlNode node in this.config.DocumentElement)
            {
                node.Attributes[1].Value = node.Attributes[0].Value switch
                {
                    "maniapath"  => this.maniaPathTxt.Text,
                    "editorpath" => this.editorPathTxt.Text,
                    var _        => node.Attributes[1].Value,
                };
            }

            this.config.Save("config.xml");
        }

        private void SelectManiaFolder(object sender, EventArgs e)
        {
            this.maniaPathTxt.Text = GetFolderName(this.maniaPathTxt.Text);
        }

        private void SelectEditorFolder(object sender, EventArgs e)
        {
            this.editorPathTxt.Text = GetFolderName(this.editorPathTxt.Text);
        }

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