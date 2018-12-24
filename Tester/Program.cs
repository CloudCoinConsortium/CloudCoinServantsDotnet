﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CloudCoinServants;
using CloudCoin_ShowCoins;
using FolderManager;

namespace Tester
{
    class Program
    {
        public static string BasePath = System.IO.Directory.GetCurrentDirectory();
        public static string RootPath = "";
        public static String TAG_LOGS = "Logs";
        public static String TAG_RECEIPTS = "Receipts";
        public static String URL_DIRECTORY = "";
        public static String TAG_COMMAND = "Command";
        public static String TAG_ECHOER = "Echoer";

        static void Main(string[] args)
        {
            String CommandFolder = BasePath + Path.DirectorySeparatorChar + TAG_COMMAND;
            String EchoerLogsFolder = BasePath + Path.DirectorySeparatorChar + TAG_LOGS + Path.DirectorySeparatorChar + TAG_ECHOER;
            String ShowCoinsLogsFolder = BasePath + Path.DirectorySeparatorChar + TAG_LOGS + Path.DirectorySeparatorChar + Config.TAG_SHOWCOINS;

            Console.WriteLine(CommandFolder);
            Console.WriteLine(EchoerLogsFolder);

            Directory.CreateDirectory(CommandFolder);
            Directory.CreateDirectory(EchoerLogsFolder);

            FolderManager.FolderManager.CreateDirectories();

            //Console.Write("Created Directories. Press enter to exit");
            // Echoer echoer = new Echoer(CommandFolder);
            //echoer.
            ShowCoins showCoins = new ShowCoins(CommandFolder);
            showCoins.showCoins();
            Console.WriteLine("Watching folder " + CommandFolder + ".\nLogs folder- "+ FolderManager.FolderManager.ShowCoinsLogsFolder + "\n.Bank Folder location- "+ FolderManager.FolderManager.BankFolder);
            Console.ReadLine();


            
        }
    }
}
