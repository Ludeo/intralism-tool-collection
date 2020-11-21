using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace IntralismToolBox.WindowsFormsComponents
{
    /// <summary>
    ///     Class that represents a customized CheckBox, that looks like a toggle button.
    /// </summary>
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem")]
    [DesignerCategory("System.Windows.Forms")]
    public class ToggleCheckBox : CheckBox
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ToggleCheckBox"/> class.
        /// </summary>
        public ToggleCheckBox()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.Padding = new Padding(6);
        }

        /// <inheritdoc/>
        protected override void OnPaint(PaintEventArgs e)
        {
            this.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new ();

            int d = this.Padding.All;
            int r = this.Height - (2 * d);
            path.AddArc(d, d, r, r, 90, 180);
            path.AddArc(this.Width - r - d, d, r, r, -90, 180);
            path.CloseFigure();
            e.Graphics.FillPath(this.Checked ? Brushes.DarkGray : Brushes.LightGray, path);
            r = this.Height - 1;

            Rectangle rect = this.Checked
                ? new Rectangle(this.Width - r - 1, 0, r, r)
                : new Rectangle(0, 0, r, r);

            e.Graphics.FillEllipse(this.Checked ? Brushes.DodgerBlue : Brushes.WhiteSmoke, rect);
        }
    }
}