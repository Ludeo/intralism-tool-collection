using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    /// <summary>
    /// Form that will display the general profile information of a player with the given values
    /// </summary>
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
            string pictureLink,
            string user)
        {
            this.InitializeComponent();
            // changes the value of labels to the information that was given when the object was created
            this.Text = user + "'s Profile";
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
            // creates a webclient to open the pictureLink and saves it in an image object
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(pictureLink);
            Image image = Image.FromStream(stream);
            // resizes the image to the height and with of the label of the picture
            Image newImage = new Bitmap(image, new Size(this.pictureLbl.Width, this.pictureLbl.Height));
            this.pictureLbl.Image = newImage;
        }
    }
}