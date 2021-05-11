
namespace IntralismToolBox.Forms.StoryboardForms
{
    partial class IntervalColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntervalColorForm));
            this.timeOffsetLabel = new System.Windows.Forms.Label();
            this.timeStartUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.nameOffsetLabel = new System.Windows.Forms.Label();
            this.firstObjectNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.objectCountLabel = new System.Windows.Forms.Label();
            this.objectCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.objectNameLabel = new System.Windows.Forms.Label();
            this.objectTypeLabel = new System.Windows.Forms.Label();
            this.objectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.objectNameTextBox = new System.Windows.Forms.TextBox();
            this.demoPictureBox = new System.Windows.Forms.PictureBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.colorsCountLabel = new System.Windows.Forms.Label();
            this.colorsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.fullDurationLabel = new System.Windows.Forms.Label();
            this.cycleDurationUpDown = new System.Windows.Forms.NumericUpDown();
            this.lapsCountLabel = new System.Windows.Forms.Label();
            this.lapsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.stackedCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstObjectNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleDurationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapsCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timeOffsetLabel
            // 
            this.timeOffsetLabel.AutoSize = true;
            this.timeOffsetLabel.Location = new System.Drawing.Point(152, 174);
            this.timeOffsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeOffsetLabel.Name = "timeOffsetLabel";
            this.timeOffsetLabel.Size = new System.Drawing.Size(74, 15);
            this.timeOffsetLabel.TabIndex = 29;
            this.timeOffsetLabel.Text = "Time (offset)";
            // 
            // timeStartUpDown
            // 
            this.timeStartUpDown.Location = new System.Drawing.Point(152, 192);
            this.timeStartUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timeStartUpDown.Name = "timeStartUpDown";
            this.timeStartUpDown.Size = new System.Drawing.Size(131, 23);
            this.timeStartUpDown.TabIndex = 28;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(291, 48);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 30);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Location = new System.Drawing.Point(291, 12);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 30);
            this.enterButton.TabIndex = 26;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButtonClicked);
            // 
            // nameOffsetLabel
            // 
            this.nameOffsetLabel.AutoSize = true;
            this.nameOffsetLabel.Location = new System.Drawing.Point(11, 117);
            this.nameOffsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOffsetLabel.Name = "nameOffsetLabel";
            this.nameOffsetLabel.Size = new System.Drawing.Size(72, 15);
            this.nameOffsetLabel.TabIndex = 25;
            this.nameOffsetLabel.Text = "Name offset";
            // 
            // firstObjectNumberUpDown
            // 
            this.firstObjectNumberUpDown.Location = new System.Drawing.Point(11, 135);
            this.firstObjectNumberUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstObjectNumberUpDown.Name = "firstObjectNumberUpDown";
            this.firstObjectNumberUpDown.Size = new System.Drawing.Size(133, 23);
            this.firstObjectNumberUpDown.TabIndex = 24;
            // 
            // objectCountLabel
            // 
            this.objectCountLabel.AutoSize = true;
            this.objectCountLabel.Location = new System.Drawing.Point(11, 232);
            this.objectCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectCountLabel.Name = "objectCountLabel";
            this.objectCountLabel.Size = new System.Drawing.Size(95, 15);
            this.objectCountLabel.TabIndex = 23;
            this.objectCountLabel.Text = "Count of objects";
            // 
            // objectCountUpDown
            // 
            this.objectCountUpDown.Location = new System.Drawing.Point(13, 250);
            this.objectCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.objectCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.objectCountUpDown.Name = "objectCountUpDown";
            this.objectCountUpDown.Size = new System.Drawing.Size(131, 23);
            this.objectCountUpDown.TabIndex = 22;
            this.objectCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Location = new System.Drawing.Point(11, 174);
            this.objectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(77, 15);
            this.objectNameLabel.TabIndex = 21;
            this.objectNameLabel.Text = "Object Name";
            // 
            // objectTypeLabel
            // 
            this.objectTypeLabel.AutoSize = true;
            this.objectTypeLabel.Location = new System.Drawing.Point(11, 54);
            this.objectTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectTypeLabel.Name = "objectTypeLabel";
            this.objectTypeLabel.Size = new System.Drawing.Size(69, 15);
            this.objectTypeLabel.TabIndex = 20;
            this.objectTypeLabel.Text = "Object Type";
            // 
            // objectTypeComboBox
            // 
            this.objectTypeComboBox.FormattingEnabled = true;
            this.objectTypeComboBox.Items.AddRange(new object[] {
            "Sun",
            "Satellite",
            "Particles"});
            this.objectTypeComboBox.Location = new System.Drawing.Point(11, 72);
            this.objectTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.objectTypeComboBox.Name = "objectTypeComboBox";
            this.objectTypeComboBox.Size = new System.Drawing.Size(133, 23);
            this.objectTypeComboBox.TabIndex = 19;
            // 
            // objectNameTextBox
            // 
            this.objectNameTextBox.Location = new System.Drawing.Point(11, 192);
            this.objectNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.objectNameTextBox.Name = "objectNameTextBox";
            this.objectNameTextBox.Size = new System.Drawing.Size(133, 23);
            this.objectNameTextBox.TabIndex = 18;
            this.objectNameTextBox.Text = "s";
            // 
            // demoPictureBox
            // 
            this.demoPictureBox.Location = new System.Drawing.Point(162, 12);
            this.demoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.demoPictureBox.Name = "demoPictureBox";
            this.demoPictureBox.Size = new System.Drawing.Size(111, 102);
            this.demoPictureBox.TabIndex = 17;
            this.demoPictureBox.TabStop = false;
            // 
            // chooseButton
            // 
            this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseButton.Location = new System.Drawing.Point(11, 12);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(133, 30);
            this.chooseButton.TabIndex = 16;
            this.chooseButton.Text = "Choose Colors";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButtonClicked);
            // 
            // colorsCountLabel
            // 
            this.colorsCountLabel.AutoSize = true;
            this.colorsCountLabel.Location = new System.Drawing.Point(152, 117);
            this.colorsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorsCountLabel.Name = "colorsCountLabel";
            this.colorsCountLabel.Size = new System.Drawing.Size(75, 15);
            this.colorsCountLabel.TabIndex = 30;
            this.colorsCountLabel.Text = "Colors count";
            // 
            // colorsCountUpDown
            // 
            this.colorsCountUpDown.Location = new System.Drawing.Point(152, 135);
            this.colorsCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorsCountUpDown.Name = "colorsCountUpDown";
            this.colorsCountUpDown.Size = new System.Drawing.Size(131, 23);
            this.colorsCountUpDown.TabIndex = 31;
            // 
            // fullDurationLabel
            // 
            this.fullDurationLabel.AutoSize = true;
            this.fullDurationLabel.Location = new System.Drawing.Point(152, 232);
            this.fullDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullDurationLabel.Name = "fullDurationLabel";
            this.fullDurationLabel.Size = new System.Drawing.Size(74, 15);
            this.fullDurationLabel.TabIndex = 33;
            this.fullDurationLabel.Text = "Full duration";
            // 
            // cycleDurationUpDown
            // 
            this.cycleDurationUpDown.Location = new System.Drawing.Point(152, 250);
            this.cycleDurationUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cycleDurationUpDown.Name = "cycleDurationUpDown";
            this.cycleDurationUpDown.Size = new System.Drawing.Size(131, 23);
            this.cycleDurationUpDown.TabIndex = 32;
            // 
            // lapsCountLabel
            // 
            this.lapsCountLabel.AutoSize = true;
            this.lapsCountLabel.Location = new System.Drawing.Point(291, 117);
            this.lapsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lapsCountLabel.Name = "lapsCountLabel";
            this.lapsCountLabel.Size = new System.Drawing.Size(65, 15);
            this.lapsCountLabel.TabIndex = 34;
            this.lapsCountLabel.Text = "Laps count";
            // 
            // lapsCountUpDown
            // 
            this.lapsCountUpDown.Location = new System.Drawing.Point(291, 135);
            this.lapsCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lapsCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lapsCountUpDown.Name = "lapsCountUpDown";
            this.lapsCountUpDown.Size = new System.Drawing.Size(133, 23);
            this.lapsCountUpDown.TabIndex = 35;
            this.lapsCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stackedCheckBox
            // 
            this.stackedCheckBox.AutoSize = true;
            this.stackedCheckBox.Location = new System.Drawing.Point(307, 194);
            this.stackedCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stackedCheckBox.Name = "stackedCheckBox";
            this.stackedCheckBox.Size = new System.Drawing.Size(88, 19);
            this.stackedCheckBox.TabIndex = 36;
            this.stackedCheckBox.Text = "StackEvents";
            this.stackedCheckBox.UseVisualStyleBackColor = true;
            this.stackedCheckBox.CheckedChanged += new System.EventHandler(this.StackedCheckBoxChanged);
            // 
            // IntervalColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 285);
            this.Controls.Add(this.stackedCheckBox);
            this.Controls.Add(this.lapsCountUpDown);
            this.Controls.Add(this.lapsCountLabel);
            this.Controls.Add(this.fullDurationLabel);
            this.Controls.Add(this.cycleDurationUpDown);
            this.Controls.Add(this.colorsCountUpDown);
            this.Controls.Add(this.colorsCountLabel);
            this.Controls.Add(this.timeOffsetLabel);
            this.Controls.Add(this.timeStartUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.nameOffsetLabel);
            this.Controls.Add(this.firstObjectNumberUpDown);
            this.Controls.Add(this.objectCountLabel);
            this.Controls.Add(this.objectCountUpDown);
            this.Controls.Add(this.objectNameLabel);
            this.Controls.Add(this.objectTypeLabel);
            this.Controls.Add(this.objectTypeComboBox);
            this.Controls.Add(this.objectNameTextBox);
            this.Controls.Add(this.demoPictureBox);
            this.Controls.Add(this.chooseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "IntervalColorForm";
            this.Text = "Interval Color";
            ((System.ComponentModel.ISupportInitialize)(this.timeStartUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstObjectNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleDurationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapsCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeOffsetLabel;
        public System.Windows.Forms.NumericUpDown timeStartUpDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label nameOffsetLabel;
        public System.Windows.Forms.NumericUpDown firstObjectNumberUpDown;
        private System.Windows.Forms.Label objectCountLabel;
        public System.Windows.Forms.NumericUpDown objectCountUpDown;
        private System.Windows.Forms.Label objectNameLabel;
        private System.Windows.Forms.Label objectTypeLabel;
        public System.Windows.Forms.ComboBox objectTypeComboBox;
        public System.Windows.Forms.TextBox objectNameTextBox;
        private System.Windows.Forms.PictureBox demoPictureBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label colorsCountLabel;
        private System.Windows.Forms.Label fullDurationLabel;
        public System.Windows.Forms.NumericUpDown cycleDurationUpDown;
        private System.Windows.Forms.Label lapsCountLabel;
        public System.Windows.Forms.NumericUpDown colorsCountUpDown;
        public System.Windows.Forms.NumericUpDown lapsCountUpDown;
        private System.Windows.Forms.CheckBox stackedCheckBox;
    }
}