using System;
using System.Diagnostics;
using System.Text;
using Octokit;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that pops up if a new github release is available.
    /// </summary>
    public partial class UpdateForm : ThemedForm
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

        private void UpdateClicked(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo("cmd", "/c start https://github.com/Ludeo/intralism-tool-collection/releases/latest")
            {
                CreateNoWindow = true,
            });
    }
}