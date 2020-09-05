using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder {
     class Part3 {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        internal static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        internal static Color[] colorMapMinor;
        /// <summary>
        /// data type defined to hold the two colors of clor pair
        /// </summary>
        internal class ColorPair
        {
            internal Color majorColor;
            internal Color minorColor;
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
        }
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static Part3 ()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

    }
}

