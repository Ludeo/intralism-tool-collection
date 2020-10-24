using System.ComponentModel;

namespace maniatointralism
{
    partial class FormSetting
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
            this.maniapathbox = new System.Windows.Forms.GroupBox();
            this.selectManiaPathBtn = new System.Windows.Forms.Button();
            this.saveManiaPathBtn = new System.Windows.Forms.Button();
            this.maniaPathTxt = new System.Windows.Forms.TextBox();
            this.editorpathbox = new System.Windows.Forms.GroupBox();
            this.selectEditorPathBtn = new System.Windows.Forms.Button();
            this.saveEditorPathBtn = new System.Windows.Forms.Button();
            this.editorPathTxt = new System.Windows.Forms.TextBox();
            this.maniapathbox.SuspendLayout();
            this.editorpathbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maniapathbox
            // 
            this.maniapathbox.Controls.Add(this.selectManiaPathBtn);
            this.maniapathbox.Controls.Add(this.saveManiaPathBtn);
            this.maniapathbox.Controls.Add(this.maniaPathTxt);
            this.maniapathbox.Location = new System.Drawing.Point(17, 9);
            this.maniapathbox.Name = "maniapathbox";
            this.maniapathbox.Size = new System.Drawing.Size(239, 86);
            this.maniapathbox.TabIndex = 0;
            this.maniapathbox.TabStop = false;
            this.maniapathbox.Text = "Mania Path";
            // 
            // selectManiaPathBtn
            // 
            this.selectManiaPathBtn.Location = new System.Drawing.Point(127, 47);
            this.selectManiaPathBtn.Name = "selectManiaPathBtn";
            this.selectManiaPathBtn.Size = new System.Drawing.Size(99, 22);
            this.selectManiaPathBtn.TabIndex = 2;
            this.selectManiaPathBtn.Text = "Select Folder";
            this.selectManiaPathBtn.UseVisualStyleBackColor = true;
            this.selectManiaPathBtn.Click += new System.EventHandler(this.SelectManiaFolder);
            // 
            // saveManiaPathBtn
            // 
            this.saveManiaPathBtn.Location = new System.Drawing.Point(11, 47);
            this.saveManiaPathBtn.Name = "saveManiaPathBtn";
            this.saveManiaPathBtn.Size = new System.Drawing.Size(99, 22);
            this.saveManiaPathBtn.TabIndex = 1;
            this.saveManiaPathBtn.Text = "Save";
            this.saveManiaPathBtn.UseVisualStyleBackColor = true;
            this.saveManiaPathBtn.Click += new System.EventHandler(this.SaveManiaPath);
            // 
            // maniaPathTxt
            // 
            this.maniaPathTxt.Location = new System.Drawing.Point(11, 21);
            this.maniaPathTxt.Name = "maniaPathTxt";
            this.maniaPathTxt.Size = new System.Drawing.Size(215, 20);
            this.maniaPathTxt.TabIndex = 0;
            // 
            // editorpathbox
            // 
            this.editorpathbox.Controls.Add(this.selectEditorPathBtn);
            this.editorpathbox.Controls.Add(this.saveEditorPathBtn);
            this.editorpathbox.Controls.Add(this.editorPathTxt);
            this.editorpathbox.Location = new System.Drawing.Point(19, 103);
            this.editorpathbox.Name = "editorpathbox";
            this.editorpathbox.Size = new System.Drawing.Size(236, 87);
            this.editorpathbox.TabIndex = 1;
            this.editorpathbox.TabStop = false;
            this.editorpathbox.Text = "Editor Path";
            // 
            // selectEditorPathBtn
            // 
            this.selectEditorPathBtn.Location = new System.Drawing.Point(125, 49);
            this.selectEditorPathBtn.Name = "selectEditorPathBtn";
            this.selectEditorPathBtn.Size = new System.Drawing.Size(98, 24);
            this.selectEditorPathBtn.TabIndex = 2;
            this.selectEditorPathBtn.Text = "Select Folder";
            this.selectEditorPathBtn.UseVisualStyleBackColor = true;
            this.selectEditorPathBtn.Click += new System.EventHandler(this.SelectEditorFolder);
            // 
            // saveEditorPathBtn
            // 
            this.saveEditorPathBtn.Location = new System.Drawing.Point(9, 49);
            this.saveEditorPathBtn.Name = "saveEditorPathBtn";
            this.saveEditorPathBtn.Size = new System.Drawing.Size(99, 24);
            this.saveEditorPathBtn.TabIndex = 1;
            this.saveEditorPathBtn.Text = "Save";
            this.saveEditorPathBtn.UseVisualStyleBackColor = true;
            this.saveEditorPathBtn.Click += new System.EventHandler(this.SaveEditorPath);
            // 
            // editorPathTxt
            // 
            this.editorPathTxt.Location = new System.Drawing.Point(9, 18);
            this.editorPathTxt.Name = "editorPathTxt";
            this.editorPathTxt.Size = new System.Drawing.Size(214, 20);
            this.editorPathTxt.TabIndex = 0;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 209);
            this.Controls.Add(this.editorpathbox);
            this.Controls.Add(this.maniapathbox);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.maniapathbox.ResumeLayout(false);
            this.maniapathbox.PerformLayout();
            this.editorpathbox.ResumeLayout(false);
            this.editorpathbox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox editorPathTxt;

        private System.Windows.Forms.GroupBox editorpathbox;
        private System.Windows.Forms.Button saveEditorPathBtn;
        private System.Windows.Forms.Button saveManiaPathBtn;
        private System.Windows.Forms.Button selectEditorPathBtn;

        private System.Windows.Forms.Button selectManiaPathBtn;

        private System.Windows.Forms.TextBox maniaPathTxt;

        private System.Windows.Forms.GroupBox maniapathbox;

        #endregion
    }
}