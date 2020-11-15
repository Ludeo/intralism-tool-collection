using System.ComponentModel;

namespace ManiaToIntralism.Forms
{
    partial class FormMapEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventConfig = new System.Windows.Forms.Panel();
            this.defaultConfig = new System.Windows.Forms.Panel();
            this.splitConfigs = new System.Windows.Forms.Panel();
            this.resizeNS = new System.Windows.Forms.Panel();
            this.resizeWE = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (12)))), ((int) (((byte) (52)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStrip, this.editToolStripMenuItem});
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
            // eventConfig
            // 
            this.eventConfig.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.eventConfig.AutoSize = true;
            this.eventConfig.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (7)))), ((int) (((byte) (37)))));
            this.eventConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eventConfig.Location = new System.Drawing.Point(0, 528);
            this.eventConfig.Name = "eventConfig";
            this.eventConfig.Padding = new System.Windows.Forms.Padding(2);
            this.eventConfig.Size = new System.Drawing.Size(1914, 233);
            this.eventConfig.TabIndex = 4;
            // 
            // defaultConfig
            // 
            this.defaultConfig.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultConfig.AutoSize = true;
            this.defaultConfig.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (7)))), ((int) (((byte) (37)))));
            this.defaultConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.defaultConfig.Location = new System.Drawing.Point(832, 24);
            this.defaultConfig.Name = "defaultConfig";
            this.defaultConfig.Padding = new System.Windows.Forms.Padding(2);
            this.defaultConfig.Size = new System.Drawing.Size(352, 498);
            this.defaultConfig.TabIndex = 2;
            // 
            // splitConfigs
            // 
            this.splitConfigs.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.splitConfigs.AutoSize = true;
            this.splitConfigs.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (7)))), ((int) (((byte) (37)))));
            this.splitConfigs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitConfigs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitConfigs.Location = new System.Drawing.Point(0, 24);
            this.splitConfigs.Name = "splitConfigs";
            this.splitConfigs.Padding = new System.Windows.Forms.Padding(2);
            this.splitConfigs.Size = new System.Drawing.Size(826, 498);
            this.splitConfigs.TabIndex = 3;
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
            this.resizeNS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            this.resizeNS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.resizeNS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeNorthAndSouth);
            // 
            // resizeWE
            // 
            this.resizeWE.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeWE.AutoSize = true;
            this.resizeWE.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizeWE.Location = new System.Drawing.Point(821, 22);
            this.resizeWE.Name = "resizeWE";
            this.resizeWE.Size = new System.Drawing.Size(16, 507);
            this.resizeWE.TabIndex = 6;
            this.resizeWE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            this.resizeWE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.resizeWE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeWestAndEast);
            // 
            // FormMapEditor
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
            this.Name = "FormMapEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMapEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel resizeWE;

        private System.Windows.Forms.Panel defaultConfig;
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