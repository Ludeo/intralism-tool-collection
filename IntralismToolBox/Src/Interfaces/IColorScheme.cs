using System.Drawing;

namespace IntralismToolBox.Interfaces
{
    /// <summary>
    ///     Interface for ColorSchemes.
    /// </summary>
    public interface IColorScheme
    {
        /// <summary>
        ///     Gets or sets the background color of a Button.
        /// </summary>
        public Color ButtonBackgroundColor   { get; set; }

        /// <summary>
        ///     Gets or sets the foreground color of a Button.
        /// </summary>
        public Color ButtonForegroundColor   { get; set; }

        /// <summary>
        ///     Gets or sets the border color of a Button.
        /// </summary>
        public Color ButtonBorderColor       { get; set; }

        /// <summary>
        ///     Gets or sets the background color of a TextBox.
        /// </summary>
        public Color TextBoxBackgroundColor  { get; set; }

        /// <summary>
        ///     Gets or sets the foreground color of a TextBox.
        /// </summary>
        public Color TextBoxForegroundColor  { get; set; }

        /// <summary>
        ///     Gets or sets the background color of a Form.
        /// </summary>
        public Color FormBackgroundColor { get; set; }

        /// <summary>
        ///     Gets or sets the foreground color of a Form.
        /// </summary>
        public Color FormForegroundColor { get; set; }

        /// <summary>
        ///     Gets or sets the background color of a GroupBox.
        /// </summary>
        public Color GroupBoxBackgroundColor { get; set; }

        /// <summary>
        ///     Gets or sets the foreground color of a GroupBox.
        /// </summary>
        public Color GroupBoxForegroundColor { get; set; }

        /// <summary>
        ///     Gets or sets the background color of a ListBox.
        /// </summary>
        public Color ListBoxBackgroundColor  { get; set; }

        /// <summary>
        ///     Gets or sets the foreground color of a ListBox.
        /// </summary>
        public Color ListBoxForegroundColor  { get; set; }

        /// <summary>
        ///     Gets or sets the background color of a DataGrid.
        /// </summary>
        public Color DataGridBackgroundColor { get; set; }

        /// <summary>
        ///     Gets or sets the foreground color of a DataGrid.
        /// </summary>
        public Color DataGridForegroundColor { get; set; }

        /// <summary>
        ///     Gets or sets the color of the grid from the DataGrid.
        /// </summary>
        public Color DataGridGridColor { get; set; }

        /// <summary>
        ///     Gets or sets the color of the cell from the DataGrid.
        /// </summary>
        public Color DataGridCellBackgroundColor { get; set; }

        /// <summary>
        ///     Gets or sets if headers visual styles of the DataGrid should be enabled.
        /// </summary>
        public bool DataGridEnableHeadersVisualStyles { get; set; }
    }
}