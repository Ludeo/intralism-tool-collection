using System;
using System.Configuration;
using System.Windows.Forms;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="MainForm.SettingsButton"/> was pressed.
    /// </summary>
    public partial class SettingsForm : ThemedForm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SettingsForm"/> class.
        /// </summary>
        public SettingsForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
        }

        private void FormSetting_Load(object sender, EventArgs e) => this.LoadConfig();

        private void LoadConfig()
        {
            Configuration config = Functions.LoadConfig();

            this.ManiaPathTextBox.Text = config.AppSettings.Settings["maniapath"].Value;
            this.EditorPathTextBox.Text = config.AppSettings.Settings["editorpath"].Value;
            this.AudioPathTextBox.Text = config.AppSettings.Settings["audiopath"].Value;

            this.DarkModeToggleButton.Checked = config.AppSettings.Settings["darkmode"].Value switch
            {
                "true"  => true,
                "false" => false,
                _       => this.DarkModeToggleButton.Checked,
            };
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            Configuration config = Functions.LoadConfig();

            config.AppSettings.Settings["maniapath"].Value = this.ManiaPathTextBox.Text;
            config.AppSettings.Settings["editorpath"].Value = this.EditorPathTextBox.Text;
            config.AppSettings.Settings["audiopath"].Value = this.AudioPathTextBox.Text;
            config.AppSettings.Settings["darkmode"].Value = this.DarkModeToggleButton.Checked.ToString().ToLower();
            config.Save();

            FormCollection formCollection = Application.OpenForms;

            foreach (ThemedForm form in formCollection)
            {
                form.ReloadTheme();
            }
        }

        private void SelectAudioPathClicked(object sender, EventArgs e) =>
            this.AudioPathTextBox.Text = Functions.OpenFolderAndGetName(this.AudioPathTextBox.Text);

        private void SelectEditorFolder(object sender, EventArgs e) =>
            this.EditorPathTextBox.Text = Functions.OpenFolderAndGetName(this.EditorPathTextBox.Text);

        private void SelectManiaFolder(object sender, EventArgs e) =>
            this.ManiaPathTextBox.Text = Functions.OpenFolderAndGetName(this.ManiaPathTextBox.Text);
    }
}