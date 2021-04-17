using System.Drawing;
using IntralismToolBox.Interfaces;

namespace IntralismToolBox.ColorSchemes
{
    /// <summary>
    ///     Class that represents the dark mode theme.
    /// </summary>
    public struct DarkColorScheme : IColorScheme
    {
        /// <inheritdoc/>
        public Color ButtonBackgroundColor => Color.FromArgb(41, 41, 41);

        /// <inheritdoc/>
        public Color ButtonForegroundColor => Color.White;

        /// <inheritdoc/>
        public Color ButtonBorderColor { get; set; }

        /// <inheritdoc/>
        public Color TextBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color TextBoxForegroundColor { get; set; }

        /// <inheritdoc/>
        public Color FormBackgroundColor => Color.FromArgb(47, 49, 52);

        /// <inheritdoc/>
        public Color FormForegroundColor => Color.White;

        /// <inheritdoc/>
        public Color GroupBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color GroupBoxForegroundColor => Color.White;

        /// <inheritdoc/>
        public Color ListBoxBackgroundColor => Color.FromArgb(47, 49, 52);

        /// <inheritdoc/>
        public Color ListBoxForegroundColor => Color.White;

        /// <inheritdoc/>
        public Color DataGridBackgroundColor => Color.FromArgb(41, 41, 41);

        /// <inheritdoc/>
        public Color DataGridForegroundColor => Color.White;

        /// <inheritdoc/>
        public Color DataGridGridColor => Color.White;

        /// <inheritdoc/>
        public Color DataGridCellBackgroundColor => Color.FromArgb(47, 49, 52);

        /// <inheritdoc/>
        public Color GraphLineColor => Color.Aqua;

        /// <inheritdoc/>
        public Color GraphMarkerColor => Color.Red;

        /// <inheritdoc/>
        public bool DataGridEnableHeadersVisualStyles => false;
    }
}