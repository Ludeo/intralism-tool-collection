using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="GeometryForm.cubeButton"/> was pressed.
    /// </summary>
    public partial class CubeForm : ThemedForm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CubeForm"/> class.
        /// </summary>
        public CubeForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
            ToolTip helpButtonToolTip = new();
            helpButtonToolTip.SetToolTip(this.helpButton, "It will be name of satellite to which the cube(all the suns) will be attached \n" +
                                                          " all suns will have additional \"S\" in names like \"Sat, SatS0, SatS1 ...\"");
            
            ToolTip timeStartUpDownToolTip = new();
            timeStartUpDownToolTip.SetToolTip(this.timeStartUpDown,"When will we spawn a cube?");
        }
    }
}
