using System.ComponentModel;

namespace IntralismToolBox.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectManiaMapButton = new System.Windows.Forms.Button();
            this.SelectEditorFolderButton = new System.Windows.Forms.Button();
            this.ConvertToIntralismButton = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.ManiaToIntralismGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ScoreCheckerGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerListButton = new System.Windows.Forms.Button();
            this.LastCheckedPlayerButton = new System.Windows.Forms.Button();
            this.CheckPlayerButton = new System.Windows.Forms.Button();
            this.PlayerLinkLabel = new System.Windows.Forms.Label();
            this.PlayerLinkTextBox = new System.Windows.Forms.TextBox();
            this.IntralismToManiaGroupBox = new System.Windows.Forms.GroupBox();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.OffsetTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToManiaButton = new System.Windows.Forms.Button();
            this.SelectManiaSongFolderButton = new System.Windows.Forms.Button();
            this.SelectIntralismMapButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.ManiaToIntralismGroupBox.SuspendLayout();
            this.ScoreCheckerGroupBox.SuspendLayout();
            this.IntralismToManiaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maniaSelect
            // 
            this.SelectManiaMapButton.Location = new System.Drawing.Point(6, 19);
            this.SelectManiaMapButton.Name = "SelectManiaMapButton";
            this.SelectManiaMapButton.Size = new System.Drawing.Size(95, 26);
            this.SelectManiaMapButton.TabIndex = 0;
            this.SelectManiaMapButton.Text = "Mania Map";
            this.SelectManiaMapButton.UseMnemonic = false;
            this.SelectManiaMapButton.UseVisualStyleBackColor = true;
            this.SelectManiaMapButton.Click += new System.EventHandler(this.ManiaMapClicked);
            // 
            // editorSelect
            // 
            this.SelectEditorFolderButton.Location = new System.Drawing.Point(107, 19);
            this.SelectEditorFolderButton.Name = "SelectEditorFolderButton";
            this.SelectEditorFolderButton.Size = new System.Drawing.Size(100, 26);
            this.SelectEditorFolderButton.TabIndex = 1;
            this.SelectEditorFolderButton.Text = "Editor Folder";
            this.SelectEditorFolderButton.UseVisualStyleBackColor = true;
            this.SelectEditorFolderButton.Click += new System.EventHandler(this.EditorFolderClicked);
            // 
            // ConvertToIntralism
            // 
            this.ConvertToIntralismButton.Location = new System.Drawing.Point(107, 60);
            this.ConvertToIntralismButton.Name = "ConvertToIntralismButton";
            this.ConvertToIntralismButton.Size = new System.Drawing.Size(100, 26);
            this.ConvertToIntralismButton.TabIndex = 2;
            this.ConvertToIntralismButton.Text = "Convert";
            this.ConvertToIntralismButton.UseVisualStyleBackColor = true;
            this.ConvertToIntralismButton.Click += new System.EventHandler(this.ConvertToIntralismClicked);
            // 
            // speedLabel
            // 
            this.SpeedLabel.Location = new System.Drawing.Point(6, 48);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(43, 15);
            this.SpeedLabel.TabIndex = 3;
            this.SpeedLabel.Text = "Speed";
            // 
            // speedbox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(6, 64);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(95, 20);
            this.SpeedTextBox.TabIndex = 4;
            this.SpeedTextBox.Text = "25";
            // 
            // maniaIntralismBox
            // 
            this.ManiaToIntralismGroupBox.Controls.Add(this.SelectManiaMapButton);
            this.ManiaToIntralismGroupBox.Controls.Add(this.ConvertToIntralismButton);
            this.ManiaToIntralismGroupBox.Controls.Add(this.SpeedTextBox);
            this.ManiaToIntralismGroupBox.Controls.Add(this.SelectEditorFolderButton);
            this.ManiaToIntralismGroupBox.Controls.Add(this.SpeedLabel);
            this.ManiaToIntralismGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ManiaToIntralismGroupBox.Name = "ManiaToIntralismGroupBox";
            this.ManiaToIntralismGroupBox.Size = new System.Drawing.Size(215, 96);
            this.ManiaToIntralismGroupBox.TabIndex = 5;
            this.ManiaToIntralismGroupBox.TabStop = false;
            this.ManiaToIntralismGroupBox.Text = "Mania To Intralism Converter";
            // 
            // settingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(534, 321);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(96, 23);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.OpenSetting);
            // 
            // scoreCheckerBox
            // 
            this.ScoreCheckerGroupBox.Controls.Add(this.PlayerListButton);
            this.ScoreCheckerGroupBox.Controls.Add(this.LastCheckedPlayerButton);
            this.ScoreCheckerGroupBox.Controls.Add(this.CheckPlayerButton);
            this.ScoreCheckerGroupBox.Controls.Add(this.PlayerLinkLabel);
            this.ScoreCheckerGroupBox.Controls.Add(this.PlayerLinkTextBox);
            this.ScoreCheckerGroupBox.Location = new System.Drawing.Point(233, 12);
            this.ScoreCheckerGroupBox.Name = "ScoreCheckerGroupBox";
            this.ScoreCheckerGroupBox.Size = new System.Drawing.Size(284, 96);
            this.ScoreCheckerGroupBox.TabIndex = 7;
            this.ScoreCheckerGroupBox.TabStop = false;
            this.ScoreCheckerGroupBox.Text = "Score Checker";
            // 
            // playerListButton
            // 
            this.PlayerListButton.Location = new System.Drawing.Point(191, 60);
            this.PlayerListButton.Name = "PlayerListButton";
            this.PlayerListButton.Size = new System.Drawing.Size(87, 26);
            this.PlayerListButton.TabIndex = 4;
            this.PlayerListButton.Text = "Player List";
            this.PlayerListButton.UseVisualStyleBackColor = true;
            this.PlayerListButton.Click += new System.EventHandler(this.PlayerListClicked);
            // 
            // lastCheckedButton
            // 
            this.LastCheckedPlayerButton.Location = new System.Drawing.Point(91, 60);
            this.LastCheckedPlayerButton.Name = "LastCheckedPlayerButton";
            this.LastCheckedPlayerButton.Size = new System.Drawing.Size(94, 26);
            this.LastCheckedPlayerButton.TabIndex = 3;
            this.LastCheckedPlayerButton.Text = "Last Checked";
            this.LastCheckedPlayerButton.UseVisualStyleBackColor = true;
            this.LastCheckedPlayerButton.Click += new System.EventHandler(this.LastCheckedClicked);
            // 
            // checkButton
            // 
            this.CheckPlayerButton.Location = new System.Drawing.Point(6, 60);
            this.CheckPlayerButton.Name = "CheckPlayerButton";
            this.CheckPlayerButton.Size = new System.Drawing.Size(79, 26);
            this.CheckPlayerButton.TabIndex = 2;
            this.CheckPlayerButton.Text = "Check";
            this.CheckPlayerButton.UseVisualStyleBackColor = true;
            this.CheckPlayerButton.Click += new System.EventHandler(this.CheckClicked);
            // 
            // playerLinkLabel
            // 
            this.PlayerLinkLabel.Location = new System.Drawing.Point(6, 19);
            this.PlayerLinkLabel.Name = "PlayerLinkLabel";
            this.PlayerLinkLabel.Size = new System.Drawing.Size(79, 12);
            this.PlayerLinkLabel.TabIndex = 1;
            this.PlayerLinkLabel.Text = "Player Link";
            // 
            // playerLinkText
            // 
            this.PlayerLinkTextBox.Location = new System.Drawing.Point(6, 34);
            this.PlayerLinkTextBox.Name = "PlayerLinkTextBox";
            this.PlayerLinkTextBox.Size = new System.Drawing.Size(272, 20);
            this.PlayerLinkTextBox.TabIndex = 0;
            // 
            // intralismManiaBox
            // 
            this.IntralismToManiaGroupBox.Controls.Add(this.OffsetLabel);
            this.IntralismToManiaGroupBox.Controls.Add(this.OffsetTextBox);
            this.IntralismToManiaGroupBox.Controls.Add(this.ConvertToManiaButton);
            this.IntralismToManiaGroupBox.Controls.Add(this.SelectManiaSongFolderButton);
            this.IntralismToManiaGroupBox.Controls.Add(this.SelectIntralismMapButton);
            this.IntralismToManiaGroupBox.Location = new System.Drawing.Point(12, 114);
            this.IntralismToManiaGroupBox.Name = "IntralismToManiaGroupBox";
            this.IntralismToManiaGroupBox.Size = new System.Drawing.Size(215, 93);
            this.IntralismToManiaGroupBox.TabIndex = 8;
            this.IntralismToManiaGroupBox.TabStop = false;
            this.IntralismToManiaGroupBox.Text = "Intralism To Mania Converter";
            // 
            // offsetLabel
            // 
            this.OffsetLabel.Location = new System.Drawing.Point(6, 47);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(50, 11);
            this.OffsetLabel.TabIndex = 4;
            this.OffsetLabel.Text = "Offset";
            // 
            // offsetBox
            // 
            this.OffsetTextBox.Location = new System.Drawing.Point(6, 61);
            this.OffsetTextBox.Name = "OffsetTextBox";
            this.OffsetTextBox.Size = new System.Drawing.Size(94, 20);
            this.OffsetTextBox.TabIndex = 3;
            this.OffsetTextBox.Text = "40";
            // 
            // ConvertToMania
            // 
            this.ConvertToManiaButton.Location = new System.Drawing.Point(107, 57);
            this.ConvertToManiaButton.Name = "ConvertToManiaButton";
            this.ConvertToManiaButton.Size = new System.Drawing.Size(100, 26);
            this.ConvertToManiaButton.TabIndex = 2;
            this.ConvertToManiaButton.Text = "Convert";
            this.ConvertToManiaButton.UseVisualStyleBackColor = true;
            this.ConvertToManiaButton.Click += new System.EventHandler(this.ConvertToManiaClicked);
            // 
            // maniaFolderSelect
            // 
            this.SelectManiaSongFolderButton.Location = new System.Drawing.Point(107, 19);
            this.SelectManiaSongFolderButton.Name = "SelectManiaSongFolderButton";
            this.SelectManiaSongFolderButton.Size = new System.Drawing.Size(100, 25);
            this.SelectManiaSongFolderButton.TabIndex = 1;
            this.SelectManiaSongFolderButton.Text = "Mania Folder";
            this.SelectManiaSongFolderButton.UseVisualStyleBackColor = true;
            this.SelectManiaSongFolderButton.Click += new System.EventHandler(this.ManiaFolderClicked);
            // 
            // intralismSelect
            // 
            this.SelectIntralismMapButton.Location = new System.Drawing.Point(6, 19);
            this.SelectIntralismMapButton.Name = "SelectIntralismMapButton";
            this.SelectIntralismMapButton.Size = new System.Drawing.Size(95, 25);
            this.SelectIntralismMapButton.TabIndex = 0;
            this.SelectIntralismMapButton.Text = "Intralism Map";
            this.SelectIntralismMapButton.UseVisualStyleBackColor = true;
            this.SelectIntralismMapButton.Click += new System.EventHandler(this.IntralismMapClicked);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(332, 188);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.TestButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 356);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.IntralismToManiaGroupBox);
            this.Controls.Add(this.ScoreCheckerGroupBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ManiaToIntralismGroupBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Intralism Toolbox";
            this.ManiaToIntralismGroupBox.ResumeLayout(false);
            this.ManiaToIntralismGroupBox.PerformLayout();
            this.ScoreCheckerGroupBox.ResumeLayout(false);
            this.ScoreCheckerGroupBox.PerformLayout();
            this.IntralismToManiaGroupBox.ResumeLayout(false);
            this.IntralismToManiaGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button testButton;

        private System.Windows.Forms.TextBox OffsetTextBox;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.Label SpeedLabel;

        private System.Windows.Forms.Button ConvertToIntralismButton;
        private System.Windows.Forms.Button ConvertToManiaButton;
        private System.Windows.Forms.GroupBox IntralismToManiaGroupBox;
        private System.Windows.Forms.Button SelectIntralismMapButton;
        private System.Windows.Forms.Button SelectManiaSongFolderButton;

        private System.Windows.Forms.TextBox PlayerLinkTextBox;
        private System.Windows.Forms.Button PlayerListButton;

        private System.Windows.Forms.Button LastCheckedPlayerButton;

        private System.Windows.Forms.Button CheckPlayerButton;
        private System.Windows.Forms.Label PlayerLinkLabel;
        private System.Windows.Forms.GroupBox ScoreCheckerGroupBox;

        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.GroupBox ManiaToIntralismGroupBox;

        private System.Windows.Forms.TextBox SpeedTextBox;

        private System.Windows.Forms.Button SelectEditorFolderButton;
        private System.Windows.Forms.Button SelectManiaMapButton;

        #endregion
    }
}