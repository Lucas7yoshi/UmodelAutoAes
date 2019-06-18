using System.Net;
using System.Diagnostics;
using System;

namespace UmodelAutoAes
{
    class Program
    {
        const string aesurl = @"https://lucas7yoshi.github.io/aes.txt";
        static void Main(string[] args)
        {
            var wc = new WebClient();
            Console.WriteLine("Grabbing AES Key...");
            var aes = wc.DownloadString(aesurl);
            Process.Start($"umodel.exe", string.Join(" ", args) + " -aes=" + aes);
        }
    }
}
