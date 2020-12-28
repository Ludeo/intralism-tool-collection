using System.ComponentModel;

namespace IntralismToolBox.Forms
{
    partial class MapEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventConfig = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultConfig = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultViewTextBox = new System.Windows.Forms.RichTextBox();
            this.splitConfigs = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StoryBoardTextBox = new System.Windows.Forms.RichTextBox();
            this.ArcSpawnTextBox = new System.Windows.Forms.RichTextBox();
            this.ZoomEventTextBox = new System.Windows.Forms.RichTextBox();
            this.SpeedEventTextBox = new System.Windows.Forms.RichTextBox();
            this.resizeNS = new System.Windows.Forms.Panel();
            this.resizeWE = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.eventConfig.SuspendLayout();
            this.defaultConfig.SuspendLayout();
            this.splitConfigs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (36)))), ((int) (((byte) (77)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStrip, this.editToolStripMenuItem, this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "EditorMenu";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openToolStripMenuItem1, this.saveToolStripMenuItem1, this.saveAsToolStripMenuItem});
            this.fileToolStrip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fileToolStrip.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (12)))), ((int) (((byte) (52)))));
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.OpenMapFolder);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (12)))), ((int) (((byte) (52)))));
            this.saveToolStripMenuItem1.Enabled = false;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (12)))), ((int) (((byte) (52)))));
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.undoToolStripMenuItem, this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // eventConfig
            // 
            this.eventConfig.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.eventConfig.AutoSize = true;
            this.eventConfig.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (7)))), ((int) (((byte) (37)))));
            this.eventConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventConfig.Controls.Add(this.label6);
            this.eventConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eventConfig.Location = new System.Drawing.Point(0, 528);
            this.eventConfig.Name = "eventConfig";
            this.eventConfig.Padding = new System.Windows.Forms.Padding(2);
            this.eventConfig.Size = new System.Drawing.Size(1184, 233);
            this.eventConfig.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1168, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Context Sensitive Toolbox? (Changes options based on selected events?)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defaultConfig
            // 
            this.defaultConfig.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultConfig.AutoSize = true;
            this.defaultConfig.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (7)))), ((int) (((byte) (37)))));
            this.defaultConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultConfig.Controls.Add(this.label1);
            this.defaultConfig.Controls.Add(this.DefaultViewTextBox);
            this.defaultConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.defaultConfig.Location = new System.Drawing.Point(832, 24);
            this.defaultConfig.Name = "defaultConfig";
            this.defaultConfig.Padding = new System.Windows.Forms.Padding(2);
            this.defaultConfig.Size = new System.Drawing.Size(352, 498);
            this.defaultConfig.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Default View";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefaultViewTextBox
            // 
            this.DefaultViewTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DefaultViewTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (5)))), ((int) (((byte) (27)))));
            this.DefaultViewTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DefaultViewTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.DefaultViewTextBox.Location = new System.Drawing.Point(5, 30);
            this.DefaultViewTextBox.Name = "DefaultViewTextBox";
            this.DefaultViewTextBox.Size = new System.Drawing.Size(339, 458);
            this.DefaultViewTextBox.TabIndex = 17;
            this.DefaultViewTextBox.Text = "This will show the config or parts of the config in the default Intralism JSON fo" + "rmat. Will be formatted to be nicer looking obviously.";
            this.DefaultViewTextBox.TextChanged += new System.EventHandler(this.DefaultViewTextBoxTextChanged);
            // 
            // splitConfigs
            // 
            this.splitConfigs.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.splitConfigs.AutoSize = true;
            this.splitConfigs.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (7)))), ((int) (((byte) (37)))));
            this.splitConfigs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitConfigs.Controls.Add(this.label5);
            this.splitConfigs.Controls.Add(this.label4);
            this.splitConfigs.Controls.Add(this.label3);
            this.splitConfigs.Controls.Add(this.label2);
            this.splitConfigs.Controls.Add(this.StoryBoardTextBox);
            this.splitConfigs.Controls.Add(this.ArcSpawnTextBox);
            this.splitConfigs.Controls.Add(this.ZoomEventTextBox);
            this.splitConfigs.Controls.Add(this.SpeedEventTextBox);
            this.splitConfigs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitConfigs.Location = new System.Drawing.Point(0, 24);
            this.splitConfigs.Name = "splitConfigs";
            this.splitConfigs.Padding = new System.Windows.Forms.Padding(2);
            this.splitConfigs.Size = new System.Drawing.Size(826, 498);
            this.splitConfigs.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(5, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Speed Events";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(422, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Zoom Events";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(422, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Storyboard Events";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Arc Spawns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoryBoardTextBox
            // 
            this.StoryBoardTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StoryBoardTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (5)))), ((int) (((byte) (27)))));
            this.StoryBoardTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StoryBoardTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.StoryBoardTextBox.Location = new System.Drawing.Point(422, 30);
            this.StoryBoardTextBox.Name = "StoryBoardTextBox";
            this.StoryBoardTextBox.Size = new System.Drawing.Size(394, 215);
            this.StoryBoardTextBox.TabIndex = 20;
            this.StoryBoardTextBox.Text = resources.GetString("StoryBoardTextBox.Text");
            this.StoryBoardTextBox.TextChanged += new System.EventHandler(this.StoryBoardEventTextBoxTextChanged);
            // 
            // ArcSpawnTextBox
            // 
            this.ArcSpawnTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (5)))), ((int) (((byte) (27)))));
            this.ArcSpawnTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArcSpawnTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ArcSpawnTextBox.Location = new System.Drawing.Point(5, 30);
            this.ArcSpawnTextBox.Name = "ArcSpawnTextBox";
            this.ArcSpawnTextBox.Size = new System.Drawing.Size(394, 215);
            this.ArcSpawnTextBox.TabIndex = 19;
            this.ArcSpawnTextBox.Text = "These text boxes do not resize yet. Rich Text Boxes do not seem to have auto-sizi" + "ng functions, so we will need to make our own resizing.";
            this.ArcSpawnTextBox.TextChanged += new System.EventHandler(this.ArcSpawnTextBoxTextChanged);
            // 
            // ZoomEventTextBox
            // 
            this.ZoomEventTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomEventTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (5)))), ((int) (((byte) (27)))));
            this.ZoomEventTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ZoomEventTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ZoomEventTextBox.Location = new System.Drawing.Point(422, 273);
            this.ZoomEventTextBox.Name = "ZoomEventTextBox";
            this.ZoomEventTextBox.Size = new System.Drawing.Size(394, 215);
            this.ZoomEventTextBox.TabIndex = 18;
            this.ZoomEventTextBox.Text = "Perhaps events are listed in a friendlier format here and if the user clicks on t" + "hem they can expand to see the full details (Default View/Context-Sensitive Tool" + "box)";
            this.ZoomEventTextBox.TextChanged += new System.EventHandler(this.ZoomEventTextBoxTextChanged);
            // 
            // SpeedEventTextBox
            // 
            this.SpeedEventTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpeedEventTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (5)))), ((int) (((byte) (27)))));
            this.SpeedEventTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SpeedEventTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SpeedEventTextBox.Location = new System.Drawing.Point(5, 273);
            this.SpeedEventTextBox.Name = "SpeedEventTextBox";
            this.SpeedEventTextBox.Size = new System.Drawing.Size(394, 215);
            this.SpeedEventTextBox.TabIndex = 17;
            this.SpeedEventTextBox.Text = "Option to enable/disable specific boxes would be very nice, especially if a user " + "only wants to work on storyboard or only wants to work on zooms.";
            this.SpeedEventTextBox.TextChanged += new System.EventHandler(this.SpeedEventTextBoxTextChanged);
            // 
            // resizeNS
            // 
            this.resizeNS.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeNS.AutoSize = true;
            this.resizeNS.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.resizeNS.Location = new System.Drawing.Point(0, 519);
            this.resizeNS.Name = "resizeNS";
            this.resizeNS.Size = new System.Drawing.Size(1184, 13);
            this.resizeNS.TabIndex = 5;
            this.resizeNS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.resizeNS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeNorthAndSouth);
            this.resizeNS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            // 
            // resizeWE
            // 
            this.resizeWE.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeWE.AutoSize = true;
            this.resizeWE.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizeWE.Location = new System.Drawing.Point(823, 22);
            this.resizeWE.Name = "resizeWE";
            this.resizeWE.Size = new System.Drawing.Size(13, 739);
            this.resizeWE.TabIndex = 6;
            this.resizeWE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.resizeWE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeWestAndEast);
            this.resizeWE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            // 
            // MapEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (13)))), ((int) (((byte) (5)))), ((int) (((byte) (27)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.splitConfigs);
            this.Controls.Add(this.defaultConfig);
            this.Controls.Add(this.eventConfig);
            this.Controls.Add(this.resizeNS);
            this.Controls.Add(this.resizeWE);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MapEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMapEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.eventConfig.ResumeLayout(false);
            this.defaultConfig.ResumeLayout(false);
            this.splitConfigs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel defaultConfig;
        private System.Windows.Forms.RichTextBox DefaultViewTextBox;
        private System.Windows.Forms.RichTextBox SpeedEventTextBox;
        private System.Windows.Forms.RichTextBox ZoomEventTextBox;
        private System.Windows.Forms.RichTextBox ArcSpawnTextBox;
        private System.Windows.Forms.RichTextBox StoryBoardTextBox;

        private System.Windows.Forms.Panel resizeWE;

        private System.Windows.Forms.Panel resizeNS;
        private System.Windows.Forms.Panel splitConfigs;

        private System.Windows.Forms.Panel eventConfig;

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;

        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
            
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;

        #endregion
    }
}