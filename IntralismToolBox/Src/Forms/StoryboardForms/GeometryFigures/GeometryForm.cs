using System;
using System.Windows.Forms;

namespace IntralismToolBox.Forms.StoryboardForms.GeometryFigures
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="StoryboardAssistantForm.geometricFiguresButton"/> was pressed.
    /// </summary>
    public partial class GeometryForm : ThemedForm
    {
        private readonly StoryboardAssistantForm storyboardAssistantForm;
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="GeometryForm"/> class.
        /// </summary>
        public GeometryForm(StoryboardAssistantForm storyboardAssistantForm)
        {
            this.InitializeComponent();
            this.ReloadTheme();
            ToolTip helpButtonToolTip = new();
            helpButtonToolTip.SetToolTip(this.helpButton, "That's something like buffer to contain figures only \n" +
                                          " so if you mess up with the figures you will not mess up all the text in the Mainform");

            this.storyboardAssistantForm = storyboardAssistantForm;
        }

        private void CubeButtonClicked(object sender, EventArgs e)
        {
            CubeForm cubeForm = new(this);
            cubeForm.Show();
        }

        private void EnterButtonClicked(object sender, EventArgs e)
        {
            this.storyboardAssistantForm.resultTextBox.Text += this.resultTextBox.Text;
            this.Close();
        }

        private void CancelButtonClicked(object sender, EventArgs e) => this.Close();
    }
}
