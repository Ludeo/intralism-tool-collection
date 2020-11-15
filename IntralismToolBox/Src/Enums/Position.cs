using System;

namespace ManiaToIntralism.Enums
{
    /// <summary>
    /// enum of the arc positions in intralism
    /// </summary>
    [Flags]
    public enum Position
    {
        Left = 64,
        Up = 192,
        Down = 320,
        Right = 448,
    }
}