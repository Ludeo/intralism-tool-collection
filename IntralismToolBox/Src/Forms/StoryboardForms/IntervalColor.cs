using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms
{
    public partial class IntervalColor : Form
    {
        public Color[] ChosenColor;
        public string ObjEv;
        public bool Stacked;
        
        public IntervalColor()
        {
            this.InitializeComponent();
            this.ChosenColor = new Color[0];
            this.Stacked = false;
            ToolTip tip1 = new ();
            tip1.SetToolTip(this.Chb_Stack,"All your objects are changing color at the same time or one after another");
        }
        
        private void GradientColor_Load(object sender, EventArgs e) { }

        private void Btn_Choose1_Click(object sender, EventArgs e)
        {
            Bitmap map = new (this.Pb_Demo.Width, this.Pb_Demo.Height);
            Graphics graph = Graphics.FromImage(map);
            for (int g = 0; g < this.UpDn_ColCount.Value; g++)
            {
                ColorDialog colorDialog = new ();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {

                    Array.Resize(ref this.ChosenColor, this.ChosenColor.Length + 1);
                    this.ChosenColor[g] = colorDialog.Color;
                    graph.Clear(this.ChosenColor[g]);
                    this.Pb_Demo.Image = map;
                }
            }

            switch (this.Cmb_TypeList.SelectedIndex)
            {
                case 0:
                    {
                        this.ObjEv = "SetSunColors";
                        break;
                    }
                case 1:
                    {
                        this.ObjEv = "SetSatelliteColor";
                        break;
                    }
                case 2:
                    {
                        this.ObjEv = "SetParticlesColor";
                        break;
                    }
                default:
                    {
                        this.ObjEv = "SetSunColors";
                        break;
                    }
            }
        }

        private void UpDn_CycCount_ValueChanged(object sender, EventArgs e) { }

        private void Cmb_Stack_CheckedChanged(object sender, EventArgs e) => this.Stacked = this.Chb_Stack.Checked;
    }
}
