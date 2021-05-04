using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="StoryboardAssistantForm.autoGradientButton"/> was pressed.
    /// </summary>
    public partial class AutoGradientForm : ThemedForm
    {
        private readonly Color[] twoColors = new Color[2];

        private string objEv;

        private readonly StoryboardAssistantForm storyboardAssistantForm;
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="AutoGradientForm"/> class.
        /// </summary>
        public AutoGradientForm(StoryboardAssistantForm storyboardAssistantForm)
        {
            this.InitializeComponent();
            this.ReloadTheme();
            this.storyboardAssistantForm = storyboardAssistantForm;
        }

        private void ChooseButtonClicked(object sender, EventArgs e)
        {
            Bitmap map1 = new(this.demo1PictureBox.Width,this.demo1PictureBox.Height);
            Bitmap map2 = new(this.demo2PictureBox.Width, this.demo2PictureBox.Height);
            Graphics graph1 = Graphics.FromImage(map1);
            Graphics graph2 = Graphics.FromImage(map2);
            ColorDialog colorDialog = new();
            
            for (int i = 0; i < 2; i++)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.twoColors[i] = colorDialog.Color;
                }
            }
            
            graph1.Clear(this.twoColors[0]);
            this.demo1PictureBox.Image = map1;
            graph2.Clear(this.twoColors[1]);
            this.demo2PictureBox.Image = map2;
        }

        private void EnterButtonClicked(object sender, EventArgs e)
        {
            this.objEv = this.objectTypeComboBox.SelectedIndex switch
            {
                0 => "SetSunColors",
                1 => "SetSatelliteColor",
                2 => "SetParticlesColor",
                _ => "SetSunColors",
            };
            
            string result = this.storyboardAssistantForm.resultTextBox.Text;
            double offset = (double)this.timeStartUpDown.Value;
            double duration = (double)this.fullDurationUpDown.Value;
            Color[] twoEndColors = this.twoColors;

            double redCoef = duration / Math.Abs(Math.Max(twoEndColors[0].R, twoEndColors[1].R) - Math.Min(twoEndColors[0].R, twoEndColors[1].R));
            double greenCoef = duration / Math.Abs(Math.Max(twoEndColors[0].G, twoEndColors[1].G) - Math.Min(twoEndColors[0].G, twoEndColors[1].G));
            double blueCoef = duration / Math.Abs(Math.Max(twoEndColors[0].B, twoEndColors[1].B) - Math.Min(twoEndColors[0].B, twoEndColors[1].B));
            double mainTimeScale = Math.Min(redCoef,Math.Min(blueCoef,greenCoef));

            int rSign = 0;
            int gSign = 0;
            int bSign = 0;
            int i = 0;

            if (twoEndColors[0].R < twoEndColors[1].R)
            {
                rSign = 1;
                
            } else if (twoEndColors[0].R > twoEndColors[1].R)
            {
                rSign = -1;
            }

            if (twoEndColors[0].G < twoEndColors[1].G)
            {
                gSign = 1;
                
            } else if (twoEndColors[0].G > twoEndColors[1].G)
            {
                gSign = -1;
            }

            if (twoEndColors[0].B < twoEndColors[1].B)
            {
                bSign = 1;
                
            } else if (twoEndColors[0].B > twoEndColors[1].B)
            {
                bSign = -1;
            }
            
            double tempRed = twoEndColors[0].R;
            double tempGreen = twoEndColors[0].G;
            double tempBlue = twoEndColors[0].B;
            
            while (true)
            {
                if (offset >= duration + (double)this.timeStartUpDown.Value)
                {
                    break;
                }
                
                if (i == this.objectCountUpDown.Value)
                {
                    if ((tempRed < twoEndColors[1].R && rSign == 1) ||
                        (tempRed > twoEndColors[1].R && rSign == -1))
                    {
                        tempRed += rSign;
                    }

                    if ((tempGreen < twoEndColors[1].G && gSign == 1) ||
                        (tempGreen > twoEndColors[1].G && gSign == -1))
                    {
                        tempGreen += gSign;
                    }

                    if ((tempBlue < twoEndColors[1].B && bSign == 1) ||
                        (tempBlue > twoEndColors[1].B && bSign == -1))
                    {
                        tempBlue += bSign;
                    }
                    
                    i = 0;
                    offset += mainTimeScale;
                    twoEndColors[0] = Color.FromArgb((int)tempRed, (int)tempGreen,(int)tempBlue);
                }
                
                string hexColor = this.GetHex(twoEndColors[0]);
                
                if (this.objEv == "SetSunColors")
                {
                    hexColor = $"{hexColor} , #{hexColor}";
                }
                
                result += $"{{\"time\":{offset},\"data\":[\"{this.objEv}\",\"{this.objectNameTextBox.Text + i},#{hexColor}\"]}},";
                i++;
            }
            
            this.storyboardAssistantForm.resultTextBox.Text = result;
            
            this.Close();
        }
        
        private string GetHex(Color color) => color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");

        private void CancelButtonClicked(object sender, EventArgs e) => this.Close();
    }
}
