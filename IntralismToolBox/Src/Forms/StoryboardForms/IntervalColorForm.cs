using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="StoryboardAssistantForm.intervalColorButton"/> was pressed.
    /// </summary>
    public partial class IntervalColorForm : ThemedForm
    {
        private Color[] chosenColor;
        
        private string objEv;
        
        private bool stacked;

        private readonly StoryboardAssistantForm storyboardAssistantForm;
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="IntervalColorForm"/> class.
        /// </summary>
        public IntervalColorForm(StoryboardAssistantForm storyboardAssistantForm)
        {
            this.InitializeComponent();
            this.ReloadTheme();
            this.chosenColor = Array.Empty<Color>();
            this.stacked = false;
            ToolTip tip1 = new();
            tip1.SetToolTip(this.stackedCheckBox,"All your objects are changing color at the same time or one after another");
            this.storyboardAssistantForm = storyboardAssistantForm;
        }

        private void ChooseButtonClicked(object sender, EventArgs e)
        {
            Bitmap map = new(this.demoPictureBox.Width, this.demoPictureBox.Height);
            Graphics graph = Graphics.FromImage(map);
            
            for (int g = 0; g < this.colorsCountUpDown.Value; g++)
            {
                ColorDialog colorDialog = new();
                
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Array.Resize(ref this.chosenColor, this.chosenColor.Length + 1);
                    this.chosenColor[g] = colorDialog.Color;
                    graph.Clear(this.chosenColor[g]);
                    this.demoPictureBox.Image = map;
                }
            }

            this.objEv = this.objectTypeComboBox.SelectedIndex switch
            {
                0 => "SetSunColors",
                1 => "SetSatelliteColor",
                2 => "SetParticlesColor",
                var _ => "SetSunColors",
            };
        }

        private void StackedCheckBoxChanged(object sender, EventArgs e) => this.stacked = this.stackedCheckBox.Checked;

        private void EnterButtonClicked(object sender, EventArgs e)
        {
            string name = this.objectNameTextBox.Text;
            double time1 = (double)this.timeStartUpDown.Value;
            double duration = (double)this.cycleDurationUpDown.Value;
            double count = (double)this.objectCountUpDown.Value;
            double laps = (double)this.lapsCountUpDown.Value;
            double timescale = duration / count / laps;
            double firstNum = (double)this.firstObjectNumberUpDown.Value;
            string[] hexColor = Array.Empty<string>();
            Color[] theColors = this.chosenColor;
            int n = 0;

            if (this.stacked)
            {
                timescale = 0;
            }
            
            for (int c = 0; c < this.chosenColor.Length; c++)
            {
                Array.Resize(ref hexColor, hexColor.Length + 1);
                hexColor[c] = theColors[c].R.ToString("X2") + theColors[c].G.ToString("X2") + theColors[c].B.ToString("X2");
                
                if (this.objEv == "SetSunColors")
                {
                    hexColor[c] = $"{hexColor[c]},#{hexColor[c]}";
                }
            }

            string result = string.Empty;
            
            for (double u = time1; u <= duration + time1; u += duration / laps)
            {
                if (n == hexColor.Length)
                {
                    n = 0;
                }
                
                for (int i = (int)firstNum; i < count + firstNum; i++)
                {
                    result += 
                        $@"{{""time"":{u + timescale},""data"":[""{this.objEv}"",""{name + i},#{hexColor[n]}""]}},";
                    
                    timescale += timescale;
                }
                
                n++;
            }

            this.storyboardAssistantForm.resultTextBox.Text += result;
            
            this.Close();
        }

        private void CancelButtonClicked(object sender, EventArgs e) => this.Close();
    }
}
