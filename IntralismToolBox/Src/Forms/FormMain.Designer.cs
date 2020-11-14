using System.ComponentModel;

namespace ManiaToIntralism.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maniaSelect = new System.Windows.Forms.Button();
            this.editorSelect = new System.Windows.Forms.Button();
            this.ConvertToIntralism = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedbox = new System.Windows.Forms.TextBox();
            this.maniaIntralismBox = new System.Windows.Forms.GroupBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.scoreCheckerBox = new System.Windows.Forms.GroupBox();
            this.playerListButton = new System.Windows.Forms.Button();
            this.lastCheckedButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.playerLinkLabel = new System.Windows.Forms.Label();
            this.playerLinkText = new System.Windows.Forms.TextBox();
            this.intralismManiaBox = new System.Windows.Forms.GroupBox();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.offsetBox = new System.Windows.Forms.TextBox();
            this.ConvertToMania = new System.Windows.Forms.Button();
            this.maniaFolderSelect = new System.Windows.Forms.Button();
            this.intralismSelect = new System.Windows.Forms.Button();
            this.maniaIntralismBox.SuspendLayout();
            this.scoreCheckerBox.SuspendLayout();
            this.intralismManiaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maniaSelect
            // 
            this.maniaSelect.Location = new System.Drawing.Point(6, 19);
            this.maniaSelect.Name = "maniaSelect";
            this.maniaSelect.Size = new System.Drawing.Size(95, 26);
            this.maniaSelect.TabIndex = 0;
            this.maniaSelect.Text = "Mania Map";
            this.maniaSelect.UseMnemonic = false;
            this.maniaSelect.UseVisualStyleBackColor = true;
            this.maniaSelect.Click += new System.EventHandler(this.ManiaMapClicked);
            // 
            // editorSelect
            // 
            this.editorSelect.Location = new System.Drawing.Point(107, 19);
            this.editorSelect.Name = "editorSelect";
            this.editorSelect.Size = new System.Drawing.Size(100, 26);
            this.editorSelect.TabIndex = 1;
            this.editorSelect.Text = "Editor Folder";
            this.editorSelect.UseVisualStyleBackColor = true;
            this.editorSelect.Click += new System.EventHandler(this.EditorFolderClicked);
            // 
            // ConvertToIntralism
            // 
            this.ConvertToIntralism.Location = new System.Drawing.Point(107, 60);
            this.ConvertToIntralism.Name = "ConvertToIntralism";
            this.ConvertToIntralism.Size = new System.Drawing.Size(100, 26);
            this.ConvertToIntralism.TabIndex = 2;
            this.ConvertToIntralism.Text = "Convert";
            this.ConvertToIntralism.UseVisualStyleBackColor = true;
            this.ConvertToIntralism.Click += new System.EventHandler(this.ConvertToIntralismClicked);
            // 
            // speedLabel
            // 
            this.speedLabel.Location = new System.Drawing.Point(6, 48);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(43, 15);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed";
            // 
            // speedbox
            // 
            this.speedbox.Location = new System.Drawing.Point(6, 64);
            this.speedbox.Name = "speedbox";
            this.speedbox.Size = new System.Drawing.Size(95, 20);
            this.speedbox.TabIndex = 4;
            this.speedbox.Text = "25";
            // 
            // maniaIntralismBox
            // 
            this.maniaIntralismBox.Controls.Add(this.maniaSelect);
            this.maniaIntralismBox.Controls.Add(this.ConvertToIntralism);
            this.maniaIntralismBox.Controls.Add(this.speedbox);
            this.maniaIntralismBox.Controls.Add(this.editorSelect);
            this.maniaIntralismBox.Controls.Add(this.speedLabel);
            this.maniaIntralismBox.Location = new System.Drawing.Point(12, 12);
            this.maniaIntralismBox.Name = "maniaIntralismBox";
            this.maniaIntralismBox.Size = new System.Drawing.Size(215, 96);
            this.maniaIntralismBox.TabIndex = 5;
            this.maniaIntralismBox.TabStop = false;
            this.maniaIntralismBox.Text = "Mania To Intralism Converter";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(534, 321);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(96, 23);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.OpenSetting);
            // 
            // scoreCheckerBox
            // 
            this.scoreCheckerBox.Controls.Add(this.playerListButton);
            this.scoreCheckerBox.Controls.Add(this.lastCheckedButton);
            this.scoreCheckerBox.Controls.Add(this.checkButton);
            this.scoreCheckerBox.Controls.Add(this.playerLinkLabel);
            this.scoreCheckerBox.Controls.Add(this.playerLinkText);
            this.scoreCheckerBox.Location = new System.Drawing.Point(233, 12);
            this.scoreCheckerBox.Name = "scoreCheckerBox";
            this.scoreCheckerBox.Size = new System.Drawing.Size(284, 96);
            this.scoreCheckerBox.TabIndex = 7;
            this.scoreCheckerBox.TabStop = false;
            this.scoreCheckerBox.Text = "Score Checker";
            // 
            // playerListButton
            // 
            this.playerListButton.Location = new System.Drawing.Point(191, 60);
            this.playerListButton.Name = "playerListButton";
            this.playerListButton.Size = new System.Drawing.Size(87, 26);
            this.playerListButton.TabIndex = 4;
            this.playerListButton.Text = "Player List";
            this.playerListButton.UseVisualStyleBackColor = true;
            this.playerListButton.Click += new System.EventHandler(this.PlayerListClicked);
            // 
            // lastCheckedButton
            // 
            this.lastCheckedButton.Location = new System.Drawing.Point(91, 60);
            this.lastCheckedButton.Name = "lastCheckedButton";
            this.lastCheckedButton.Size = new System.Drawing.Size(94, 26);
            this.lastCheckedButton.TabIndex = 3;
            this.lastCheckedButton.Text = "Last Checked";
            this.lastCheckedButton.UseVisualStyleBackColor = true;
            this.lastCheckedButton.Click += new System.EventHandler(this.LastCheckedClicked);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(6, 60);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(79, 26);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckClicked);
            // 
            // playerLinkLabel
            // 
            this.playerLinkLabel.Location = new System.Drawing.Point(6, 19);
            this.playerLinkLabel.Name = "playerLinkLabel";
            this.playerLinkLabel.Size = new System.Drawing.Size(79, 12);
            this.playerLinkLabel.TabIndex = 1;
            this.playerLinkLabel.Text = "Player Link";
            // 
            // playerLinkText
            // 
            this.playerLinkText.Location = new System.Drawing.Point(6, 34);
            this.playerLinkText.Name = "playerLinkText";
            this.playerLinkText.Size = new System.Drawing.Size(272, 20);
            this.playerLinkText.TabIndex = 0;
            // 
            // intralismManiaBox
            // 
            this.intralismManiaBox.Controls.Add(this.offsetLabel);
            this.intralismManiaBox.Controls.Add(this.offsetBox);
            this.intralismManiaBox.Controls.Add(this.ConvertToMania);
            this.intralismManiaBox.Controls.Add(this.maniaFolderSelect);
            this.intralismManiaBox.Controls.Add(this.intralismSelect);
            this.intralismManiaBox.Location = new System.Drawing.Point(12, 114);
            this.intralismManiaBox.Name = "intralismManiaBox";
            this.intralismManiaBox.Size = new System.Drawing.Size(215, 93);
            this.intralismManiaBox.TabIndex = 8;
            this.intralismManiaBox.TabStop = false;
            this.intralismManiaBox.Text = "Intralism To Mania Converter";
            // 
            // offsetLabel
            // 
            this.offsetLabel.Location = new System.Drawing.Point(6, 47);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(50, 11);
            this.offsetLabel.TabIndex = 4;
            this.offsetLabel.Text = "Offset";
            // 
            // offsetBox
            // 
            this.offsetBox.Location = new System.Drawing.Point(6, 61);
            this.offsetBox.Name = "offsetBox";
            this.offsetBox.Size = new System.Drawing.Size(94, 20);
            this.offsetBox.TabIndex = 3;
            this.offsetBox.Text = "40";
            // 
            // ConvertToMania
            // 
            this.ConvertToMania.Location = new System.Drawing.Point(107, 57);
            this.ConvertToMania.Name = "ConvertToMania";
            this.ConvertToMania.Size = new System.Drawing.Size(100, 26);
            this.ConvertToMania.TabIndex = 2;
            this.ConvertToMania.Text = "Convert";
            this.ConvertToMania.UseVisualStyleBackColor = true;
            this.ConvertToMania.Click += new System.EventHandler(this.ConvertToManiaClicked);
            // 
            // maniaFolderSelect
            // 
            this.maniaFolderSelect.Location = new System.Drawing.Point(107, 19);
            this.maniaFolderSelect.Name = "maniaFolderSelect";
            this.maniaFolderSelect.Size = new System.Drawing.Size(100, 25);
            this.maniaFolderSelect.TabIndex = 1;
            this.maniaFolderSelect.Text = "Mania Folder";
            this.maniaFolderSelect.UseVisualStyleBackColor = true;
            this.maniaFolderSelect.Click += new System.EventHandler(this.ManiaFolderClicked);
            // 
            // intralismSelect
            // 
            this.intralismSelect.Location = new System.Drawing.Point(6, 19);
            this.intralismSelect.Name = "intralismSelect";
            this.intralismSelect.Size = new System.Drawing.Size(95, 25);
            this.intralismSelect.TabIndex = 0;
            this.intralismSelect.Text = "Intralism Map";
            this.intralismSelect.UseVisualStyleBackColor = true;
            this.intralismSelect.Click += new System.EventHandler(this.IntralismMapClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 356);
            this.Controls.Add(this.intralismManiaBox);
            this.Controls.Add(this.scoreCheckerBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.maniaIntralismBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Intralism Toolbox";
            this.maniaIntralismBox.ResumeLayout(false);
            this.maniaIntralismBox.PerformLayout();
            this.scoreCheckerBox.ResumeLayout(false);
            this.scoreCheckerBox.PerformLayout();
            this.intralismManiaBox.ResumeLayout(false);
            this.intralismManiaBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox offsetBox;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.Label speedLabel;

        private System.Windows.Forms.Button ConvertToIntralism;
        private System.Windows.Forms.Button ConvertToMania;
        private System.Windows.Forms.GroupBox intralismManiaBox;
        private System.Windows.Forms.Button intralismSelect;
        private System.Windows.Forms.Button maniaFolderSelect;

        private System.Windows.Forms.TextBox playerLinkText;
        private System.Windows.Forms.Button playerListButton;

        private System.Windows.Forms.Button lastCheckedButton;

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label playerLinkLabel;
        private System.Windows.Forms.GroupBox scoreCheckerBox;

        private System.Windows.Forms.Button settingsButton;

        private System.Windows.Forms.GroupBox maniaIntralismBox;

        private System.Windows.Forms.TextBox speedbox;

        private System.Windows.Forms.Button editorSelect;
        private System.Windows.Forms.Button maniaSelect;

        #endregion
    }
}