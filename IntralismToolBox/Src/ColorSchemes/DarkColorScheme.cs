using System.Drawing;
using IntralismToolBox.Interfaces;

namespace IntralismToolBox.ColorSchemes
{
    /// <summary>
    ///     Class that represents the dark mode theme.
    /// </summary>
    public class DarkColorScheme : IColorScheme
    {
        /// <inheritdoc/>
        public Color ButtonBackgroundColor { get; set; } = Color.FromArgb(41, 41, 41);

        /// <inheritdoc/>
        public Color ButtonForegroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color ButtonBorderColor { get; set; }

        /// <inheritdoc/>
        public Color TextBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color TextBoxForegroundColor { get; set; }

        /// <inheritdoc/>
        public Color FormBackgroundColor { get; set; } = Color.FromArgb(47, 49, 52);

        /// <inheritdoc/>
        public Color FormForegroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color GroupBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color GroupBoxForegroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color ListBoxBackgroundColor { get; set; } = Color.FromArgb(47, 49, 52);

        /// <inheritdoc/>
        public Color ListBoxForegroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color DataGridBackgroundColor { get; set; } = Color.FromArgb(41, 41, 41);

        /// <inheritdoc/>
        public Color DataGridForegroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color DataGridGridColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color DataGridCellBackgroundColor { get; set; } = Color.FromArgb(47, 49, 52);

        /// <inheritdoc/>
        public Color GraphLineColor { get; set; } = Color.Aqua;

        /// <inheritdoc/>
        public Color GraphMarkerColor { get; set; } = Color.Red;

        /// <inheritdoc/>
        public bool DataGridEnableHeadersVisualStyles { get; set; } = false;
    }
}