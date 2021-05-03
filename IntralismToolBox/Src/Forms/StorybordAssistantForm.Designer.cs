
namespace IntralismToolBox.Forms
{
    partial class StoryboardAssistantForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoryboardAssistantForm));
            this.fillOrbitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.intervalColorButton = new System.Windows.Forms.Button();
            this.autoGradientButton = new System.Windows.Forms.Button();
            this.geometricFiguresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fillOrbitButton
            // 
            this.fillOrbitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillOrbitButton.Location = new System.Drawing.Point(15, 17);
            this.fillOrbitButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillOrbitButton.Name = "fillOrbitButton";
            this.fillOrbitButton.Size = new System.Drawing.Size(110, 30);
            this.fillOrbitButton.TabIndex = 0;
            this.fillOrbitButton.Text = "Fill orbit";
            this.fillOrbitButton.UseVisualStyleBackColor = true;
            this.fillOrbitButton.Click += new System.EventHandler(this.FillOrbitButtonClicked);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(173, 17);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(280, 106);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(173, 131);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(110, 30);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButtonClicked);
            // 
            // intervalColorButton
            // 
            this.intervalColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intervalColorButton.Location = new System.Drawing.Point(15, 55);
            this.intervalColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.intervalColorButton.Name = "intervalColorButton";
            this.intervalColorButton.Size = new System.Drawing.Size(110, 30);
            this.intervalColorButton.TabIndex = 4;
            this.intervalColorButton.Text = "Interval changing color";
            this.intervalColorButton.UseVisualStyleBackColor = true;
            this.intervalColorButton.Click += new System.EventHandler(this.GradientColorButtonClicked);
            // 
            // autoGradientButton
            // 
            this.autoGradientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoGradientButton.Location = new System.Drawing.Point(15, 93);
            this.autoGradientButton.Margin = new System.Windows.Forms.Padding(4);
            this.autoGradientButton.Name = "autoGradientButton";
            this.autoGradientButton.Size = new System.Drawing.Size(110, 30);
            this.autoGradientButton.TabIndex = 6;
            this.autoGradientButton.Text = "Gradient";
            this.autoGradientButton.UseVisualStyleBackColor = true;
            this.autoGradientButton.Click += new System.EventHandler(this.AutoGradientButtonClicked);
            // 
            // geometricFiguresButton
            // 
            this.geometricFiguresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geometricFiguresButton.Location = new System.Drawing.Point(15, 131);
            this.geometricFiguresButton.Margin = new System.Windows.Forms.Padding(4);
            this.geometricFiguresButton.Name = "geometricFiguresButton";
            this.geometricFiguresButton.Size = new System.Drawing.Size(110, 30);
            this.geometricFiguresButton.TabIndex = 7;
            this.geometricFiguresButton.Text = "Geometric figures";
            this.geometricFiguresButton.UseVisualStyleBackColor = true;
            this.geometricFiguresButton.Click += new System.EventHandler(this.GeometricFiguresButtonClicked);
            // 
            // StoryboardAssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 185);
            this.Controls.Add(this.geometricFiguresButton);
            this.Controls.Add(this.autoGradientButton);
            this.Controls.Add(this.intervalColorButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.fillOrbitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "StoryboardAssistantForm";
            this.Text = "Storyboard Assistant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fillOrbitButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button intervalColorButton;
        private System.Windows.Forms.Button autoGradientButton;
        private System.Windows.Forms.Button geometricFiguresButton;
    }
}

