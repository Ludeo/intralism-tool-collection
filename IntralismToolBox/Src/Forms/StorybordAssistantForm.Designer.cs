
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
            this.Btn_FillOrbit = new System.Windows.Forms.Button();
            this.Txt_Result = new System.Windows.Forms.RichTextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.IntervalColor = new System.Windows.Forms.Button();
            this.Btn_AutoGradient = new System.Windows.Forms.Button();
            this.Btn_GmFigures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_FillOrbit
            // 
            this.Btn_FillOrbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_FillOrbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FillOrbit.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FillOrbit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.Btn_FillOrbit.Location = new System.Drawing.Point(28, 28);
            this.Btn_FillOrbit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_FillOrbit.Name = "Btn_FillOrbit";
            this.Btn_FillOrbit.Size = new System.Drawing.Size(161, 34);
            this.Btn_FillOrbit.TabIndex = 0;
            this.Btn_FillOrbit.Text = "Fill orbit";
            this.Btn_FillOrbit.UseVisualStyleBackColor = false;
            this.Btn_FillOrbit.Click += new System.EventHandler(this.Btn_FillOrbit_Click);
            // 
            // Txt_Result
            // 
            this.Txt_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Result.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Result.Location = new System.Drawing.Point(558, 28);
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Size = new System.Drawing.Size(260, 210);
            this.Txt_Result.TabIndex = 1;
            this.Txt_Result.Text = "";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.Btn_Reset.Location = new System.Drawing.Point(448, 28);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(100, 34);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // IntervalColor
            // 
            this.IntervalColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.IntervalColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntervalColor.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.IntervalColor.Location = new System.Drawing.Point(28, 74);
            this.IntervalColor.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.IntervalColor.Name = "IntervalColor";
            this.IntervalColor.Size = new System.Drawing.Size(204, 34);
            this.IntervalColor.TabIndex = 4;
            this.IntervalColor.Text = "Interval changing color";
            this.IntervalColor.UseVisualStyleBackColor = false;
            this.IntervalColor.Click += new System.EventHandler(this.GradientColor_Click);
            // 
            // Btn_AutoGradient
            // 
            this.Btn_AutoGradient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_AutoGradient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AutoGradient.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AutoGradient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.Btn_AutoGradient.Location = new System.Drawing.Point(28, 119);
            this.Btn_AutoGradient.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_AutoGradient.Name = "Btn_AutoGradient";
            this.Btn_AutoGradient.Size = new System.Drawing.Size(161, 34);
            this.Btn_AutoGradient.TabIndex = 6;
            this.Btn_AutoGradient.Text = "Gradient";
            this.Btn_AutoGradient.UseVisualStyleBackColor = false;
            this.Btn_AutoGradient.Click += new System.EventHandler(this.Btn_AutoGradient_Click);
            // 
            // Btn_GmFigures
            // 
            this.Btn_GmFigures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_GmFigures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GmFigures.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GmFigures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.Btn_GmFigures.Location = new System.Drawing.Point(28, 165);
            this.Btn_GmFigures.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_GmFigures.Name = "Btn_GmFigures";
            this.Btn_GmFigures.Size = new System.Drawing.Size(204, 34);
            this.Btn_GmFigures.TabIndex = 7;
            this.Btn_GmFigures.Text = "Geometric figures";
            this.Btn_GmFigures.UseVisualStyleBackColor = false;
            this.Btn_GmFigures.Click += new System.EventHandler(this.Btn_GmFigures_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(830, 374);
            this.Controls.Add(this.Btn_GmFigures);
            this.Controls.Add(this.Btn_AutoGradient);
            this.Controls.Add(this.IntervalColor);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Txt_Result);
            this.Controls.Add(this.Btn_FillOrbit);
            this.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoryboardAssistantForm";
            this.ShowIcon = false;
            this.Text = "Storyboard assistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_FillOrbit;
        private System.Windows.Forms.RichTextBox Txt_Result;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button IntervalColor;
        private System.Windows.Forms.Button Btn_AutoGradient;
        private System.Windows.Forms.Button Btn_GmFigures;
    }
}

