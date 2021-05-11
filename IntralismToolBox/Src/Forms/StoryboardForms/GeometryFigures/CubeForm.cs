using System;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="GeometryForm.cubeButton"/> was pressed.
    /// </summary>
    public partial class CubeForm : ThemedForm
    {
        private readonly GeometryForm geometryForm;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CubeForm"/> class.
        /// </summary>
        public CubeForm(GeometryForm geometryForm)
        {
            this.InitializeComponent();
            this.ReloadTheme();

            ToolTip helpButtonToolTip = new();

            helpButtonToolTip.SetToolTip(this.helpButton,
                                         "It will be name of satellite to which the cube(all the suns) will be attached \n" +
                                         " all suns will have additional \"S\" in names like \"Sat, SatS0, SatS1 ...\"");

            ToolTip timeStartUpDownToolTip = new();
            timeStartUpDownToolTip.SetToolTip(this.timeStartUpDown, "When will we spawn a cube?");

            this.geometryForm = geometryForm;
        }

        private void EnterButtonClicked(object sender, EventArgs e)
        {
            string result = this.geometryForm.resultTextBox.Text;
            double sideL = (double)this.sideLengthUpDown.Value;
            double sidePos = sideL / 2;
            double time = (double)this.timeStartUpDown.Value;
            string sunName = this.objectNameTextBox.Text + "S";

            // spawning satellite
            result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{this.objectNameTextBox.Text}\"]}},";
            result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{this.objectNameTextBox.Text},0\"]}},";
            result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{this.objectNameTextBox.Text},0\"]}},";
            result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRotationSpeed\",\"{this.objectNameTextBox.Text},0\"]}},";

            // spawning suns
            for (int i = (int)this.firstNumberUpDown.Value; i < 12 + this.firstNumberUpDown.Value; i++)
            {
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + i}\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{sunName + i},{this.objectNameTextBox.Text}\"]}},";

                result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMaxSize\",\"{sunName + i},{sideL},{this.sideWidthUpDown.Value}," +
                          $"{this.sideWidthUpDown.Value}\"]}},";

                result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMinSize\",\"{sunName + i},{sideL},{this.sideWidthUpDown.Value}," +
                          $"{this.sideWidthUpDown.Value}\"]}},";
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
            this.geometryForm.resultTextBox.Text += result;

            this.Close();
        }

        private void CancelButtonClicked(object sender, EventArgs e) => this.Close();
    }
}
