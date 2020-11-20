using System.ComponentModel;
using System.Windows.Forms;

namespace IntralismToolBox.Forms
{
    partial class AddPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayerForm));
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerLinkLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerLinkTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(100, 23);
            this.PlayerNameLabel.TabIndex = 0;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // PlayerLinkLabel
            // 
            this.PlayerLinkLabel.Location = new System.Drawing.Point(129, 9);
            this.PlayerLinkLabel.Name = "PlayerLinkLabel";
            this.PlayerLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.PlayerLinkLabel.TabIndex = 1;
            this.PlayerLinkLabel.Text = "Player Link";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerNameTextBox.TabIndex = 2;
            // 
            // PlayerLinkTextBox
            // 
            this.PlayerLinkTextBox.Location = new System.Drawing.Point(129, 25);
            this.PlayerLinkTextBox.Name = "PlayerLinkTextBox";
            this.PlayerLinkTextBox.Size = new System.Drawing.Size(179, 20);
            this.PlayerLinkTextBox.TabIndex = 3;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(12, 51);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(296, 23);
            this.AddPlayerButton.TabIndex = 4;
            this.AddPlayerButton.Text = "Add";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddClicked);
            this.AddPlayerButton.FlatStyle = FlatStyle.Flat;
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 85);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.PlayerLinkTextBox);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.PlayerLinkLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPlayerForm";
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox PlayerLinkTextBox;
        private System.Windows.Forms.TextBox PlayerNameTextBox;

        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label PlayerLinkLabel;

        #endregion
    }
}