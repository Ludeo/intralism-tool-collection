using System;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    public partial class CubeForm : Form
    {
        public CubeForm()
        {
            this.InitializeComponent();
            ToolTip tp1 = new();
            ToolTip tp2 = new ();
            tp1.SetToolTip(this.Btn_Help, "It will be name of satellite to which the cube(all the suns) will be attached \n" +
                                          " all suns will have additional \"S\" in names like \"Sat, SatS0, SatS1 ...\"");
            tp2.SetToolTip(this.UpDn_TimeStart,"When will we spawn a cube?");
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void Cube_Load(object sender, EventArgs e) { }
    }
}
