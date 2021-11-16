using System;
using System.IO;
using System.Net;
using BallsConsole.Functions;

namespace BallsConsole
{
    class Program
    {

        static void Main(string[] args)
        {

            string desktop = @"C:\Users\" + Environment.UserName + @"\Desktop\";
            string localFilename = @"C:\Users\" + Environment.UserName + @"\Desktop\balls.jpg";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://i.redd.it/41ps5f0pnt771.png", localFilename);
                }
                for (int i = 0; i < 10; i++)
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
