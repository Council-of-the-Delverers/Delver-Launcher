using System;
using System.Diagnostics;

namespace Delver_Launcher {
    class Program {
        static string ArgList = null;
        static void Main(string[] args) {
            foreach (var arg in args) {
                ArgList = ArgList + arg + " ";
            }

            Console.WriteLine(ArgList);


            Process process = new Process();
            process.StartInfo.FileName = "java";
            process.StartInfo.Arguments = "-jar Delver.jar " + ArgList;

            process.Start();
        }
        

    }
}
