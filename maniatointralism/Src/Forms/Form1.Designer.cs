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
            this.Convert = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.speedbox = new System.Windows.Forms.TextBox();
            this.maniaIntralismBox = new System.Windows.Forms.GroupBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.scoreCheckerBox = new System.Windows.Forms.GroupBox();
            this.playerListButton = new System.Windows.Forms.Button();
            this.lastCheckedButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.playerLinkLabel = new System.Windows.Forms.Label();
            this.playerLinkText = new System.Windows.Forms.TextBox();
            this.maniaIntralismBox.SuspendLayout();
            this.scoreCheckerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maniaselect
            // 
            this.maniaSelect.Location = new System.Drawing.Point(6, 19);
            this.maniaSelect.Name = "maniaSelect";
            this.maniaSelect.Size = new System.Drawing.Size(95, 26);
            this.maniaSelect.TabIndex = 0;
            this.maniaSelect.Text = "Mania Map";
            this.maniaSelect.UseMnemonic = false;
            this.maniaSelect.UseVisualStyleBackColor = true;
            this.maniaSelect.Click += new System.EventHandler(this.ManiaClicked);
            // 
            // editorselect
            // 
            this.editorSelect.Location = new System.Drawing.Point(107, 19);
            this.editorSelect.Name = "editorSelect";
            this.editorSelect.Size = new System.Drawing.Size(100, 26);
            this.editorSelect.TabIndex = 1;
            this.editorSelect.Text = "Editor Folder";
            this.editorSelect.UseVisualStyleBackColor = true;
            this.editorSelect.Click += new System.EventHandler(this.EditorClicked);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(107, 60);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(100, 26);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.ConvertClicked);
            // 
            // lbl
            // 
            this.label.Location = new System.Drawing.Point(6, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 15);
            this.label.TabIndex = 3;
            this.label.Text = "Speed";
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
            this.maniaIntralismBox.Controls.Add(this.Convert);
            this.maniaIntralismBox.Controls.Add(this.speedbox);
            this.maniaIntralismBox.Controls.Add(this.editorSelect);
            this.maniaIntralismBox.Controls.Add(this.label);
            this.maniaIntralismBox.Location = new System.Drawing.Point(12, 12);
            this.maniaIntralismBox.Name = "maniaIntralismBox";
            this.maniaIntralismBox.Size = new System.Drawing.Size(215, 96);
            this.maniaIntralismBox.TabIndex = 5;
            this.maniaIntralismBox.TabStop = false;
            this.maniaIntralismBox.Text = "Mania To Intralism Converter";
            // 
            // settingbtn
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
            // playerListBtn
            // 
            this.playerListButton.Location = new System.Drawing.Point(191, 60);
            this.playerListButton.Name = "playerListButton";
            this.playerListButton.Size = new System.Drawing.Size(87, 26);
            this.playerListButton.TabIndex = 4;
            this.playerListButton.Text = "Player List";
            this.playerListButton.UseVisualStyleBackColor = true;
            this.playerListButton.Click += new System.EventHandler(this.PlayerListClicked);
            // 
            // lastCheckedBtn
            // 
            this.lastCheckedButton.Location = new System.Drawing.Point(91, 60);
            this.lastCheckedButton.Name = "lastCheckedButton";
            this.lastCheckedButton.Size = new System.Drawing.Size(94, 26);
            this.lastCheckedButton.TabIndex = 3;
            this.lastCheckedButton.Text = "Last Checked";
            this.lastCheckedButton.UseVisualStyleBackColor = true;
            this.lastCheckedButton.Click += new System.EventHandler(this.LastCheckedClicked);
            // 
            // checkBtn
            // 
            this.checkButton.Location = new System.Drawing.Point(6, 60);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(79, 26);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckClicked);
            // 
            // playerLinkLbl
            // 
            this.playerLinkLabel.Location = new System.Drawing.Point(6, 19);
            this.playerLinkLabel.Name = "playerLinkLabel";
            this.playerLinkLabel.Size = new System.Drawing.Size(79, 12);
            this.playerLinkLabel.TabIndex = 1;
            this.playerLinkLabel.Text = "Player Link";
            // 
            // playerLinkTxt
            // 
            this.playerLinkText.Location = new System.Drawing.Point(6, 34);
            this.playerLinkText.Name = "playerLinkText";
            this.playerLinkText.Size = new System.Drawing.Size(272, 20);
            this.playerLinkText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 356);
            this.Controls.Add(this.scoreCheckerBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.maniaIntralismBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Intralism Toolbox";
            this.maniaIntralismBox.ResumeLayout(false);
            this.maniaIntralismBox.PerformLayout();
            this.scoreCheckerBox.ResumeLayout(false);
            this.scoreCheckerBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox playerLinkText;
        private System.Windows.Forms.Button playerListButton;

        private System.Windows.Forms.Button lastCheckedButton;

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label playerLinkLabel;
        private System.Windows.Forms.GroupBox scoreCheckerBox;

        private System.Windows.Forms.Button settingsButton;

        private System.Windows.Forms.GroupBox maniaIntralismBox;

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox speedbox;

        private System.Windows.Forms.Button editorSelect;
        private System.Windows.Forms.Button maniaSelect;

        #endregion
    }
}