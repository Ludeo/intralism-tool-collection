using System;

namespace IntralismToolBox.Forms.StoryboardForms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="StoryboardAssistantForm.fillOrbitButton"/> was pressed.
    /// </summary>
    public partial class FillOrbitForm : ThemedForm
    {
        private readonly StoryboardAssistantForm storyboardAssistantForm;
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="FillOrbitForm"/> class.
        /// </summary>
        public FillOrbitForm(StoryboardAssistantForm storyboardAssistantForm)
        {
            this.InitializeComponent();
            this.ReloadTheme();
            
            this.sunNameToolTip.SetToolTip(this.sunNameTextBox, 
                                           "If you write here \"Sun\", suns will be called like \"Sun0\", \"Sun1\", \"Sun2\"...");
            
            this.emissionUpDown.Increment = 0.5M;
            this.storyboardAssistantForm = storyboardAssistantForm;
        }

        private void EnterButtonClicked(object sender, EventArgs e)
        {
            string result = this.storyboardAssistantForm.resultTextBox.Text;
            string sunName = this.sunNameTextBox.Text;
            double sunCount = Convert.ToDouble(this.sunsCountUpDown.Value);
            double speed = (double)this.circlingSpeedUpDown.Value;
            double emission = (double)this.emissionUpDown.Value;
            int firstNum = (int)this.firstNumberUpDown.Value;
            double time = Convert.ToDouble(this.timeUpDown.Value);
            double timeChanger = 0.001;
            double degrees = 360 / sunCount * (Math.PI / 180);
            double radius = Convert.ToDouble(this.radiusUpDown.Value);
            bool stack = this.stackedCheckBox.Checked;
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
            this.storyboardAssistantForm.resultTextBox.Text = result;
            
            this.Close();
        }

        private void CancelButtonClicked(object sender, EventArgs e) => this.Close();
    }
}
