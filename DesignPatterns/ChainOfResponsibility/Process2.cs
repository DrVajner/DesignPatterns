using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Process2 : IProcess
    {
        public override void RunProcess()
        {
            Console.WriteLine("Run process 2");
            if (Process != null)
            {
                Process.RunProcess();
            }
        }
    }
}
