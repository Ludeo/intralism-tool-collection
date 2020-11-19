using System;
using System.Configuration;
using System.Windows.Forms;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="MainForm.SettingsButton"/> was pressed.
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SettingsForm"/> class.
        /// </summary>
        public SettingsForm() => this.InitializeComponent();

        private void FormSetting_Load(object sender, EventArgs e) => this.LoadConfig();

        private void LoadConfig()
        {
            Configuration config = Functions.LoadConfig();

            this.ManiaPathTextBox.Text = config.AppSettings.Settings["maniapath"].Value;
            this.EditorPathTextBox.Text = config.AppSettings.Settings["editorpath"].Value;
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            Configuration config = Functions.LoadConfig();

            config.AppSettings.Settings["maniapath"].Value = this.ManiaPathTextBox.Text;
            config.AppSettings.Settings["editorpath"].Value = this.EditorPathTextBox.Text;
            config.Save();
        }

        private void SelectManiaFolder(object sender, EventArgs e) =>
            this.ManiaPathTextBox.Text = Functions.OpenFolderAndGetName(this.ManiaPathTextBox.Text);

        private void SelectEditorFolder(object sender, EventArgs e) =>
            this.EditorPathTextBox.Text = Functions.OpenFolderAndGetName(this.EditorPathTextBox.Text);
    }
}