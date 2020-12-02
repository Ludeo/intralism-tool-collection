using System.Drawing;
using IntralismToolBox.Interfaces;

namespace IntralismToolBox.ColorSchemes
{
    /// <summary>
    ///     Class that represents the light mode theme.
    /// </summary>
    public class LightColorScheme : IColorScheme
    {
        /// <inheritdoc/>
        public Color ButtonBackgroundColor { get; set; } = Color.FromArgb(225, 225, 225);

        /// <inheritdoc/>
        public Color ButtonForegroundColor { get; set; } = Color.Black;

        /// <inheritdoc/>
        public Color ButtonBorderColor { get; set; } = Color.FromArgb(174, 174, 174);

        /// <inheritdoc/>
        public Color TextBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color TextBoxForegroundColor { get; set; }

        /// <inheritdoc/>
        public Color FormBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color FormForegroundColor { get; set; } = Color.Black;

        /// <inheritdoc/>
        public Color GroupBoxBackgroundColor { get; set; }

        /// <inheritdoc/>
        public Color GroupBoxForegroundColor { get; set; } = Color.Black;

        /// <inheritdoc/>
        public Color ListBoxBackgroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color ListBoxForegroundColor { get; set; } = Color.Black;

        /// <inheritdoc/>
        public Color DataGridBackgroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color DataGridForegroundColor { get; set; } = Color.Black;

        /// <inheritdoc/>
        public Color DataGridGridColor { get; set; } = Color.Black;

        /// <inheritdoc/>
        public Color DataGridCellBackgroundColor { get; set; } = Color.White;

        /// <inheritdoc/>
        public Color GraphLineColor { get; set; } = Color.Aqua;

        /// <inheritdoc/>
        public Color GraphMarkerColor { get; set; } = Color.Red;

        /// <inheritdoc/>
        public bool DataGridEnableHeadersVisualStyles { get; set; } = true;
    }
}