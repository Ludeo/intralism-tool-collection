using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ManiaToIntralism.Forms
{
    public partial class FormSetting : Form
    {

        private string _maniaconfigpath;
        private string _editorconfigpath;
        
        public FormSetting()
        {
            this.InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            this.LoadConfig();
            this.maniaPathTxt.Text = this._maniaconfigpath;
            this.editorPathTxt.Text = this._editorconfigpath;
        }
        
        private void LoadConfig()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                switch (node.Attributes[0].Value)
                {
                    case "maniapath":
                        this._maniaconfigpath = node.Attributes[1].Value;
                        break;
                    case "editorpath":
                        this._editorconfigpath = node.Attributes[1].Value;
                        break;
                }
            }

        }

        private void SaveManiaPath(object sender, EventArgs e)
        {

            this._maniaconfigpath = this.maniaPathTxt.Text;
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                node.Attributes[1].Value = node.Attributes[0].Value switch
                {
                    "maniapath"  => this._maniaconfigpath,
                    "editorpath" => this._editorconfigpath,
                    _            => node.Attributes[1].Value
                };
            }
            config.Save("config.xml");
        }

        private void SelectManiaFolder(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = this.maniaPathTxt.Text,
                IsFolderPicker = true
            };
            folderDialog.ShowDialog();

            this.maniaPathTxt.Text = folderDialog.FileName;
        }

        private void SaveEditorPath(object sender, EventArgs e)
        {
            this._editorconfigpath = this.editorPathTxt.Text;
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                node.Attributes[1].Value = node.Attributes[0].Value switch
                {
                    "maniapath"  => this._maniaconfigpath,
                    "editorpath" => this._editorconfigpath,
                    _            => node.Attributes[1].Value
                };
            }
            config.Save("config.xml");
        }

        private void SelectEditorFolder(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = this.editorPathTxt.Text,
                IsFolderPicker = true
            };
            folderDialog.ShowDialog();

            this.editorPathTxt.Text = folderDialog.FileName;
        }
    }
}