using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
     partial class Program
    {
         public override void ToString()
        {
            string str = "";
            for (int i = 1; i <= 25; i++) {
                str = str + string.Format("PairNumber: {0}, {1}\n", i, Program.GetColorFromPairNumber(i).ToString());
            }
            Console.WriteLine(str);
        }
    }
}
