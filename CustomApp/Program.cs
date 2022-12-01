using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace CustomApp
{
    internal class Program
    {
        private Process _cmdProcess;
        private StreamWriter _streamWriter;
        private AutoResetEvent _outputWaitHandle;
        private string _cmdOutput;

        
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Device Infected");
            Console.WriteLine($"/C runas /netonly /user:{Environment.MachineName}\\{Environment.UserName}");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.WriteLine("WARNING");
            Console.ReadKey();
            Console.Clear();
            Process.Start("cmd.exe", $"/C start chrome.exe --autoplay-policy=no-user-gesture-required https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            //Process cmd = new Process();
            //cmd.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            //cmd.Start();
            //Process myProcess = new Process();
            //myProcess.StartInfo.UseShellExecute = true;
            //string webaddress = "https://youtube.com/";
            //myProcess.StartInfo.FileName = webaddress;
            //myProcess.Start();
            
            



        }


    }
}
