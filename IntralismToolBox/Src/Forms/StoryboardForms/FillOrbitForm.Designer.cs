
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpDn_SunsCount = new System.Windows.Forms.NumericUpDown();
            this.UpDn_Radius = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDn_CirclingSpeed = new System.Windows.Forms.NumericUpDown();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Txt_SunName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SunNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.UpDn_FirstNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpDn_Time = new System.Windows.Forms.NumericUpDown();
            this.UpDn_Emission = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Chb_Stack = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_SunsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_CirclingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_FirstNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Emission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suns count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius";
            // 
            // UpDn_SunsCount
            // 
            this.UpDn_SunsCount.BackColor = System.Drawing.Color.White;
            this.UpDn_SunsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDn_SunsCount.Location = new System.Drawing.Point(13, 40);
            this.UpDn_SunsCount.Name = "UpDn_SunsCount";
            this.UpDn_SunsCount.Size = new System.Drawing.Size(89, 16);
            this.UpDn_SunsCount.TabIndex = 2;
            // 
            // UpDn_Radius
            // 
            this.UpDn_Radius.BackColor = System.Drawing.Color.White;
            this.UpDn_Radius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDn_Radius.Location = new System.Drawing.Point(13, 98);
            this.UpDn_Radius.Name = "UpDn_Radius";
            this.UpDn_Radius.Size = new System.Drawing.Size(89, 16);
            this.UpDn_Radius.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Circling speed";
            // 
            // UpDn_CirclingSpeed
            // 
            this.UpDn_CirclingSpeed.BackColor = System.Drawing.Color.White;
            this.UpDn_CirclingSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDn_CirclingSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDn_CirclingSpeed.Location = new System.Drawing.Point(13, 165);
            this.UpDn_CirclingSpeed.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.UpDn_CirclingSpeed.Name = "UpDn_CirclingSpeed";
            this.UpDn_CirclingSpeed.Size = new System.Drawing.Size(89, 16);
            this.UpDn_CirclingSpeed.TabIndex = 5;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.White;
            this.Btn_Enter.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Btn_Enter.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(32)))));
            this.Btn_Enter.Location = new System.Drawing.Point(149, 25);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(81, 31);
            this.Btn_Enter.TabIndex = 6;
            this.Btn_Enter.Text = "Enter";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.White;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(32)))));
            this.Btn_Cancel.Location = new System.Drawing.Point(149, 211);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(81, 29);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Txt_SunName
            // 
            this.Txt_SunName.BackColor = System.Drawing.Color.White;
            this.Txt_SunName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SunName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_SunName.Location = new System.Drawing.Point(13, 221);
            this.Txt_SunName.Name = "Txt_SunName";
            this.Txt_SunName.Size = new System.Drawing.Size(81, 19);
            this.Txt_SunName.TabIndex = 8;
            this.Txt_SunName.Text = "s";
            this.Txt_SunName.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sun name";
            // 
            // SunNameTip
            // 
            this.SunNameTip.Popup += new System.Windows.Forms.PopupEventHandler(this.SunNameTip_Popup);
            // 
            // UpDn_FirstNum
            // 
            this.UpDn_FirstNum.BackColor = System.Drawing.Color.White;
            this.UpDn_FirstNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDn_FirstNum.Location = new System.Drawing.Point(156, 165);
            this.UpDn_FirstNum.Name = "UpDn_FirstNum";
            this.UpDn_FirstNum.Size = new System.Drawing.Size(60, 16);
            this.UpDn_FirstNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(138, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name offset";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(171, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time";
            // 
            // UpDn_Time
            // 
            this.UpDn_Time.BackColor = System.Drawing.Color.White;
            this.UpDn_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDn_Time.Location = new System.Drawing.Point(148, 98);
            this.UpDn_Time.Name = "UpDn_Time";
            this.UpDn_Time.Size = new System.Drawing.Size(82, 16);
            this.UpDn_Time.TabIndex = 14;
            // 
            // UpDn_Emission
            // 
            this.UpDn_Emission.BackColor = System.Drawing.Color.White;
            this.UpDn_Emission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDn_Emission.DecimalPlaces = 2;
            this.UpDn_Emission.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UpDn_Emission.Location = new System.Drawing.Point(258, 39);
            this.UpDn_Emission.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDn_Emission.Name = "UpDn_Emission";
            this.UpDn_Emission.Size = new System.Drawing.Size(89, 16);
            this.UpDn_Emission.TabIndex = 16;
            this.UpDn_Emission.ValueChanged += new System.EventHandler(this.UpDn_Emission_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(258, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Emission";
            // 
            // Chb_Stack
            // 
            this.Chb_Stack.AutoSize = true;
            this.Chb_Stack.ForeColor = System.Drawing.Color.Black;
            this.Chb_Stack.Location = new System.Drawing.Point(258, 96);
            this.Chb_Stack.Name = "Chb_Stack";
            this.Chb_Stack.Size = new System.Drawing.Size(90, 17);
            this.Chb_Stack.TabIndex = 17;
            this.Chb_Stack.Text = "Stack Events";
            this.Chb_Stack.UseVisualStyleBackColor = true;
            this.Chb_Stack.CheckedChanged += new System.EventHandler(this.Chb_Stack_CheckedChanged);
            // 
            // FillOrbitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(362, 259);
            this.Controls.Add(this.Chb_Stack);
            this.Controls.Add(this.UpDn_Emission);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpDn_Time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpDn_FirstNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_SunName);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.UpDn_CirclingSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpDn_Radius);
            this.Controls.Add(this.UpDn_SunsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FillOrbitForm";
            this.Text = "FillOrbitForm";
            this.Load += new System.EventHandler(this.FillOrbitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_SunsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_CirclingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_FirstNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Emission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Enter;
        public System.Windows.Forms.NumericUpDown UpDn_SunsCount;
        public System.Windows.Forms.NumericUpDown UpDn_Radius;
        public System.Windows.Forms.NumericUpDown UpDn_CirclingSpeed;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip SunNameTip;
        public System.Windows.Forms.TextBox Txt_SunName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown UpDn_FirstNum;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown UpDn_Time;
        public System.Windows.Forms.NumericUpDown UpDn_Emission;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox Chb_Stack;
    }
}