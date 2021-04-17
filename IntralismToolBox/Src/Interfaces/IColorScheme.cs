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
        public Color ButtonBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the foreground color of a Button.
        /// </summary>
        public Color ButtonForegroundColor { get; }

        /// <summary>
        ///     Gets or sets the border color of a Button.
        /// </summary>
        public Color ButtonBorderColor { get; }

        /// <summary>
        ///     Gets or sets the background color of a TextBox.
        /// </summary>
        public Color TextBoxBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the foreground color of a TextBox.
        /// </summary>
        public Color TextBoxForegroundColor { get; }

        /// <summary>
        ///     Gets or sets the background color of a Form.
        /// </summary>
        public Color FormBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the foreground color of a Form.
        /// </summary>
        public Color FormForegroundColor { get; }

        /// <summary>
        ///     Gets or sets the background color of a GroupBox.
        /// </summary>
        public Color GroupBoxBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the foreground color of a GroupBox.
        /// </summary>
        public Color GroupBoxForegroundColor { get; }

        /// <summary>
        ///     Gets or sets the background color of a ListBox.
        /// </summary>
        public Color ListBoxBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the foreground color of a ListBox.
        /// </summary>
        public Color ListBoxForegroundColor { get; }

        /// <summary>
        ///     Gets or sets the background color of a DataGrid.
        /// </summary>
        public Color DataGridBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the foreground color of a DataGrid.
        /// </summary>
        public Color DataGridForegroundColor { get; }

        /// <summary>
        ///     Gets or sets the color of the grid from the DataGrid.
        /// </summary>
        public Color DataGridGridColor { get; }

        /// <summary>
        ///     Gets or sets the color of the cell from the DataGrid.
        /// </summary>
        public Color DataGridCellBackgroundColor { get; }

        /// <summary>
        ///     Gets or sets the color of the line from the graph.
        /// </summary>
        public Color GraphLineColor { get; }

        /// <summary>
        ///     Gets or sets the marker color fo the graph.
        /// </summary>
        public Color GraphMarkerColor { get; }

        /// <summary>
        ///     Gets or sets a value indicating whether the headers visual styles of the DataGrid should be enabled.
        /// </summary>
        public bool DataGridEnableHeadersVisualStyles { get; }
    }
}