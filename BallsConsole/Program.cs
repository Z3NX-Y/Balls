using System;
using System.IO;
using System.Net;
using BallsConsole.Functions;
using System.Globalization;

namespace BallsConsole
{
    class Program
    {

        public static void Main(string[] args)
        {

            string desktop = @"C:\Users\" + Environment.UserName + @"\Desktop\";
            string localFilename = @"C:\Users\" + Environment.UserName + @"\Desktop\balls.jpg";
            string logPath = @"C:\Users\" + Environment.UserName + @"\Documents\Balls\ballsLog.txt";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://i.redd.it/41ps5f0pnt771.png", localFilename);
                }
                for (int i = 0; i < 10000; i++)
                {
                    string num = desktop + i.ToString() + ".jpg";
                    File.Copy(localFilename, num);

                    Console.WriteLine("Ball " + num);
                }

                

            }

            catch
            {
                
            }

            Wallpaper.changeWallpaper();
            
        }
    }

}
