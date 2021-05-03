using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using IntralismToolBox.Forms.StoryboardForms;
using IntralismToolBox.Forms.StoryboardForms.GeometryFigures;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="MainForm.StoryboardAssistantButton"/> was pressed.
    /// </summary>
    public partial class StoryboardAssistantForm : ThemedForm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StoryboardAssistantForm"/> class.
        /// </summary>
        public StoryboardAssistantForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
            //CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en");
            ToolTip tp1 = new();
            tp1.SetToolTip(this.resetButton, "U just found an Undertale reeeeeeffffeeeeerrrrenceeeee");
        }

        private void FillOrbitButtonClicked(object sender, EventArgs e)
        {
            FillOrbitForm fillOrbitForm = new();

            if (fillOrbitForm.ShowDialog() == DialogResult.Yes)
            {
                string result = this.resultTextBox.Text;
                string sunName = fillOrbitForm.sunNameTextBox.Text;
                double sunCount = Convert.ToDouble(fillOrbitForm.sunsCountUpDown.Value);
                double speed = (double)fillOrbitForm.circlingSpeedUpDown.Value;
                double emission = (double)fillOrbitForm.emissionUpDown.Value;
                int firstNum = (int)fillOrbitForm.firstNumberUpDown.Value;
                double time = Convert.ToDouble(fillOrbitForm.timeUpDown.Value);
                double timeChanger = 0.001;
                double degrees = 360 / sunCount * (Math.PI / 180);
                double radius = Convert.ToDouble(fillOrbitForm.radiusUpDown.Value);
                bool stack = fillOrbitForm.stackedCheckBox.Checked;
                double[] x = new double[(int)sunCount + firstNum];
                double[] y = new double[(int)sunCount + firstNum];
                
                time += 0.001;
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{sunName + "Sat"}\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{sunName + "Sat"},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{sunName + "Sat"},0\"]}},";
                time += 0.001;
                
                if (stack)
                {
                    timeChanger = 0;
                }
                
                for (int i = 0; i < sunCount; i++)
                {
                    x[i] = Math.Round(radius * Math.Cos(degrees * i),3);
                    y[i] = Math.Round(radius * Math.Sin(degrees * i),3);
                }
                
                for (int i = firstNum, n = 0; i < sunCount + firstNum ; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + i}\"]}},";
                    time += timeChanger;
                    result += $"{{\"time\":{time + 0.0001},\"data\":[\"SetParent\",\"{sunName + i},{sunName + "Sat"}\"]}},";
                    time += timeChanger;
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetPosition\",\"{sunName + i},{x[n]},{y[n]},0\"]}},";
                    time += timeChanger;
                    result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetSunEmission\",\"{sunName + i},{emission}\"]}},";
                    n++;
                }
                
                result += $"{{\"time\":{time},\"data\":[\"SetSatelliteRotationSpeed\",\"{sunName + "Sat"},{speed}\"]}},";
                this.resultTextBox.Text = result;
            }
        }

        private void ResetButtonClicked(object sender, EventArgs e) => this.resultTextBox.Text = "";

        private void GradientColorButtonClicked(object sender, EventArgs e)
        {
            IntervalColorForm intervalColorForm = new();
            
            if (intervalColorForm.ShowDialog() == DialogResult.OK)
            {
                string name = intervalColorForm.objectNameTextBox.Text;
                double time1 = (double)intervalColorForm.timeStartUpDown.Value;
                double duration = (double)intervalColorForm.cycleDurationUpDown.Value;
                double count = (double)intervalColorForm.objectCountUpDown.Value;
                double laps = (double)intervalColorForm.lapsCountUpDown.Value;
                double timescale = duration / count / laps;
                double firstNum = (double)intervalColorForm.firstObjectNumberUpDown.Value;
                string[] hexColor = Array.Empty<string>();
                Color[] theColors = intervalColorForm.ChosenColor;
                int n = 0;

                if (intervalColorForm.Stacked)
                {
                    timescale = 0;
                }
                
                for (int c = 0; c < intervalColorForm.ChosenColor.Length; c++)
                {
                    Array.Resize(ref hexColor, hexColor.Length + 1);
                    hexColor[c] = theColors[c].R.ToString("X2") + theColors[c].G.ToString("X2") + theColors[c].B.ToString("X2");
                    
                    if (intervalColorForm.ObjEv == "SetSunColors")
                    {
                        hexColor[c] = $"{hexColor[c]},#{hexColor[c]}";
                    }
                }
                
                for (double u = time1; u <= duration + time1; u += duration / laps)
                {
                    if (n == hexColor.Length)
                    {
                        n = 0;
                    }
                    
                    for (int i = (int)firstNum; i < count + firstNum; i++)
                    {
                        this.resultTextBox.Text += 
                            $@"{{""time"":{u + timescale},""data"":[""{intervalColorForm.ObjEv}"",""{name + i},#{hexColor[n]}""]}},";
                        
                        timescale += timescale;
                    }
                    
                    n++;
                }
            }
        }

        private void AutoGradientButtonClicked(object sender, EventArgs e)
        {
            AutoGradientForm autoGradientForm = new();
            
            if (autoGradientForm.ShowDialog() == DialogResult.OK)
            {
                string result = this.resultTextBox.Text;
                double offset = (double)autoGradientForm.timeStartUpDown.Value, duration = (double)autoGradientForm.fullDurationUpDown.Value;
                Color[] twoColors = autoGradientForm.TwoColors;

                double redCoef = duration / Math.Abs(Math.Max(twoColors[0].R, twoColors[1].R) - Math.Min(twoColors[0].R, twoColors[1].R));
                double greenCoef = duration / Math.Abs(Math.Max(twoColors[0].G, twoColors[1].G) - Math.Min(twoColors[0].G, twoColors[1].G));
                double blueCoef = duration / Math.Abs(Math.Max(twoColors[0].B, twoColors[1].B) - Math.Min(twoColors[0].B, twoColors[1].B));
                double mainTimeScale = Math.Min(redCoef,Math.Min(blueCoef,greenCoef));

                int rSign = 0, gSign = 0, bSign = 0;
                int i = 0;

                if (twoColors[0].R < twoColors[1].R)
                {
                    rSign = 1;
                    
                } else if (twoColors[0].R > twoColors[1].R)
                {
                    rSign = -1;
                }

                if (twoColors[0].G < twoColors[1].G)
                {
                    gSign = 1;
                    
                } else if (twoColors[0].G > twoColors[1].G)
                {
                    gSign = -1;
                }

                if (twoColors[0].B < twoColors[1].B)
                {
                    bSign = 1;
                    
                } else if (twoColors[0].B > twoColors[1].B)
                {
                    bSign = -1;
                }
                
                double tempRed = twoColors[0].R;
                double tempGreen = twoColors[0].G;
                double tempBlue = twoColors[0].B;
                
                while (true)
                {
                    if (offset >= duration + (double)autoGradientForm.timeStartUpDown.Value)
                    {
                        break;
                    }
                    
                    if (i == autoGradientForm.objectCountUpDown.Value)
                    {
                        if ((tempRed < twoColors[1].R && rSign == 1) ||
                            (tempRed > twoColors[1].R && rSign == -1))
                        {
                            tempRed += rSign;
                        }

                        if ((tempGreen < twoColors[1].G && gSign == 1) ||
                            (tempGreen > twoColors[1].G && gSign == -1))
                        {
                            tempGreen += gSign;
                        }

                        if ((tempBlue < twoColors[1].B && bSign == 1) ||
                            (tempBlue > twoColors[1].B && bSign == -1))
                        {
                            tempBlue += bSign;
                        }
                        
                        i = 0;
                        offset += mainTimeScale;
                        twoColors[0] = Color.FromArgb((int)tempRed, (int)tempGreen,(int)tempBlue);
                    }
                    
                    string hexColor = this.GetHex(twoColors[0]);
                    
                    if (autoGradientForm.ObjEv == "SetSunColors")
                    {
                        hexColor = $"{hexColor} , #{hexColor}";
                    }
                    
                    result += $"{{\"time\":{offset},\"data\":[\"{autoGradientForm.ObjEv}\",\"{autoGradientForm.objectNameTextBox.Text + i}," +
                              $"#{hexColor}\"]}},";
                    i++;
                }
                
                this.resultTextBox.Text = result;
            }
        }
        private string GetHex(Color col) => col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2");

        private void GeometricFiguresButtonClicked(object sender, EventArgs e)
        {
            GeometryForm geometryForm = new();

            if (geometryForm.ShowDialog() == DialogResult.OK)
            {
                this.resultTextBox.Text += geometryForm.resultTextBox.Text;
            }
        }
    }
}
