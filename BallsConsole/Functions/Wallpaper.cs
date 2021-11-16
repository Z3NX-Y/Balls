using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BallsConsole.Functions
{
    public class Wallpaper
    {
        [DllImport("user32.dll")]

        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        static UInt32 SPI_SETWALL = 0x14;
        static UInt32 SPIF_UPDATE = 0x01;
        static UInt32 SPIF_SWEDWINI = 0x2;

        static string filePath = @"C:\Users\" + Environment.UserName + @"\Desktop\balls.jpg";

        public static void changeWallpaper()
        {
            SystemParametersInfo(SPI_SETWALL, 0, filePath, SPIF_UPDATE | SPIF_SWEDWINI);
        }
    }
}
