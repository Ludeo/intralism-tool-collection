using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile(
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
            string pictureLink)
        {
            this.InitializeComponent();
            this.globalRankLbl.Text = globalRank + " / " + totalGlobalRank;
            this.countryNameLbl.Text = country + " Rank";
            this.countryRankLbl.Text = countryRank + " / " + totalCountryRank;
            this.avgMissLbl.Text = avgMiss.ToString();
            this.avgAccuracyLbl.Text = avgAcc + "%";
            this.pointsLbl.Text = points.ToString();
            this.realPointsLbl.Text = realPoints.ToString();
            this.maxPointsLbl.Text = maxPoints.ToString();
            this.differenceLbl.Text = difference.ToString();
            this.hundredLbl.Text = hundredPlays.ToString();
            this.totalMapsLbl.Text = totalMaps.ToString();
            this.pointsRankupLbl.Text = pointsTillRankup.ToString();
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(pictureLink);
            Image image = Image.FromStream(stream);
            Image newImage = new Bitmap(image, new Size(this.pictureLbl.Width, this.pictureLbl.Height));
            this.pictureLbl.Image = newImage;
        }
    }
}