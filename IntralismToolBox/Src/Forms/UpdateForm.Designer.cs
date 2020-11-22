using System.ComponentModel;

namespace IntralismToolBox.Forms
{
    partial class UpdateForm
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
            this.ReleaseNotesTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReleaseNotesTextBox
            // 
            this.ReleaseNotesTextBox.Location = new System.Drawing.Point(12, 12);
            this.ReleaseNotesTextBox.Multiline = true;
            this.ReleaseNotesTextBox.Name = "ReleaseNotesTextBox";
            this.ReleaseNotesTextBox.ReadOnly = true;
            this.ReleaseNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReleaseNotesTextBox.Size = new System.Drawing.Size(331, 125);
            this.ReleaseNotesTextBox.TabIndex = 0;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 143);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(82, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateClicked);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(100, 143);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 179);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ReleaseNotesTextBox);
            this.Name = "UpdateForm";
            this.Text = "New release available";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button UpdateButton;

        private System.Windows.Forms.TextBox ReleaseNotesTextBox;

        #endregion
    }
}