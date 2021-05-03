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
        /// <summary>
        ///     An Array of Colors that saves the colors that got chosen through the colorDialog.
        /// </summary>
        public Color[] ChosenColor;
        
        /// <summary>
        ///     Saves what kind of object got selected.
        /// </summary>
        public string ObjEv;
        
        /// <summary>
        ///     Saves if the user selected stackedEvents or not.
        /// </summary>
        public bool Stacked;
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="IntervalColorForm"/> class.
        /// </summary>
        public IntervalColorForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
            this.ChosenColor = Array.Empty<Color>();
            this.Stacked = false;
            ToolTip tip1 = new();
            tip1.SetToolTip(this.stackedCheckBox,"All your objects are changing color at the same time or one after another");
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
                    Array.Resize(ref this.ChosenColor, this.ChosenColor.Length + 1);
                    this.ChosenColor[g] = colorDialog.Color;
                    graph.Clear(this.ChosenColor[g]);
                    this.demoPictureBox.Image = map;
                }
            }

            this.ObjEv = this.objectTypeComboBox.SelectedIndex switch
            {
                0 => "SetSunColors",
                1 => "SetSatelliteColor",
                2 => "SetParticlesColor",
                var _ => "SetSunColors",
            };
        }

        private void StackedCheckBoxChanged(object sender, EventArgs e) => this.Stacked = this.stackedCheckBox.Checked;
    }
}
