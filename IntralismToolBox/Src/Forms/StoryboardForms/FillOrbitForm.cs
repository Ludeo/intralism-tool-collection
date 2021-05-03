namespace IntralismToolBox.Forms.StoryboardForms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="StoryboardAssistantForm.fillOrbitButton"/> was pressed.
    /// </summary>
    public partial class FillOrbitForm : ThemedForm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FillOrbitForm"/> class.
        /// </summary>
        public FillOrbitForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
            this.sunNameToolTip.SetToolTip(this.sunNameTextBox,"If you write here \"Sun\", suns will be called like \"Sun0\", \"Sun1\", \"Sun2\"...");
            this.emissionUpDown.Increment = 0.5M;
        }
    }
}
