
namespace IntralismToolBox.Forms.StoryboardForms
{
    partial class FillOrbitForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillOrbitForm));
            this.sunsCountLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.sunsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiusUpDown = new System.Windows.Forms.NumericUpDown();
            this.circlingSpeedLabel = new System.Windows.Forms.Label();
            this.circlingSpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.enterButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sunNameTextBox = new System.Windows.Forms.TextBox();
            this.sunNameLabel = new System.Windows.Forms.Label();
            this.sunNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.firstNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameOffsetLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeUpDown = new System.Windows.Forms.NumericUpDown();
            this.emissionUpDown = new System.Windows.Forms.NumericUpDown();
            this.emissionLabel = new System.Windows.Forms.Label();
            this.stackedCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sunsCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlingSpeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sunsCountLabel
            // 
            this.sunsCountLabel.AutoSize = true;
            this.sunsCountLabel.Location = new System.Drawing.Point(9, 9);
            this.sunsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunsCountLabel.Name = "sunsCountLabel";
            this.sunsCountLabel.Size = new System.Drawing.Size(66, 15);
            this.sunsCountLabel.TabIndex = 0;
            this.sunsCountLabel.Text = "Suns count";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(9, 63);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(42, 15);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Radius";
            // 
            // sunsCountUpDown
            // 
            this.sunsCountUpDown.Location = new System.Drawing.Point(9, 27);
            this.sunsCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sunsCountUpDown.Name = "sunsCountUpDown";
            this.sunsCountUpDown.Size = new System.Drawing.Size(104, 23);
            this.sunsCountUpDown.TabIndex = 2;
            // 
            // radiusUpDown
            // 
            this.radiusUpDown.Location = new System.Drawing.Point(9, 81);
            this.radiusUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiusUpDown.Name = "radiusUpDown";
            this.radiusUpDown.Size = new System.Drawing.Size(104, 23);
            this.radiusUpDown.TabIndex = 3;
            // 
            // circlingSpeedLabel
            // 
            this.circlingSpeedLabel.AutoSize = true;
            this.circlingSpeedLabel.Location = new System.Drawing.Point(9, 121);
            this.circlingSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.circlingSpeedLabel.Name = "circlingSpeedLabel";
            this.circlingSpeedLabel.Size = new System.Drawing.Size(82, 15);
            this.circlingSpeedLabel.TabIndex = 4;
            this.circlingSpeedLabel.Text = "Circling speed";
            // 
            // circlingSpeedUpDown
            // 
            this.circlingSpeedUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.circlingSpeedUpDown.Location = new System.Drawing.Point(9, 139);
            this.circlingSpeedUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.circlingSpeedUpDown.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.circlingSpeedUpDown.Name = "circlingSpeedUpDown";
            this.circlingSpeedUpDown.Size = new System.Drawing.Size(104, 23);
            this.circlingSpeedUpDown.TabIndex = 5;
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Location = new System.Drawing.Point(9, 240);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(104, 30);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButtonClicked);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(151, 240);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // sunNameTextBox
            // 
            this.sunNameTextBox.Location = new System.Drawing.Point(9, 195);
            this.sunNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sunNameTextBox.Name = "sunNameTextBox";
            this.sunNameTextBox.Size = new System.Drawing.Size(104, 23);
            this.sunNameTextBox.TabIndex = 8;
            this.sunNameTextBox.Text = "s";
            // 
            // sunNameLabel
            // 
            this.sunNameLabel.AutoSize = true;
            this.sunNameLabel.Location = new System.Drawing.Point(9, 177);
            this.sunNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunNameLabel.Name = "sunNameLabel";
            this.sunNameLabel.Size = new System.Drawing.Size(60, 15);
            this.sunNameLabel.TabIndex = 9;
            this.sunNameLabel.Text = "Sun name";
            // 
            // firstNumberUpDown
            // 
            this.firstNumberUpDown.Location = new System.Drawing.Point(151, 139);
            this.firstNumberUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstNumberUpDown.Name = "firstNumberUpDown";
            this.firstNumberUpDown.Size = new System.Drawing.Size(104, 23);
            this.firstNumberUpDown.TabIndex = 10;
            // 
            // nameOffsetLabel
            // 
            this.nameOffsetLabel.AutoSize = true;
            this.nameOffsetLabel.Location = new System.Drawing.Point(151, 121);
            this.nameOffsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOffsetLabel.Name = "nameOffsetLabel";
            this.nameOffsetLabel.Size = new System.Drawing.Size(72, 15);
            this.nameOffsetLabel.TabIndex = 11;
            this.nameOffsetLabel.Text = "Name offset";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(151, 63);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(33, 15);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Time";
            // 
            // timeUpDown
            // 
            this.timeUpDown.Location = new System.Drawing.Point(151, 81);
            this.timeUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timeUpDown.Name = "timeUpDown";
            this.timeUpDown.Size = new System.Drawing.Size(104, 23);
            this.timeUpDown.TabIndex = 14;
            // 
            // emissionUpDown
            // 
            this.emissionUpDown.DecimalPlaces = 2;
            this.emissionUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.emissionUpDown.Location = new System.Drawing.Point(151, 27);
            this.emissionUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emissionUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.emissionUpDown.Name = "emissionUpDown";
            this.emissionUpDown.Size = new System.Drawing.Size(104, 23);
            this.emissionUpDown.TabIndex = 16;
            // 
            // emissionLabel
            // 
            this.emissionLabel.AutoSize = true;
            this.emissionLabel.Location = new System.Drawing.Point(151, 9);
            this.emissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emissionLabel.Name = "emissionLabel";
            this.emissionLabel.Size = new System.Drawing.Size(54, 15);
            this.emissionLabel.TabIndex = 15;
            this.emissionLabel.Text = "Emission";
            // 
            // stackedCheckBox
            // 
            this.stackedCheckBox.AutoSize = true;
            this.stackedCheckBox.Location = new System.Drawing.Point(151, 195);
            this.stackedCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stackedCheckBox.Name = "stackedCheckBox";
            this.stackedCheckBox.Size = new System.Drawing.Size(91, 19);
            this.stackedCheckBox.TabIndex = 17;
            this.stackedCheckBox.Text = "Stack Events";
            this.stackedCheckBox.UseVisualStyleBackColor = true;
            // 
            // FillOrbitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 283);
            this.Controls.Add(this.stackedCheckBox);
            this.Controls.Add(this.emissionUpDown);
            this.Controls.Add(this.emissionLabel);
            this.Controls.Add(this.timeUpDown);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.nameOffsetLabel);
            this.Controls.Add(this.firstNumberUpDown);
            this.Controls.Add(this.sunNameLabel);
            this.Controls.Add(this.sunNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.circlingSpeedUpDown);
            this.Controls.Add(this.circlingSpeedLabel);
            this.Controls.Add(this.radiusUpDown);
            this.Controls.Add(this.sunsCountUpDown);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.sunsCountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FillOrbitForm";
            this.Text = "FillOrbitForm";
            ((System.ComponentModel.ISupportInitialize)(this.sunsCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlingSpeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sunsCountLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label circlingSpeedLabel;
        private System.Windows.Forms.Button enterButton;
        public System.Windows.Forms.NumericUpDown sunsCountUpDown;
        public System.Windows.Forms.NumericUpDown radiusUpDown;
        public System.Windows.Forms.NumericUpDown circlingSpeedUpDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sunNameLabel;
        private System.Windows.Forms.ToolTip sunNameToolTip;
        public System.Windows.Forms.TextBox sunNameTextBox;
        private System.Windows.Forms.Label nameOffsetLabel;
        public System.Windows.Forms.NumericUpDown firstNumberUpDown;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.NumericUpDown timeUpDown;
        public System.Windows.Forms.NumericUpDown emissionUpDown;
        private System.Windows.Forms.Label emissionLabel;
        public System.Windows.Forms.CheckBox stackedCheckBox;
    }
}