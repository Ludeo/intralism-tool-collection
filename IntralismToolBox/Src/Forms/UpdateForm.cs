using System;
using System.Configuration;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using IntralismToolBox.ColorSchemes;
using Octokit;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that pops up if a new github release is available.
    /// </summary>
    public partial class UpdateForm : Form
    {
        private readonly Release release;

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateForm"/> class.
        /// </summary>
        /// <param name="release"> <see cref="Octokit.Release"/> that contains information about the newest release. </param>
        public UpdateForm(Release release)
        {
            this.release = release;
            this.InitializeComponent();
            this.ReloadTheme();
            this.DisplayReleaseNotes();
        }

        private void CancelButtonClicked(object sender, EventArgs e) => this.Close();

        private void DisplayReleaseNotes()
        {
            StringBuilder sb = new();
            sb.AppendLine(this.release.TagName + " is now available!");
            sb.AppendLine(string.Empty);
            sb.AppendLine(this.release.Name);
            this.ReleaseNotesTextBox.Text = sb.ToString();
        }

        /// <summary>
        ///     Reloads the color theme of the form. It's public so <see cref="SettingsForm"/> can call it.
        /// </summary>
        public void ReloadTheme()
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

        private void UpdateClicked(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo("cmd", "/c start https://github.com/Ludeo/intralism-tool-collection/releases/latest")
            {
                CreateNoWindow = true,
            });
    }
}