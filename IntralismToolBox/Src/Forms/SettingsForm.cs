using System;
using System.Windows.Forms;
using System.Xml;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="MainForm.SettingsButton"/> was pressed.
    /// </summary>
    public partial class SettingsForm : Form
    {
        private readonly XmlDocument config = new ();

        /// <summary>
        ///     Initializes a new instance of the <see cref="SettingsForm"/> class.
        /// </summary>
        public SettingsForm() => this.InitializeComponent();

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
                        this.ManiaPathTextBox.Text = secondValue;

                        break;
                    case "editorpath":
                        this.EditorPathTextBox.Text = secondValue;

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
                    "maniapath"  => this.ManiaPathTextBox.Text,
                    "editorpath" => this.EditorPathTextBox.Text,
                    var _        => node.Attributes[1].Value,
                };
            }

            this.config.Save("config.xml");
        }

        private void SelectManiaFolder(object sender, EventArgs e) =>
            this.ManiaPathTextBox.Text = Functions.OpenFolderAndGetName(this.ManiaPathTextBox.Text);

        private void SelectEditorFolder(object sender, EventArgs e) =>
            this.EditorPathTextBox.Text = Functions.OpenFolderAndGetName(this.EditorPathTextBox.Text);
    }
}