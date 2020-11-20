using System;
using System.Configuration;
using System.Windows.Forms;
using IntralismToolBox.ColorSchemes;

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

            this.DarkModeToggleButton.Checked = config.AppSettings.Settings["darkmode"].Value switch
            {
                "true"  => true,
                "false" => false,
                var _       => this.DarkModeToggleButton.Checked,
            };
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            Configuration config = Functions.LoadConfig();

            config.AppSettings.Settings["maniapath"].Value = this.ManiaPathTextBox.Text;
            config.AppSettings.Settings["editorpath"].Value = this.EditorPathTextBox.Text;
            config.AppSettings.Settings["darkmode"].Value = this.DarkModeToggleButton.Checked.ToString().ToLower();
            config.Save();

            FormCollection formCollection = Application.OpenForms;

            foreach (Form form in formCollection)
            {
                switch (form)
                {
                    case MainForm mainForm:
                        mainForm.ReloadTheme();
                        break;

                    case AddPlayerForm addPlayerForm:
                        addPlayerForm.ReloadTheme();
                        break;

                    case PlayerListForm playerListForm:
                        playerListForm.ReloadTheme();
                        break;

                    case SettingsForm settingsForm:
                        settingsForm.ReloadTheme();
                        break;

                    case UserProfileForm userProfileForm:
                        userProfileForm.ReloadTheme();
                        break;

                    case UserScoreForm userScoreForm:
                        userScoreForm.ReloadTheme();
                        break;
                }
            }
        }

        private void SelectManiaFolder(object sender, EventArgs e) =>
            this.ManiaPathTextBox.Text = Functions.OpenFolderAndGetName(this.ManiaPathTextBox.Text);

        private void SelectEditorFolder(object sender, EventArgs e) =>
            this.EditorPathTextBox.Text = Functions.OpenFolderAndGetName(this.EditorPathTextBox.Text);

        private void ReloadTheme()
        {
            Configuration config = Functions.LoadConfig();

            switch (config.AppSettings.Settings["darkmode"].Value)
            {
                case "true":
                    Functions.ChangeTheme(new DarkColorScheme(), this);

                    break;
                case "false":
                    Functions.ChangeTheme(new LightColorScheme(), this);

                    break;
            }
        }
    }
}