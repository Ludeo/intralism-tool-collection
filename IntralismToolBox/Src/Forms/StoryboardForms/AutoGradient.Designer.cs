
namespace IntralismToolBox.Forms.StoryboardForms
{
    partial class AutoGradient
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
            this.label7 = new System.Windows.Forms.Label();
            this.UpDn_FullDuration = new System.Windows.Forms.NumericUpDown();
            this.UpDn_ColCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpDn_TimeStart = new System.Windows.Forms.NumericUpDown();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UpDn_FirstObjNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDn_ObjCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_TypeList = new System.Windows.Forms.ComboBox();
            this.Txt_ObjName = new System.Windows.Forms.TextBox();
            this.Pb_Demo1 = new System.Windows.Forms.PictureBox();
            this.Btn_Choose1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Pb_Demo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_FullDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_ColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_TimeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_FirstObjNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_ObjCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Demo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Demo2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(297, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Full duration";
            // 
            // UpDn_FullDuration
            // 
            this.UpDn_FullDuration.BackColor = System.Drawing.Color.White;
            this.UpDn_FullDuration.Location = new System.Drawing.Point(300, 199);
            this.UpDn_FullDuration.Name = "UpDn_FullDuration";
            this.UpDn_FullDuration.Size = new System.Drawing.Size(72, 20);
            this.UpDn_FullDuration.TabIndex = 53;
            // 
            // UpDn_ColCount
            // 
            this.UpDn_ColCount.BackColor = System.Drawing.Color.White;
            this.UpDn_ColCount.Enabled = false;
            this.UpDn_ColCount.Location = new System.Drawing.Point(300, 141);
            this.UpDn_ColCount.Name = "UpDn_ColCount";
            this.UpDn_ColCount.Size = new System.Drawing.Size(72, 20);
            this.UpDn_ColCount.TabIndex = 52;
            this.UpDn_ColCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(299, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Colors count";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(169, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Time (offset)";
            // 
            // UpDn_TimeStart
            // 
            this.UpDn_TimeStart.BackColor = System.Drawing.Color.White;
            this.UpDn_TimeStart.Location = new System.Drawing.Point(172, 199);
            this.UpDn_TimeStart.Name = "UpDn_TimeStart";
            this.UpDn_TimeStart.Size = new System.Drawing.Size(72, 20);
            this.UpDn_TimeStart.TabIndex = 49;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.White;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(49)))), ((int)(((byte)(35)))));
            this.Btn_Cancel.Location = new System.Drawing.Point(284, 65);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(117, 28);
            this.Btn_Cancel.TabIndex = 48;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.White;
            this.Btn_Enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Enter.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(49)))), ((int)(((byte)(35)))));
            this.Btn_Enter.Location = new System.Drawing.Point(284, 23);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(117, 28);
            this.Btn_Enter.TabIndex = 47;
            this.Btn_Enter.Text = "Enter";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(169, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Name offset";
            // 
            // UpDn_FirstObjNum
            // 
            this.UpDn_FirstObjNum.BackColor = System.Drawing.Color.White;
            this.UpDn_FirstObjNum.Location = new System.Drawing.Point(172, 141);
            this.UpDn_FirstObjNum.Name = "UpDn_FirstObjNum";
            this.UpDn_FirstObjNum.Size = new System.Drawing.Size(72, 20);
            this.UpDn_FirstObjNum.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Count of objects";
            // 
            // UpDn_ObjCount
            // 
            this.UpDn_ObjCount.BackColor = System.Drawing.Color.White;
            this.UpDn_ObjCount.Location = new System.Drawing.Point(20, 199);
            this.UpDn_ObjCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDn_ObjCount.Name = "UpDn_ObjCount";
            this.UpDn_ObjCount.Size = new System.Drawing.Size(120, 20);
            this.UpDn_ObjCount.TabIndex = 43;
            this.UpDn_ObjCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Obj Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Obj Type";
            // 
            // Cmb_TypeList
            // 
            this.Cmb_TypeList.BackColor = System.Drawing.Color.White;
            this.Cmb_TypeList.FormattingEnabled = true;
            this.Cmb_TypeList.Items.AddRange(new object[] {
            "Sun",
            "Satellite",
            "Particles"});
            this.Cmb_TypeList.Location = new System.Drawing.Point(20, 83);
            this.Cmb_TypeList.Name = "Cmb_TypeList";
            this.Cmb_TypeList.Size = new System.Drawing.Size(123, 21);
            this.Cmb_TypeList.TabIndex = 40;
            this.Cmb_TypeList.SelectedIndexChanged += new System.EventHandler(this.Cmb_TypeList_SelectedIndexChanged);
            // 
            // Txt_ObjName
            // 
            this.Txt_ObjName.BackColor = System.Drawing.Color.White;
            this.Txt_ObjName.Location = new System.Drawing.Point(20, 141);
            this.Txt_ObjName.Name = "Txt_ObjName";
            this.Txt_ObjName.Size = new System.Drawing.Size(123, 20);
            this.Txt_ObjName.TabIndex = 39;
            this.Txt_ObjName.Text = "s";
            // 
            // Pb_Demo1
            // 
            this.Pb_Demo1.BackColor = System.Drawing.Color.LightGray;
            this.Pb_Demo1.Location = new System.Drawing.Point(149, 23);
            this.Pb_Demo1.Name = "Pb_Demo1";
            this.Pb_Demo1.Size = new System.Drawing.Size(129, 39);
            this.Pb_Demo1.TabIndex = 38;
            this.Pb_Demo1.TabStop = false;
            // 
            // Btn_Choose1
            // 
            this.Btn_Choose1.BackColor = System.Drawing.Color.White;
            this.Btn_Choose1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Choose1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(49)))), ((int)(((byte)(35)))));
            this.Btn_Choose1.Location = new System.Drawing.Point(16, 23);
            this.Btn_Choose1.Name = "Btn_Choose1";
            this.Btn_Choose1.Size = new System.Drawing.Size(127, 28);
            this.Btn_Choose1.TabIndex = 37;
            this.Btn_Choose1.Text = "Choose Colors";
            this.Btn_Choose1.UseVisualStyleBackColor = false;
            this.Btn_Choose1.Click += new System.EventHandler(this.Btn_Choose1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(410, 36);
            this.label9.TabIndex = 58;
            this.label9.Text = "Auto means that gradient will be counted from first color to second\r\n( there will" +
    " be alot more colors than non-auto version has )";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Pb_Demo2
            // 
            this.Pb_Demo2.BackColor = System.Drawing.Color.LightGray;
            this.Pb_Demo2.Location = new System.Drawing.Point(149, 65);
            this.Pb_Demo2.Name = "Pb_Demo2";
            this.Pb_Demo2.Size = new System.Drawing.Size(129, 39);
            this.Pb_Demo2.TabIndex = 59;
            this.Pb_Demo2.TabStop = false;
            // 
            // AutoGradient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(426, 266);
            this.Controls.Add(this.Pb_Demo2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpDn_FullDuration);
            this.Controls.Add(this.UpDn_ColCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpDn_TimeStart);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpDn_FirstObjNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpDn_ObjCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_TypeList);
            this.Controls.Add(this.Txt_ObjName);
            this.Controls.Add(this.Pb_Demo1);
            this.Controls.Add(this.Btn_Choose1);
            this.Name = "AutoGradient";
            this.Text = "AutoGradient";
            this.Load += new System.EventHandler(this.AutoGradient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_FullDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_ColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_TimeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_FirstObjNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_ObjCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Demo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Demo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown UpDn_FullDuration;
        public System.Windows.Forms.NumericUpDown UpDn_ColCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown UpDn_TimeStart;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown UpDn_FirstObjNum;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown UpDn_ObjCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Cmb_TypeList;
        public System.Windows.Forms.TextBox Txt_ObjName;
        private System.Windows.Forms.PictureBox Pb_Demo1;
        private System.Windows.Forms.Button Btn_Choose1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Pb_Demo2;
    }
}