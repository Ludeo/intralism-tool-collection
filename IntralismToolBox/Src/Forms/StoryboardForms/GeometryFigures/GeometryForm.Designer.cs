
namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    partial class GeometryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometryForm));
            this.cubeButton = new System.Windows.Forms.Button();
            this.pyramidButton = new System.Windows.Forms.Button();
            this.prismButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cubeButton
            // 
            this.cubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cubeButton.Location = new System.Drawing.Point(13, 12);
            this.cubeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(136, 30);
            this.cubeButton.TabIndex = 48;
            this.cubeButton.Text = "Cube";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.CubeButtonClicked);
            // 
            // pyramidButton
            // 
            this.pyramidButton.Enabled = false;
            this.pyramidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pyramidButton.Location = new System.Drawing.Point(13, 48);
            this.pyramidButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pyramidButton.Name = "pyramidButton";
            this.pyramidButton.Size = new System.Drawing.Size(136, 30);
            this.pyramidButton.TabIndex = 49;
            this.pyramidButton.Text = "Pyramid";
            this.pyramidButton.UseVisualStyleBackColor = true;
            // 
            // prismButton
            // 
            this.prismButton.Enabled = false;
            this.prismButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prismButton.Location = new System.Drawing.Point(13, 84);
            this.prismButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prismButton.Name = "prismButton";
            this.prismButton.Size = new System.Drawing.Size(136, 30);
            this.prismButton.TabIndex = 50;
            this.prismButton.Text = "Polygon prism";
            this.prismButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(301, 260);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 32);
            this.cancelButton.TabIndex = 52;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Location = new System.Drawing.Point(157, 260);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 32);
            this.enterButton.TabIndex = 51;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(157, 12);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(319, 242);
            this.resultTextBox.TabIndex = 53;
            this.resultTextBox.Text = "";
            // 
            // helpButton
            // 
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(445, 260);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(31, 32);
            this.helpButton.TabIndex = 54;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // GeometryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.prismButton);
            this.Controls.Add(this.pyramidButton);
            this.Controls.Add(this.cubeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "GeometryForm";
            this.Text = "GeometryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cubeButton;
        private System.Windows.Forms.Button pyramidButton;
        private System.Windows.Forms.Button prismButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button helpButton;
        public System.Windows.Forms.RichTextBox resultTextBox;
    }
}