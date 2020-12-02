using System.ComponentModel;

namespace IntralismToolBox.Forms
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.PlayerPictureLabel = new System.Windows.Forms.Label();
            this.TextLabel1 = new System.Windows.Forms.Label();
            this.GlobalRankLabel = new System.Windows.Forms.Label();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.CountryRankLabel = new System.Windows.Forms.Label();
            this.TextLabel2 = new System.Windows.Forms.Label();
            this.AverageMissLabel = new System.Windows.Forms.Label();
            this.TextLabel3 = new System.Windows.Forms.Label();
            this.AverageAccuracyLabel = new System.Windows.Forms.Label();
            this.TextLabel4 = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.TextLabel5 = new System.Windows.Forms.Label();
            this.RealPointsLabel = new System.Windows.Forms.Label();
            this.TextLabel6 = new System.Windows.Forms.Label();
            this.MaximumPointsLabel = new System.Windows.Forms.Label();
            this.TextLabel7 = new System.Windows.Forms.Label();
            this.PointDifferenceLabel = new System.Windows.Forms.Label();
            this.TextLabel8 = new System.Windows.Forms.Label();
            this.HundredCountLabel = new System.Windows.Forms.Label();
            this.TextLabel9 = new System.Windows.Forms.Label();
            this.TotalMapsLabel = new System.Windows.Forms.Label();
            this.TextLabel10 = new System.Windows.Forms.Label();
            this.RankUpPointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerPictureLabel
            // 
            this.PlayerPictureLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.PlayerPictureLabel.Location = new System.Drawing.Point(16, 17);
            this.PlayerPictureLabel.Name = "PlayerPictureLabel";
            this.PlayerPictureLabel.Size = new System.Drawing.Size(100, 100);
            this.PlayerPictureLabel.TabIndex = 0;
            // 
            // TextLabel1
            // 
            this.TextLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel1.Location = new System.Drawing.Point(120, 52);
            this.TextLabel1.Name = "TextLabel1";
            this.TextLabel1.Size = new System.Drawing.Size(100, 23);
            this.TextLabel1.TabIndex = 1;
            this.TextLabel1.Text = "Global Rank";
            // 
            // GlobalRankLabel
            // 
            this.GlobalRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalRankLabel.Location = new System.Drawing.Point(120, 66);
            this.GlobalRankLabel.Name = "GlobalRankLabel";
            this.GlobalRankLabel.Size = new System.Drawing.Size(100, 23);
            this.GlobalRankLabel.TabIndex = 2;
            this.GlobalRankLabel.Text = "6 / 51126";
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameLabel.Location = new System.Drawing.Point(204, 52);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(100, 23);
            this.CountryNameLabel.TabIndex = 3;
            this.CountryNameLabel.Text = "Germany Rank";
            // 
            // CountryRankLabel
            // 
            this.CountryRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryRankLabel.Location = new System.Drawing.Point(204, 66);
            this.CountryRankLabel.Name = "CountryRankLabel";
            this.CountryRankLabel.Size = new System.Drawing.Size(100, 23);
            this.CountryRankLabel.TabIndex = 4;
            this.CountryRankLabel.Text = "2 / 1536";
            // 
            // TextLabel2
            // 
            this.TextLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel2.Location = new System.Drawing.Point(301, 52);
            this.TextLabel2.Name = "TextLabel2";
            this.TextLabel2.Size = new System.Drawing.Size(100, 23);
            this.TextLabel2.TabIndex = 5;
            this.TextLabel2.Text = "AVG Misses";
            // 
            // AverageMissLabel
            // 
            this.AverageMissLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageMissLabel.Location = new System.Drawing.Point(301, 66);
            this.AverageMissLabel.Name = "AverageMissLabel";
            this.AverageMissLabel.Size = new System.Drawing.Size(100, 23);
            this.AverageMissLabel.TabIndex = 6;
            this.AverageMissLabel.Text = "0,0";
            // 
            // TextLabel3
            // 
            this.TextLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel3.Location = new System.Drawing.Point(382, 52);
            this.TextLabel3.Name = "TextLabel3";
            this.TextLabel3.Size = new System.Drawing.Size(100, 23);
            this.TextLabel3.TabIndex = 7;
            this.TextLabel3.Text = "AVG Accuracy";
            // 
            // AverageAccuracyLabel
            // 
            this.AverageAccuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageAccuracyLabel.Location = new System.Drawing.Point(382, 66);
            this.AverageAccuracyLabel.Name = "AverageAccuracyLabel";
            this.AverageAccuracyLabel.Size = new System.Drawing.Size(100, 23);
            this.AverageAccuracyLabel.TabIndex = 8;
            this.AverageAccuracyLabel.Text = "99.8916%";
            // 
            // TextLabel4
            // 
            this.TextLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel4.Location = new System.Drawing.Point(479, 52);
            this.TextLabel4.Name = "TextLabel4";
            this.TextLabel4.Size = new System.Drawing.Size(100, 23);
            this.TextLabel4.TabIndex = 9;
            this.TextLabel4.Text = "Points";
            // 
            // PointsLabel
            // 
            this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLabel.Location = new System.Drawing.Point(479, 66);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(100, 23);
            this.PointsLabel.TabIndex = 10;
            this.PointsLabel.Text = "3323.5";
            // 
            // TextLabel5
            // 
            this.TextLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel5.Location = new System.Drawing.Point(16, 129);
            this.TextLabel5.Name = "TextLabel5";
            this.TextLabel5.Size = new System.Drawing.Size(100, 23);
            this.TextLabel5.TabIndex = 11;
            this.TextLabel5.Text = "Real Points";
            // 
            // RealPointsLabel
            // 
            this.RealPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealPointsLabel.Location = new System.Drawing.Point(16, 143);
            this.RealPointsLabel.Name = "RealPointsLabel";
            this.RealPointsLabel.Size = new System.Drawing.Size(100, 23);
            this.RealPointsLabel.TabIndex = 12;
            this.RealPointsLabel.Text = "3324.27";
            // 
            // TextLabel6
            // 
            this.TextLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel6.Location = new System.Drawing.Point(98, 129);
            this.TextLabel6.Name = "TextLabel6";
            this.TextLabel6.Size = new System.Drawing.Size(100, 23);
            this.TextLabel6.TabIndex = 13;
            this.TextLabel6.Text = "Max Points";
            // 
            // MaximumPointsLabel
            // 
            this.MaximumPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumPointsLabel.Location = new System.Drawing.Point(98, 143);
            this.MaximumPointsLabel.Name = "MaximumPointsLabel";
            this.MaximumPointsLabel.Size = new System.Drawing.Size(100, 23);
            this.MaximumPointsLabel.TabIndex = 14;
            this.MaximumPointsLabel.Text = "3331.36";
            // 
            // TextLabel7
            // 
            this.TextLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel7.Location = new System.Drawing.Point(179, 129);
            this.TextLabel7.Name = "TextLabel7";
            this.TextLabel7.Size = new System.Drawing.Size(100, 23);
            this.TextLabel7.TabIndex = 15;
            this.TextLabel7.Text = "Difference";
            // 
            // PointDifferenceLabel
            // 
            this.PointDifferenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointDifferenceLabel.Location = new System.Drawing.Point(179, 143);
            this.PointDifferenceLabel.Name = "PointDifferenceLabel";
            this.PointDifferenceLabel.Size = new System.Drawing.Size(100, 23);
            this.PointDifferenceLabel.TabIndex = 16;
            this.PointDifferenceLabel.Text = "7.86";
            // 
            // TextLabel8
            // 
            this.TextLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel8.Location = new System.Drawing.Point(256, 129);
            this.TextLabel8.Name = "TextLabel8";
            this.TextLabel8.Size = new System.Drawing.Size(100, 23);
            this.TextLabel8.TabIndex = 17;
            this.TextLabel8.Text = "100% Plays";
            // 
            // HundredCountLabel
            // 
            this.HundredCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HundredCountLabel.Location = new System.Drawing.Point(256, 143);
            this.HundredCountLabel.Name = "HundredCountLabel";
            this.HundredCountLabel.Size = new System.Drawing.Size(100, 23);
            this.HundredCountLabel.TabIndex = 18;
            this.HundredCountLabel.Text = "176";
            // 
            // TextLabel9
            // 
            this.TextLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel9.Location = new System.Drawing.Point(340, 129);
            this.TextLabel9.Name = "TextLabel9";
            this.TextLabel9.Size = new System.Drawing.Size(100, 23);
            this.TextLabel9.TabIndex = 19;
            this.TextLabel9.Text = "Total Maps";
            // 
            // TotalMapsLabel
            // 
            this.TotalMapsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMapsLabel.Location = new System.Drawing.Point(340, 143);
            this.TotalMapsLabel.Name = "TotalMapsLabel";
            this.TotalMapsLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalMapsLabel.TabIndex = 20;
            this.TotalMapsLabel.Text = "251";
            // 
            // TextLabel10
            // 
            this.TextLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel10.Location = new System.Drawing.Point(422, 129);
            this.TextLabel10.Name = "TextLabel10";
            this.TextLabel10.Size = new System.Drawing.Size(105, 23);
            this.TextLabel10.TabIndex = 21;
            this.TextLabel10.Text = "Points till rankup";
            // 
            // RankUpPointsLabel
            // 
            this.RankUpPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankUpPointsLabel.Location = new System.Drawing.Point(422, 143);
            this.RankUpPointsLabel.Name = "RankUpPointsLabel";
            this.RankUpPointsLabel.Size = new System.Drawing.Size(100, 23);
            this.RankUpPointsLabel.TabIndex = 22;
            this.RankUpPointsLabel.Text = "2.84";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 179);
            this.Controls.Add(this.RankUpPointsLabel);
            this.Controls.Add(this.TextLabel10);
            this.Controls.Add(this.TotalMapsLabel);
            this.Controls.Add(this.TextLabel9);
            this.Controls.Add(this.HundredCountLabel);
            this.Controls.Add(this.TextLabel8);
            this.Controls.Add(this.PointDifferenceLabel);
            this.Controls.Add(this.TextLabel7);
            this.Controls.Add(this.MaximumPointsLabel);
            this.Controls.Add(this.TextLabel6);
            this.Controls.Add(this.RealPointsLabel);
            this.Controls.Add(this.TextLabel5);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.TextLabel4);
            this.Controls.Add(this.AverageAccuracyLabel);
            this.Controls.Add(this.TextLabel3);
            this.Controls.Add(this.AverageMissLabel);
            this.Controls.Add(this.TextLabel2);
            this.Controls.Add(this.CountryRankLabel);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.GlobalRankLabel);
            this.Controls.Add(this.TextLabel1);
            this.Controls.Add(this.PlayerPictureLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserProfileForm";
            this.Text = "FormUserProfile";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label RankUpPointsLabel;

        private System.Windows.Forms.Label TextLabel10;

        private System.Windows.Forms.Label TotalMapsLabel;

        private System.Windows.Forms.Label TextLabel9;

        private System.Windows.Forms.Label HundredCountLabel;

        private System.Windows.Forms.Label TextLabel8;

        private System.Windows.Forms.Label PointDifferenceLabel;

        private System.Windows.Forms.Label TextLabel7;

        private System.Windows.Forms.Label MaximumPointsLabel;

        private System.Windows.Forms.Label TextLabel6;

        private System.Windows.Forms.Label RealPointsLabel;

        private System.Windows.Forms.Label TextLabel5;

        private System.Windows.Forms.Label PointsLabel;

        private System.Windows.Forms.Label TextLabel4;

        private System.Windows.Forms.Label AverageAccuracyLabel;

        private System.Windows.Forms.Label TextLabel3;

        private System.Windows.Forms.Label AverageMissLabel;

        private System.Windows.Forms.Label TextLabel2;

        private System.Windows.Forms.Label CountryRankLabel;

        private System.Windows.Forms.Label CountryNameLabel;

        private System.Windows.Forms.Label GlobalRankLabel;
        private System.Windows.Forms.Label TextLabel1;

        private System.Windows.Forms.Label PlayerPictureLabel;

        #endregion
    }
}