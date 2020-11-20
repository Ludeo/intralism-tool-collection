using System.ComponentModel;
using System.Windows.Forms;

namespace IntralismToolBox.Forms
{
    partial class UserScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScoreForm));
            this.ScoreDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreDataGridView
            // 
            this.ScoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ScoreDataGridView.Name = "ScoreDataGridView";
            this.ScoreDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScoreDataGridView.Size = new System.Drawing.Size(800, 450);
            this.ScoreDataGridView.TabIndex = 0;
            // 
            // UserScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserScoreForm";
            this.Text = "FormUserScore";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView ScoreDataGridView;

        #endregion
    }
}