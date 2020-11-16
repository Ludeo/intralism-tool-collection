using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm(
            string globalRank,
            string totalGlobalRank,
            string country,
            string countryRank,
            string totalCountryRank,
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
            this.Text = user + "'s Profile";
            this.GlobalRankLabel.Text = globalRank + " / " + totalGlobalRank;
            this.CountryNameLabel.Text = country + " Rank";
            this.CountryRankLabel.Text = countryRank + " / " + totalCountryRank;
            this.AverageMissLabel.Text = avgMiss.ToString();
            this.AverageAccuracyLabel.Text = avgAcc + "%";
            this.PointsLabel.Text = points.ToString();
            this.RealPointsLabel.Text = realPoints.ToString();
            this.MaximumPointsLabel.Text = maxPoints.ToString();
            this.PointDifferenceLabel.Text = difference.ToString();
            this.HundredCountLabel.Text = hundredPlays.ToString();
            this.TotalMapsLabel.Text = totalMaps.ToString();
            this.RankUpPointsLabel.Text = pointsTillRankup.ToString();

            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(pictureLink);
            Image image = Image.FromStream(stream);
            Image newImage = new Bitmap(image, new Size(this.PlayerPictureLabel.Width, this.PlayerPictureLabel.Height));
            this.PlayerPictureLabel.Image = newImage;
        }
    }
}