using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms
{
    public partial class AutoGradient : Form
    {
        public Color[] TwoColors = new Color[2];
        public string ObjEv;
        
        public AutoGradient() => this.InitializeComponent();
        
        private void label6_Click(object sender, EventArgs e) { }

        private void Btn_Choose1_Click(object sender, EventArgs e)
        {
            Bitmap map1 = new (this.Pb_Demo1.Width,this.Pb_Demo1.Height);
            Bitmap map2 = new (this.Pb_Demo2.Width, this.Pb_Demo2.Height);
            Graphics graph1 = Graphics.FromImage(map1);
            Graphics graph2 = Graphics.FromImage(map2);
            ColorDialog colorDialog = new ();
            
            for (int i = 0; i < 2; i++)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.TwoColors[i] = colorDialog.Color;
                }
            }
            
            graph1.Clear(this.TwoColors[0]);
            this.Pb_Demo1.Image = map1;
            graph2.Clear(this.TwoColors[1]);
            this.Pb_Demo2.Image = map2;
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
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

        private void Cmb_TypeList_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void AutoGradient_Load(object sender, EventArgs e) { }
    }
}
