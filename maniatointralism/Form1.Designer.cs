namespace maniatointralism
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maniaselect = new System.Windows.Forms.Button();
            this.editorselect = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.speedbox = new System.Windows.Forms.TextBox();
            this.maniaIntralismBox = new System.Windows.Forms.GroupBox();
            this.settingbtn = new System.Windows.Forms.Button();
            this.scoreCheckerBox = new System.Windows.Forms.GroupBox();
            this.playerListBtn = new System.Windows.Forms.Button();
            this.lastCheckedBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.playerLinkLbl = new System.Windows.Forms.Label();
            this.playerLinkTxt = new System.Windows.Forms.TextBox();
            this.maniaIntralismBox.SuspendLayout();
            this.scoreCheckerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maniaselect
            // 
            this.maniaselect.Location = new System.Drawing.Point(6, 19);
            this.maniaselect.Name = "maniaselect";
            this.maniaselect.Size = new System.Drawing.Size(95, 26);
            this.maniaselect.TabIndex = 0;
            this.maniaselect.Text = "Mania Map";
            this.maniaselect.UseMnemonic = false;
            this.maniaselect.UseVisualStyleBackColor = true;
            this.maniaselect.Click += new System.EventHandler(this.Maniaclicked);
            // 
            // editorselect
            // 
            this.editorselect.Location = new System.Drawing.Point(107, 19);
            this.editorselect.Name = "editorselect";
            this.editorselect.Size = new System.Drawing.Size(100, 26);
            this.editorselect.TabIndex = 1;
            this.editorselect.Text = "Editor Folder";
            this.editorselect.UseVisualStyleBackColor = true;
            this.editorselect.Click += new System.EventHandler(this.EditorClicked);
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
            this.lbl.Location = new System.Drawing.Point(6, 48);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 15);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Speed";
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
            this.maniaIntralismBox.Controls.Add(this.maniaselect);
            this.maniaIntralismBox.Controls.Add(this.Convert);
            this.maniaIntralismBox.Controls.Add(this.speedbox);
            this.maniaIntralismBox.Controls.Add(this.editorselect);
            this.maniaIntralismBox.Controls.Add(this.lbl);
            this.maniaIntralismBox.Location = new System.Drawing.Point(12, 12);
            this.maniaIntralismBox.Name = "maniaIntralismBox";
            this.maniaIntralismBox.Size = new System.Drawing.Size(215, 96);
            this.maniaIntralismBox.TabIndex = 5;
            this.maniaIntralismBox.TabStop = false;
            this.maniaIntralismBox.Text = "Mania To Intralism Converter";
            // 
            // settingbtn
            // 
            this.settingbtn.Location = new System.Drawing.Point(534, 321);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(96, 23);
            this.settingbtn.TabIndex = 6;
            this.settingbtn.Text = "Settings";
            this.settingbtn.UseVisualStyleBackColor = true;
            this.settingbtn.Click += new System.EventHandler(this.OpenSetting);
            // 
            // scoreCheckerBox
            // 
            this.scoreCheckerBox.Controls.Add(this.playerListBtn);
            this.scoreCheckerBox.Controls.Add(this.lastCheckedBtn);
            this.scoreCheckerBox.Controls.Add(this.checkBtn);
            this.scoreCheckerBox.Controls.Add(this.playerLinkLbl);
            this.scoreCheckerBox.Controls.Add(this.playerLinkTxt);
            this.scoreCheckerBox.Location = new System.Drawing.Point(233, 12);
            this.scoreCheckerBox.Name = "scoreCheckerBox";
            this.scoreCheckerBox.Size = new System.Drawing.Size(284, 96);
            this.scoreCheckerBox.TabIndex = 7;
            this.scoreCheckerBox.TabStop = false;
            this.scoreCheckerBox.Text = "Score Checker";
            // 
            // playerListBtn
            // 
            this.playerListBtn.Location = new System.Drawing.Point(191, 60);
            this.playerListBtn.Name = "playerListBtn";
            this.playerListBtn.Size = new System.Drawing.Size(87, 26);
            this.playerListBtn.TabIndex = 4;
            this.playerListBtn.Text = "Player List";
            this.playerListBtn.UseVisualStyleBackColor = true;
            this.playerListBtn.Click += new System.EventHandler(this.PlayerListClicked);
            // 
            // lastCheckedBtn
            // 
            this.lastCheckedBtn.Location = new System.Drawing.Point(91, 60);
            this.lastCheckedBtn.Name = "lastCheckedBtn";
            this.lastCheckedBtn.Size = new System.Drawing.Size(94, 26);
            this.lastCheckedBtn.TabIndex = 3;
            this.lastCheckedBtn.Text = "Last Checked";
            this.lastCheckedBtn.UseVisualStyleBackColor = true;
            this.lastCheckedBtn.Click += new System.EventHandler(this.LastCheckedClicked);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(6, 60);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(79, 26);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.CheckClicked);
            // 
            // playerLinkLbl
            // 
            this.playerLinkLbl.Location = new System.Drawing.Point(6, 19);
            this.playerLinkLbl.Name = "playerLinkLbl";
            this.playerLinkLbl.Size = new System.Drawing.Size(79, 12);
            this.playerLinkLbl.TabIndex = 1;
            this.playerLinkLbl.Text = "Player Link";
            // 
            // playerLinkTxt
            // 
            this.playerLinkTxt.Location = new System.Drawing.Point(6, 34);
            this.playerLinkTxt.Name = "playerLinkTxt";
            this.playerLinkTxt.Size = new System.Drawing.Size(272, 20);
            this.playerLinkTxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 356);
            this.Controls.Add(this.scoreCheckerBox);
            this.Controls.Add(this.settingbtn);
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

        private System.Windows.Forms.TextBox playerLinkTxt;
        private System.Windows.Forms.Button playerListBtn;

        private System.Windows.Forms.Button lastCheckedBtn;

        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label playerLinkLbl;
        private System.Windows.Forms.GroupBox scoreCheckerBox;

        private System.Windows.Forms.Button settingbtn;

        private System.Windows.Forms.GroupBox maniaIntralismBox;

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox speedbox;

        private System.Windows.Forms.Button editorselect;
        private System.Windows.Forms.Button maniaselect;

        #endregion
    }
}