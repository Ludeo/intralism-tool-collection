using System;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    public partial class GeometryForm : Form
    {
        public GeometryForm()
        {
            this.InitializeComponent();
            ToolTip tp1 = new ();
            tp1.SetToolTip(this.Btn_Help, "That's something like buffer to contain figures only \n" +
                                          " so if you mess up with the figures you will not mess up all the text in the Mainform");
        }

        private void Btn_Cube_Click(object sender, EventArgs e)
        {
            CubeForm cubeForm = new ();
            if (cubeForm.ShowDialog() == DialogResult.OK)
            {
                string result = this.Txt_Result.Text;
                double sideL = (double)cubeForm.UpDn_SideLength.Value;
                double sidePos = sideL / 2;
                double time = (double)cubeForm.UpDn_TimeStart.Value;
                string sunName = cubeForm.Txt_ObjName.Text + "S";
                
                // spawning satellite
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{cubeForm.Txt_ObjName.Text}\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{cubeForm.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{cubeForm.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRotationSpeed\",\"{cubeForm.Txt_ObjName.Text},0\"]}},";
                // spawning suns
                for (int i = (int)cubeForm.UpDn_FirstNum.Value; i < 12 + cubeForm.UpDn_FirstNum.Value; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + i}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{sunName + i},{cubeForm.Txt_ObjName.Text}\"]}},";
                    result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMaxSize\",\"{sunName + i},{sideL},{cubeForm.UpDn_SideWidth.Value}," +
                              $"{cubeForm.UpDn_SideWidth.Value}\"]}},";
                    result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMinSize\",\"{sunName + i},{sideL},{cubeForm.UpDn_SideWidth.Value}," +
                              $"{cubeForm.UpDn_SideWidth.Value}\"]}},";
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
                this.Txt_Result.Text += result;
            }
        }
    }
}
