using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decryptor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ConsoleEngineBase engine = new Decryptor();
            engine.Main(args);
        }
    }

    class Decryptor : ConsoleEngineBase
    {
        protected override void ProcessLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
