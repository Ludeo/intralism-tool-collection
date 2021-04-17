using System.Drawing;
using IntralismToolBox.Interfaces;

namespace IntralismToolBox.ColorSchemes
{
    /// <summary>
    ///     Class that represents the light mode theme.
    /// </summary>
    public struct LightColorScheme : IColorScheme
    {
        /// <inheritdoc/>
        public Color ButtonBackgroundColor => Color.FromArgb(225, 225, 225);

        /// <inheritdoc/>
        public Color ButtonForegroundColor => Color.Black;

        /// <inheritdoc/>
        public Color ButtonBorderColor => Color.FromArgb(174, 174, 174);

        /// <inheritdoc/>
        public Color TextBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color TextBoxForegroundColor { get; set; }

        /// <inheritdoc/>
        public Color FormBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color FormForegroundColor => Color.Black;

        /// <inheritdoc/>
        public Color GroupBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color GroupBoxForegroundColor => Color.Black;

        /// <inheritdoc/>
        public Color ListBoxBackgroundColor => Color.White;

        /// <inheritdoc/>
        public Color ListBoxForegroundColor => Color.Black;

        /// <inheritdoc/>
        public Color DataGridBackgroundColor => Color.White;

        /// <inheritdoc/>
        public Color DataGridForegroundColor => Color.Black;

        /// <inheritdoc/>
        public Color DataGridGridColor => Color.Black;

        /// <inheritdoc/>
        public Color DataGridCellBackgroundColor => Color.White;

        /// <inheritdoc/>
        public Color GraphLineColor => Color.Aqua;

        /// <inheritdoc/>
        public Color GraphMarkerColor => Color.Red;

        /// <inheritdoc/>
        public bool DataGridEnableHeadersVisualStyles => true;
    }
}