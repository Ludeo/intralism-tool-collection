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
        /// <summary>
        ///     Array that saves two Colors that you picked in the colorDialog.
        /// </summary>
        public Color[] TwoColors = new Color[2];
        
        /// <summary>
        ///     Saves what kind of object got selected.
        /// </summary>
        public string ObjEv;
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="AutoGradientForm"/> class.
        /// </summary>
        public AutoGradientForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
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
                    this.TwoColors[i] = colorDialog.Color;
                }
            }
            
            graph1.Clear(this.TwoColors[0]);
            this.demo1PictureBox.Image = map1;
            graph2.Clear(this.TwoColors[1]);
            this.demo2PictureBox.Image = map2;
        }

        private void EnterButtonClicked(object sender, EventArgs e) =>
            this.ObjEv = this.objectTypeComboBox.SelectedIndex switch
            {
                0     => "SetSunColors",
                1     => "SetSatelliteColor",
                2     => "SetParticlesColor",
                var _ => "SetSunColors",
            };
    }
}
