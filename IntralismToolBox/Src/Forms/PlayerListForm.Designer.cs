using System.ComponentModel;

namespace ManiaToIntralism.Forms
{
    partial class PlayerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerListForm));
            this.PlayerListListBox = new System.Windows.Forms.ListBox();
            this.CheckPlayerButton = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.RemovePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerList
            // 
            this.PlayerListListBox.FormattingEnabled = true;
            this.PlayerListListBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerListListBox.Name = "PlayerListListBox";
            this.PlayerListListBox.Size = new System.Drawing.Size(156, 329);
            this.PlayerListListBox.TabIndex = 0;
            // 
            // checkBtn
            // 
            this.CheckPlayerButton.Location = new System.Drawing.Point(12, 353);
            this.CheckPlayerButton.Name = "CheckPlayerButton";
            this.CheckPlayerButton.Size = new System.Drawing.Size(156, 25);
            this.CheckPlayerButton.TabIndex = 1;
            this.CheckPlayerButton.Text = "Check";
            this.CheckPlayerButton.UseVisualStyleBackColor = true;
            this.CheckPlayerButton.Click += new System.EventHandler(this.CheckClicked);
            // 
            // addBtn
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(12, 384);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(76, 23);
            this.AddPlayerButton.TabIndex = 2;
            this.AddPlayerButton.Text = "Add";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddClicked);
            // 
            // removeBtn
            // 
            this.RemovePlayerButton.Location = new System.Drawing.Point(93, 384);
            this.RemovePlayerButton.Name = "RemovePlayerButton";
            this.RemovePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.RemovePlayerButton.TabIndex = 3;
            this.RemovePlayerButton.Text = "Remove";
            this.RemovePlayerButton.UseVisualStyleBackColor = true;
            this.RemovePlayerButton.Click += new System.EventHandler(this.RemoveClicked);
            // 
            // FormPlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 419);
            this.Controls.Add(this.RemovePlayerButton);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.CheckPlayerButton);
            this.Controls.Add(this.PlayerListListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerListForm";
            this.Text = "Player List";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Button CheckPlayerButton;
        private System.Windows.Forms.Button RemovePlayerButton;

        private System.Windows.Forms.ListBox PlayerListListBox;

        #endregion
    }
}