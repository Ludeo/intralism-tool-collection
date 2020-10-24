using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace maniatointralism
{
    public partial class FormSetting : Form
    {

        private String _maniaconfigpath;
        private String _editorconfigpath;
        
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
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                if (node.Attributes[0].Value == "maniapath")
                { 
                    _maniaconfigpath = node.Attributes[1].Value;
                    
                } else if (node.Attributes[0].Value == "editorpath")
                { 
                    _editorconfigpath = node.Attributes[1].Value;
                }
            }

        }

        private void SaveManiaPath(object sender, EventArgs e)
        {

            _maniaconfigpath = maniaPathTxt.Text;
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                if (node.Attributes[0].Value == "maniapath")
                { 
                    node.Attributes[1].Value = _maniaconfigpath;
                    
                } else if (node.Attributes[0].Value == "editorpath")
                { 
                    node.Attributes[1].Value = _editorconfigpath;
                }
            }
            config.Save("config.xml");
        }

        private void SelectManiaFolder(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog
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
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            foreach (XmlNode node in config.DocumentElement)
            {
                if (node.Attributes[0].Value == "maniapath")
                { 
                    node.Attributes[1].Value = _maniaconfigpath;
                    
                } else if (node.Attributes[0].Value == "editorpath")
                { 
                    node.Attributes[1].Value = _editorconfigpath;
                }
            }
            config.Save("config.xml");
        }

        private void SelectEditorFolder(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog
            {
                InitialDirectory = editorPathTxt.Text,
                IsFolderPicker = true
            };
            folderDialog.ShowDialog();

            editorPathTxt.Text = folderDialog.FileName;
        }
    }
}