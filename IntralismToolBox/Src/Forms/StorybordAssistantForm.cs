using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using IntralismToolBox.Forms.StoryboardForms;
using IntralismToolBox.Forms.StoryboardForms.GeometryFigures;

namespace IntralismToolBox.Forms
{
    public partial class StoryboardAssistantForm : Form
    {
        public StoryboardAssistantForm()
        {
            this.InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en");
            ToolTip tp1 = new ();
            tp1.SetToolTip(this.Btn_Reset, "U just found an Undertale reeeeeeffffeeeeerrrrenceeeee");
        }

        private void Btn_FillOrbit_Click(object sender, EventArgs e)
        {
            FillOrbitForm fillOrbitForm = new ();
            if (fillOrbitForm.ShowDialog() == DialogResult.Yes)
            {
                string result = this.Txt_Result.Text;
                string sunName = fillOrbitForm.Txt_SunName.Text;
                double sunCount = Convert.ToDouble(fillOrbitForm.UpDn_SunsCount.Value);
                double speed = (double)fillOrbitForm.UpDn_CirclingSpeed.Value;
                double emission = (double)fillOrbitForm.UpDn_Emission.Value;
                int firstNum = (int)fillOrbitForm.UpDn_FirstNum.Value;
                double time = Convert.ToDouble(fillOrbitForm.UpDn_Time.Value);
                double timeChanger = 0.001;
                double degrees = (360 / sunCount) * (Math.PI / 180);
                double radius = Convert.ToDouble(fillOrbitForm.UpDn_Radius.Value);
                bool stack = fillOrbitForm.Chb_Stack.Checked;
                double[] x = new double[(int)sunCount + firstNum];
                double[] y = new double[(int)sunCount + firstNum];
                Console.WriteLine($" {sunCount} , {degrees} , {speed} , {time} , {radius}");
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
                this.Txt_Result.Text = result;
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e) => this.Txt_Result.Text = "";

        private void GradientColor_Click(object sender, EventArgs e)
        {
            IntervalColor intervalColor = new ();
            if (intervalColor.ShowDialog() == DialogResult.OK)
            {
                string name = intervalColor.Txt_ObjName.Text;
                double time1 = (double)intervalColor.UpDn_TimeStart.Value;
                double duration = (double)intervalColor.UpDn_CycleDuration.Value;
                double count = (double)intervalColor.UpDn_ObjCount.Value;
                double laps = (double)intervalColor.UpDn_LapCount.Value;
                double timescale = duration / count / laps;
                double firstNum = (double)intervalColor.UpDn_FirstObjNum.Value;
                string[] hexColor = new string[0];
                Color[] theColors = intervalColor.ChosenColor;
                int n = 0;

                if (intervalColor.Stacked)
                {
                    timescale = 0;
                }
                for (int c = 0; c < intervalColor.ChosenColor.Length; c++)
                {
                    Array.Resize(ref hexColor, hexColor.Length + 1);
                    hexColor[c] = theColors[c].R.ToString("X2") + theColors[c].G.ToString("X2") + theColors[c].B.ToString("X2");
                    if (intervalColor.ObjEv == "SetSunColors")
                    {
                        hexColor[c] = $"{hexColor[c]},#{hexColor[c]}";
                    }
                }
                for (double u = time1; u <= (duration + time1); u += duration / laps)
                {
                    Console.WriteLine(u);
                    if (n == hexColor.Length)
                    {
                        n = 0;
                    }
                    for (int i = (int)firstNum; i < count + firstNum; i++)
                    {
                        this.Txt_Result.Text += $"{{\"time\":{u + timescale},\"data\":[\"{intervalColor.ObjEv}\",\"{name + i},#{hexColor[n]}\"]}},";
                        timescale += timescale;
                    }
                    n++;
                    
                }
            }
        }

        private void Btn_AutoGradient_Click(object sender, EventArgs e)
        {
            AutoGradient autoGradient = new ();
            if (autoGradient.ShowDialog() == DialogResult.OK)
            {
                string result = this.Txt_Result.Text;
                double offset = (double)autoGradient.UpDn_TimeStart.Value, duration = (double)autoGradient.UpDn_FullDuration.Value;
                Color[] twoColors = autoGradient.TwoColors;
                bool check = false;

                double redCoef = (duration / Math.Abs(Math.Max(twoColors[0].R, twoColors[1].R) - Math.Min(twoColors[0].R, twoColors[1].R)));
                double greenCoef = (duration / Math.Abs(Math.Max(twoColors[0].G, twoColors[1].G) - Math.Min(twoColors[0].G, twoColors[1].G)));
                double blueCoef = (duration / Math.Abs(Math.Max(twoColors[0].B, twoColors[1].B) - Math.Min(twoColors[0].B, twoColors[1].B)));
                double mainTimeScale = Math.Min(redCoef,Math.Min(blueCoef,greenCoef));

                if (double.IsInfinity(redCoef))
                {
                    redCoef = 0;
                }

                if (double.IsInfinity(greenCoef))
                {
                    greenCoef = 0;
                }

                if (double.IsInfinity(blueCoef))
                {
                    blueCoef = 0;
                }
                int rSign = 0, gSign = 0, bSign = 0;
                int i = 0;
                string hexColor;
                if (twoColors[0].R < twoColors[1].R) { rSign = 1; } else if (twoColors[0].R > twoColors[1].R) { rSign = -1;}
                if (twoColors[0].G < twoColors[1].G) { gSign = 1; } else if (twoColors[0].G > twoColors[1].G) { gSign = -1;}
                if (twoColors[0].B < twoColors[1].B) { bSign = 1; } else if (twoColors[0].B > twoColors[1].B) { bSign = -1;}
                double tempRed = twoColors[0].R;
                double tempGreen = twoColors[0].G;
                double tempBlue = twoColors[0].B;
                
                while (check == false)
                {
                    if (offset >= duration + (double)autoGradient.UpDn_TimeStart.Value)
                    {
                        check = true;
                        break;
                    }
                    if (i == autoGradient.UpDn_ObjCount.Value)
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
                    hexColor = this.GetHex(twoColors[0]);
                    if (autoGradient.ObjEv == "SetSunColors")
                    {
                        hexColor = $"{hexColor} , #{hexColor}";
                    }
                    result += $"{{\"time\":{offset},\"data\":[\"{autoGradient.ObjEv}\",\"{autoGradient.Txt_ObjName.Text + i},#{hexColor}\"]}},";
                    i++;
                    Console.WriteLine($"{twoColors[0].R} , {twoColors[0].G} , {twoColors[0].B} \n"
                    + $"{twoColors[1].R} , {twoColors[1].G} , {twoColors[1].B} \n"
                        + mainTimeScale + "\n" +
                    $"Coefs: R {redCoef} , G {greenCoef} , B {blueCoef} \n" +
                    $"rsign {rSign} , gsign {gSign} , bsign {bSign}");
                }
                this.Txt_Result.Text = result;
            }
        }
        private string GetHex(Color col) => col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2");

        private void Btn_GmFigures_Click(object sender, EventArgs e)
        {
            GeometryForm geometryForm = new ();

            if (geometryForm.ShowDialog() == DialogResult.OK)
            {
                this.Txt_Result.Text += geometryForm.Txt_Result.Text;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) { }
    }
}
