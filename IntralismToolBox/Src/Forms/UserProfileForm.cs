using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using IntralismToolBox.ColorSchemes;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that gets shown when <see cref="MainForm.CheckPlayerButton"/>, <see cref="MainForm.LastCheckedPlayerButton"/> or
    ///     <see cref="PlayerListForm.CheckPlayerButton"/> was pressed.
    /// </summary>
    public partial class UserProfileForm : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UserProfileForm"/> class.
        /// </summary>
        /// <param name="globalRank"> Global Rank of the intralism player. </param>
        /// <param name="totalGlobalRank"> Total amount of ranked intralism players. </param>
        /// <param name="country"> Country of the intralism player. </param>
        /// <param name="countryRank"> Country Rank of the intralism player. </param>
        /// <param name="totalCountryRank"> Total amount of ranked players from the country of the intralism player. </param>
        /// <param name="avgMiss"> Average amount of misses of the intralism player. </param>
        /// <param name="avgAcc"> Average accuracy of the intralism player. </param>
        /// <param name="points"> Ranked points of the intralism player. </param>
        /// <param name="realPoints"> Real points of the intralism player if no map would be broken <see cref="IntralismScoreChecker.BrokenType"/>.
        /// </param>
        /// <param name="maxPoints"> Maximum amount of points that you can get from ranked intralism maps. </param>
        /// <param name="difference"> Difference between the points of the player and the maximum points. </param>
        /// <param name="hundredPlays"> Amount of 100% accuracy plays of the intralism player. </param>
        /// <param name="totalMaps"> Total amount of ranked intralism maps. </param>
        /// <param name="pointsTillRankup"> Points needed for the intralism player to rank up one rank in the global ranking. </param>
        /// <param name="pictureLink"> Link to the profile picture of the intralism player. </param>
        /// <param name="user"> Name of the intralism player. </param>
        public UserProfileForm(
            int globalRank,
            int totalGlobalRank,
            string country,
            int countryRank,
            int totalCountryRank,
            double avgMiss,
            double avgAcc,
            double points,
            double realPoints,
            double maxPoints,
            double difference,
            int hundredPlays,
            int totalMaps,
            double pointsTillRankup,
            string pictureLink,
            string user)
        {
            this.InitializeComponent();
            this.ReloadTheme();

            this.Text = user + @"'s Profile";
            this.GlobalRankLabel.Text = globalRank + @" / " + totalGlobalRank;
            this.CountryNameLabel.Text = country + @" Rank";
            this.CountryRankLabel.Text = countryRank + @" / " + totalCountryRank;
            this.AverageMissLabel.Text = avgMiss.ToString();
            this.AverageAccuracyLabel.Text = avgAcc + @"%";
            this.PointsLabel.Text = points.ToString();
            this.RealPointsLabel.Text = realPoints.ToString();
            this.MaximumPointsLabel.Text = maxPoints.ToString();
            this.PointDifferenceLabel.Text = difference.ToString();
            this.HundredCountLabel.Text = hundredPlays.ToString();
            this.TotalMapsLabel.Text = totalMaps.ToString();
            this.RankUpPointsLabel.Text = pointsTillRankup.ToString();

            WebClient webClient = new ();
            Stream stream = webClient.OpenRead(pictureLink!);
            Image image = Image.FromStream(stream!);
            Image newImage = new Bitmap(image, new Size(this.PlayerPictureLabel.Width, this.PlayerPictureLabel.Height));
            this.PlayerPictureLabel.Image = newImage;
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
    }
}