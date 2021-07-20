using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;

namespace Lunar
{
    class Program
    {
        public static bool True { get; private set; }

        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Creates Folder for the .zip to go in
            Thread.Sleep(3000);
            string dir = @"C:\Lunar";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Main Console
            Console.Title = "Lunar Dev Downloader";
            Thread.Sleep(4000);
            Lunar.Log("Welcome to Lunar Dev Downloader!!!!");// The "Lunar.Log" can be replaced with any name but you will have to change the Lunar.cs File to your name
            Thread.Sleep(4000);
            Lunar.Log("If you have downloaded the dev on this please close this!!!!!!");
            Thread.Sleep(1000);
            Lunar.Log("The Dev Folder is in your C: Drive");
            
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Downloads the installer
            WebClient Client = new WebClient();
            Client.DownloadFile("https://cdn.discordapp.com/attachments/855182128438050829/866828070568198144/LunarDev.zip", @"C:\Lunar\Lunar.zip");
            Thread.Sleep(3000);
            Console.Title = "Downloading Files";
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Extracts the .zip
            ZipFile.ExtractToDirectory(@"C:\Lunar\Lunar.zip", @"C:\Lunar");    
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Shows Progress bar ( Do not Edit the ProgressBar.cs File!!!!!!!)
                Lunar.Log("Downloading Files");
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i <= 100; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(20);
                }
            }
            Thread.Sleep(5000);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Deletes the .zip
            String myPath = @"C:\Lunar\Lunar.zip";
            Lunar.Log("Downloaded Files");
            File.Delete(myPath);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Opens the Dev .exe
            Thread.Sleep(4000);
            Lunar.Log("Opening File");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Lets The User know to Close the .exe
            Thread.Sleep(5000);
            Process.Start("C:\\Lunar\\LunarDev\\LunarDev\\Lunar Launcher.exe");
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        }
    }
}
