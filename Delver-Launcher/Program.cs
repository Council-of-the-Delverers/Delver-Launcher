using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Delver_Launcher
{
    static class Program
    {

        public static string ArgList = null;
        public static string CONFIG_FILE = "Delver-Launcher.config";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (var arg in args) {
                ArgList = ArgList + arg + " ";
            }

            if (File.Exists(CONFIG_FILE)) {
                using (Process process = new Process()) {
                    process.StartInfo.FileName = "java";
                    process.StartInfo.Arguments = "-jar " + File.ReadAllText(CONFIG_FILE).Trim() + ".jar";
                   
                    if (ArgList != null) {
                        process.StartInfo.Arguments += " " + ArgList;
                    }

                    try {
                        process.Start();
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(1);
                    }
                    
                }

                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectForm());
        }
    }
}
