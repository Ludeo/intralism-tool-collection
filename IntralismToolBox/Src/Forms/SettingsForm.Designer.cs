﻿using System.ComponentModel;

namespace IntralismToolBox.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ManiaPathGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectManiaPathButton = new System.Windows.Forms.Button();
            this.ManiaPathTextBox = new System.Windows.Forms.TextBox();
            this.EditorPathGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectEditorPathButton = new System.Windows.Forms.Button();
            this.EditorPathTextBox = new System.Windows.Forms.TextBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.ManiaPathGroupBox.SuspendLayout();
            this.EditorPathGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maniapathbox
            // 
            this.ManiaPathGroupBox.Controls.Add(this.SelectManiaPathButton);
            this.ManiaPathGroupBox.Controls.Add(this.ManiaPathTextBox);
            this.ManiaPathGroupBox.Location = new System.Drawing.Point(17, 9);
            this.ManiaPathGroupBox.Name = "ManiaPathGroupBox";
            this.ManiaPathGroupBox.Size = new System.Drawing.Size(239, 86);
            this.ManiaPathGroupBox.TabIndex = 0;
            this.ManiaPathGroupBox.TabStop = false;
            this.ManiaPathGroupBox.Text = "Mania Path";
            // 
            // selectManiaPathBtn
            // 
            this.SelectManiaPathButton.Location = new System.Drawing.Point(11, 47);
            this.SelectManiaPathButton.Name = "SelectManiaPathButton";
            this.SelectManiaPathButton.Size = new System.Drawing.Size(99, 22);
            this.SelectManiaPathButton.TabIndex = 2;
            this.SelectManiaPathButton.Text = "Select Folder";
            this.SelectManiaPathButton.UseVisualStyleBackColor = true;
            this.SelectManiaPathButton.Click += new System.EventHandler(this.SelectManiaFolder);
            // 
            // maniaPathTxt
            // 
            this.ManiaPathTextBox.Location = new System.Drawing.Point(11, 21);
            this.ManiaPathTextBox.Name = "ManiaPathTextBox";
            this.ManiaPathTextBox.Size = new System.Drawing.Size(215, 20);
            this.ManiaPathTextBox.TabIndex = 0;
            // 
            // editorpathbox
            // 
            this.EditorPathGroupBox.Controls.Add(this.SelectEditorPathButton);
            this.EditorPathGroupBox.Controls.Add(this.EditorPathTextBox);
            this.EditorPathGroupBox.Location = new System.Drawing.Point(19, 103);
            this.EditorPathGroupBox.Name = "EditorPathGroupBox";
            this.EditorPathGroupBox.Size = new System.Drawing.Size(236, 78);
            this.EditorPathGroupBox.TabIndex = 1;
            this.EditorPathGroupBox.TabStop = false;
            this.EditorPathGroupBox.Text = "Editor Path";
            // 
            // selectEditorPathBtn
            // 
            this.SelectEditorPathButton.Location = new System.Drawing.Point(9, 44);
            this.SelectEditorPathButton.Name = "SelectEditorPathButton";
            this.SelectEditorPathButton.Size = new System.Drawing.Size(98, 24);
            this.SelectEditorPathButton.TabIndex = 2;
            this.SelectEditorPathButton.Text = "Select Folder";
            this.SelectEditorPathButton.UseVisualStyleBackColor = true;
            this.SelectEditorPathButton.Click += new System.EventHandler(this.SelectEditorFolder);
            // 
            // editorPathTxt
            // 
            this.EditorPathTextBox.Location = new System.Drawing.Point(9, 18);
            this.EditorPathTextBox.Name = "EditorPathTextBox";
            this.EditorPathTextBox.Size = new System.Drawing.Size(214, 20);
            this.EditorPathTextBox.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(85, 186);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(99, 24);
            this.SaveSettingsButton.TabIndex = 1;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveConfig);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 222);
            this.Controls.Add(this.EditorPathGroupBox);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.ManiaPathGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ManiaPathGroupBox.ResumeLayout(false);
            this.ManiaPathGroupBox.PerformLayout();
            this.EditorPathGroupBox.ResumeLayout(false);
            this.EditorPathGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button SaveSettingsButton;

        private System.Windows.Forms.TextBox EditorPathTextBox;

        private System.Windows.Forms.GroupBox EditorPathGroupBox;
        private System.Windows.Forms.Button SelectEditorPathButton;

        private System.Windows.Forms.Button SelectManiaPathButton;

        private System.Windows.Forms.TextBox ManiaPathTextBox;

        private System.Windows.Forms.GroupBox ManiaPathGroupBox;

        #endregion
    }
}