using System;
using Spike.CSharp.Library;

namespace Spike.CSharp.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            long add = SpikeLibrary.Add(12, 99);
            double cosine = SpikeLibrary.Cosine(1);
            string msg = "Hello from C#!";
            GoString str = new GoString(msg, msg.Length);

            Console.WriteLine("awesome.Add(12,99) = " + add);
            Console.WriteLine("awesome.Cosine(1) = " + cosine);
        }
    }
}