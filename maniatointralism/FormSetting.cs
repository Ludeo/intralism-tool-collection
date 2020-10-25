using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace maniatointralism
{
    public partial class FormSetting : Form
    {

        private string _maniaconfigpath;
        private string _editorconfigpath;
        
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadConfig();
            maniaPathTxt.Text = _maniaconfigpath;
            editorPathTxt.Text = _editorconfigpath;
        }
        
        private void LoadConfig()
        {
            var config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                switch (node.Attributes[0].Value)
                {
                    case "maniapath":
                        _maniaconfigpath = node.Attributes[1].Value;
                        break;
                    case "editorpath":
                        _editorconfigpath = node.Attributes[1].Value;
                        break;
                }
            }

        }

        private void SaveManiaPath(object sender, EventArgs e)
        {

            _maniaconfigpath = maniaPathTxt.Text;
            var config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                node.Attributes[1].Value = node.Attributes[0].Value switch
                {
                    "maniapath" => _maniaconfigpath,
                    "editorpath" => _editorconfigpath,
                    _ => node.Attributes[1].Value
                };
            }
            config.Save("config.xml");
        }

        private void SelectManiaFolder(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = maniaPathTxt.Text,
                IsFolderPicker = true
            };
            folderDialog.ShowDialog();

            maniaPathTxt.Text = folderDialog.FileName;
        }

        private void SaveEditorPath(object sender, EventArgs e)
        {
            _editorconfigpath = editorPathTxt.Text;
            var config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                node.Attributes[1].Value = node.Attributes[0].Value switch
                {
                    "maniapath" => _maniaconfigpath,
                    "editorpath" => _editorconfigpath,
                    _ => node.Attributes[1].Value
                };
            }
            config.Save("config.xml");
        }

        private void SelectEditorFolder(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = editorPathTxt.Text,
                IsFolderPicker = true
            };
            folderDialog.ShowDialog();

            editorPathTxt.Text = folderDialog.FileName;
        }
    }
}