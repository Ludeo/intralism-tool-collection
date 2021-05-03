using System;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="StoryboardAssistantForm.geometricFiguresButton"/> was pressed.
    /// </summary>
    public partial class GeometryForm : ThemedForm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GeometryForm"/> class.
        /// </summary>
        public GeometryForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
            ToolTip helpButtonToolTip = new();
            helpButtonToolTip.SetToolTip(this.helpButton, "That's something like buffer to contain figures only \n" +
                                          " so if you mess up with the figures you will not mess up all the text in the Mainform");
        }

        private void CubeButtonClicked(object sender, EventArgs e)
        {
            CubeForm cubeForm = new();
            
            if (cubeForm.ShowDialog() == DialogResult.OK)
            {
                string result = this.resultTextBox.Text;
                double sideL = (double)cubeForm.sideLengthUpDown.Value;
                double sidePos = sideL / 2;
                double time = (double)cubeForm.timeStartUpDown.Value;
                string sunName = cubeForm.objectNameTextBox.Text + "S";
                
                // spawning satellite
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{cubeForm.objectNameTextBox.Text}\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{cubeForm.objectNameTextBox.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{cubeForm.objectNameTextBox.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRotationSpeed\",\"{cubeForm.objectNameTextBox.Text},0\"]}},";
                
                // spawning suns
                for (int i = (int)cubeForm.firstNumberUpDown.Value; i < 12 + cubeForm.firstNumberUpDown.Value; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + i}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{sunName + i},{cubeForm.objectNameTextBox.Text}\"]}},";
                    result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMaxSize\",\"{sunName + i},{sideL},{cubeForm.sideWidthUpDown.Value}," +
                              $"{cubeForm.sideWidthUpDown.Value}\"]}},";
                    result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMinSize\",\"{sunName + i},{sideL},{cubeForm.sideWidthUpDown.Value}," +
                              $"{cubeForm.sideWidthUpDown.Value}\"]}},";
                }                                                                                             
                                                                                                              
                // building a cube                                                                       
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "0"},{sidePos},{sidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "1"},{sidePos},{-sidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "2"},{sidePos},0,{sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "3"},{sidePos},0,{-sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "4"},{-sidePos},{sidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "5"},{-sidePos},{-sidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "6"},{-sidePos},0,{sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "7"},{-sidePos},0,{-sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "8"},0,{sidePos},{sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "9"},0,{sidePos},{-sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "10"},0,{-sidePos},{sidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{sunName + "11"},0,{-sidePos},{-sidePos}\"]}},";
                
                // rotating parts                                                   
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "0"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "1"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "2"},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "3"},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "4"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "5"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "6"},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{sunName + "7"},0,0,90\"]}},";
                
                // done
                this.resultTextBox.Text += result;
            }
        }
    }
}
