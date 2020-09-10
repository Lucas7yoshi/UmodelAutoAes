using System.Net;
using System.Diagnostics;
using System;

namespace UmodelAutoAes
{
    class Program
    {
        const string aesurl = @"https://fnbot.shop/api/aes";
        static void Main(string[] args)
        {
            var wc = new WebClient();
            Console.WriteLine("Grabbing AES Key...");
            var aes = wc.DownloadString(aesurl).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
            var p = new Process();
            p.StartInfo.FileName = "umodel.exe";
            p.StartInfo.Arguments = $"-aes=0x{aes} {string.Join(" ", args)}";
            p.Start();
        }
    }
}
