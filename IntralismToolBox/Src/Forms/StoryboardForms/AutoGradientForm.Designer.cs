
namespace IntralismToolBox.Forms.StoryboardForms
{
    partial class AutoGradientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoGradientForm));
            this.fullDurationLabel = new System.Windows.Forms.Label();
            this.fullDurationUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorsCountLabel = new System.Windows.Forms.Label();
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
            this.demo1PictureBox = new System.Windows.Forms.PictureBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.demo2PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fullDurationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstObjectNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fullDurationLabel
            // 
            this.fullDurationLabel.AutoSize = true;
            this.fullDurationLabel.Location = new System.Drawing.Point(278, 163);
            this.fullDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullDurationLabel.Name = "fullDurationLabel";
            this.fullDurationLabel.Size = new System.Drawing.Size(74, 15);
            this.fullDurationLabel.TabIndex = 54;
            this.fullDurationLabel.Text = "Full duration";
            // 
            // fullDurationUpDown
            // 
            this.fullDurationUpDown.Location = new System.Drawing.Point(278, 181);
            this.fullDurationUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fullDurationUpDown.Name = "fullDurationUpDown";
            this.fullDurationUpDown.Size = new System.Drawing.Size(84, 23);
            this.fullDurationUpDown.TabIndex = 53;
            // 
            // colorCountUpDown
            // 
            this.colorCountUpDown.Enabled = false;
            this.colorCountUpDown.Location = new System.Drawing.Point(278, 119);
            this.colorCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorCountUpDown.Name = "colorCountUpDown";
            this.colorCountUpDown.Size = new System.Drawing.Size(84, 23);
            this.colorCountUpDown.TabIndex = 52;
            this.colorCountUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // colorsCountLabel
            // 
            this.colorsCountLabel.AutoSize = true;
            this.colorsCountLabel.Location = new System.Drawing.Point(278, 101);
            this.colorsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorsCountLabel.Name = "colorsCountLabel";
            this.colorsCountLabel.Size = new System.Drawing.Size(75, 15);
            this.colorsCountLabel.TabIndex = 51;
            this.colorsCountLabel.Text = "Colors count";
            // 
            // timeOffsetLabel
            // 
            this.timeOffsetLabel.AutoSize = true;
            this.timeOffsetLabel.Location = new System.Drawing.Point(174, 163);
            this.timeOffsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeOffsetLabel.Name = "timeOffsetLabel";
            this.timeOffsetLabel.Size = new System.Drawing.Size(74, 15);
            this.timeOffsetLabel.TabIndex = 50;
            this.timeOffsetLabel.Text = "Time (offset)";
            // 
            // timeStartUpDown
            // 
            this.timeStartUpDown.Location = new System.Drawing.Point(174, 181);
            this.timeStartUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timeStartUpDown.Name = "timeStartUpDown";
            this.timeStartUpDown.Size = new System.Drawing.Size(84, 23);
            this.timeStartUpDown.TabIndex = 49;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(331, 48);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 30);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Location = new System.Drawing.Point(331, 12);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 30);
            this.enterButton.TabIndex = 47;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButtonClicked);
            // 
            // nameOffsetLabel
            // 
            this.nameOffsetLabel.AutoSize = true;
            this.nameOffsetLabel.Location = new System.Drawing.Point(174, 101);
            this.nameOffsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOffsetLabel.Name = "nameOffsetLabel";
            this.nameOffsetLabel.Size = new System.Drawing.Size(72, 15);
            this.nameOffsetLabel.TabIndex = 46;
            this.nameOffsetLabel.Text = "Name offset";
            // 
            // firstObjectNumberUpDown
            // 
            this.firstObjectNumberUpDown.Location = new System.Drawing.Point(174, 119);
            this.firstObjectNumberUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstObjectNumberUpDown.Name = "firstObjectNumberUpDown";
            this.firstObjectNumberUpDown.Size = new System.Drawing.Size(84, 23);
            this.firstObjectNumberUpDown.TabIndex = 45;
            // 
            // objectCountLabel
            // 
            this.objectCountLabel.AutoSize = true;
            this.objectCountLabel.Location = new System.Drawing.Point(13, 163);
            this.objectCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectCountLabel.Name = "objectCountLabel";
            this.objectCountLabel.Size = new System.Drawing.Size(95, 15);
            this.objectCountLabel.TabIndex = 44;
            this.objectCountLabel.Text = "Count of objects";
            // 
            // objectCountUpDown
            // 
            this.objectCountUpDown.Location = new System.Drawing.Point(13, 181);
            this.objectCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.objectCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.objectCountUpDown.Name = "objectCountUpDown";
            this.objectCountUpDown.Size = new System.Drawing.Size(148, 23);
            this.objectCountUpDown.TabIndex = 43;
            this.objectCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Location = new System.Drawing.Point(13, 101);
            this.objectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(77, 15);
            this.objectNameLabel.TabIndex = 42;
            this.objectNameLabel.Text = "Object Name";
            // 
            // objectTypeLabel
            // 
            this.objectTypeLabel.AutoSize = true;
            this.objectTypeLabel.Location = new System.Drawing.Point(13, 48);
            this.objectTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectTypeLabel.Name = "objectTypeLabel";
            this.objectTypeLabel.Size = new System.Drawing.Size(69, 15);
            this.objectTypeLabel.TabIndex = 41;
            this.objectTypeLabel.Text = "Object Type";
            // 
            // objectTypeComboBox
            // 
            this.objectTypeComboBox.FormattingEnabled = true;
            this.objectTypeComboBox.Items.AddRange(new object[] {
            "Sun",
            "Satellite",
            "Particles"});
            this.objectTypeComboBox.Location = new System.Drawing.Point(13, 66);
            this.objectTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.objectTypeComboBox.Name = "objectTypeComboBox";
            this.objectTypeComboBox.Size = new System.Drawing.Size(148, 23);
            this.objectTypeComboBox.TabIndex = 40;
            // 
            // objectNameTextBox
            // 
            this.objectNameTextBox.Location = new System.Drawing.Point(13, 119);
            this.objectNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.objectNameTextBox.Name = "objectNameTextBox";
            this.objectNameTextBox.Size = new System.Drawing.Size(148, 23);
            this.objectNameTextBox.TabIndex = 39;
            this.objectNameTextBox.Text = "s";
            // 
            // demo1PictureBox
            // 
            this.demo1PictureBox.Location = new System.Drawing.Point(173, 12);
            this.demo1PictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.demo1PictureBox.Name = "demo1PictureBox";
            this.demo1PictureBox.Size = new System.Drawing.Size(150, 30);
            this.demo1PictureBox.TabIndex = 38;
            this.demo1PictureBox.TabStop = false;
            // 
            // chooseButton
            // 
            this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseButton.Location = new System.Drawing.Point(13, 12);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(148, 30);
            this.chooseButton.TabIndex = 37;
            this.chooseButton.Text = "Choose Colors";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButtonClicked);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 218);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(363, 30);
            this.infoLabel.TabIndex = 58;
            this.infoLabel.Text = "Auto means that gradient will be counted from first color to second\r\n( there will" +
    " be alot more colors than non-auto version has )";
            // 
            // demo2PictureBox
            // 
            this.demo2PictureBox.Location = new System.Drawing.Point(174, 48);
            this.demo2PictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.demo2PictureBox.Name = "demo2PictureBox";
            this.demo2PictureBox.Size = new System.Drawing.Size(150, 30);
            this.demo2PictureBox.TabIndex = 59;
            this.demo2PictureBox.TabStop = false;
            // 
            // AutoGradientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 260);
            this.Controls.Add(this.demo2PictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.fullDurationLabel);
            this.Controls.Add(this.fullDurationUpDown);
            this.Controls.Add(this.colorCountUpDown);
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
            this.Controls.Add(this.demo1PictureBox);
            this.Controls.Add(this.chooseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AutoGradientForm";
            this.Text = "Auto Gradient";
            ((System.ComponentModel.ISupportInitialize)(this.fullDurationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstObjectNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fullDurationLabel;
        public System.Windows.Forms.NumericUpDown fullDurationUpDown;
        public System.Windows.Forms.NumericUpDown colorCountUpDown;
        private System.Windows.Forms.Label colorsCountLabel;
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
        private System.Windows.Forms.PictureBox demo1PictureBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox demo2PictureBox;
    }
}