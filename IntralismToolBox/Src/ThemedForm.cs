using System.Configuration;
using System.Windows.Forms;
using IntralismToolBox.ColorSchemes;
using IntralismToolBox.Forms;

namespace IntralismToolBox
{
    /// <summary>
    ///     A <see cref="Form"/> that allows theming.
    ///     Make sure to call <see cref="ReloadTheme"/> after <see cref="InitializeComponent"/> inside of the constructor.
    /// </summary>
    public partial class ThemedForm : Form
    {
        /// <summary>
        ///     Reloads the color theme of the form. It's public so <see cref="SettingsForm"/> can call it.
        /// </summary>
        public void ReloadTheme()
        {
            Configuration config = Functions.LoadConfig();

            switch (config.AppSettings.Settings["darkmode"].Value)
            {
                case "true":
                    Functions.ChangeTheme<DarkColorScheme>(this);

                    break;
                case "false":
                    Functions.ChangeTheme<LightColorScheme>(this);

                    break;
            }
        }
    }
}