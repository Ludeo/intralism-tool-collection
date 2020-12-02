using System.ComponentModel;

namespace IntralismToolBox.Forms
{
    partial class StatisticsPlayerListForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsPlayerListForm));
            this.PlayerListListBox = new System.Windows.Forms.ListBox();
            this.ShowStatisticsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerListListBox
            // 
            this.PlayerListListBox.FormattingEnabled = true;
            this.PlayerListListBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerListListBox.Name = "PlayerListListBox";
            this.PlayerListListBox.Size = new System.Drawing.Size(156, 329);
            this.PlayerListListBox.TabIndex = 1;
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowStatisticsButton.Location = new System.Drawing.Point(41, 347);
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.Size = new System.Drawing.Size(90, 23);
            this.ShowStatisticsButton.TabIndex = 2;
            this.ShowStatisticsButton.Text = "Show Statistics";
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsClicked);
            // 
            // StatisticsPlayerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 377);
            this.Controls.Add(this.ShowStatisticsButton);
            this.Controls.Add(this.PlayerListListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatisticsPlayerListForm";
            this.Text = "Player List";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ShowStatisticsButton;

        private System.Windows.Forms.ListBox PlayerListListBox;

        #endregion
    }
}