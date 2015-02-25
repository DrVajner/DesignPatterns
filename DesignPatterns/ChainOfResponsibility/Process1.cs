using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Process1 : IProcess
    {
        public override void RunProcess()
        {
            Console.WriteLine("Run process 1");
            if (Process != null)
            {
                Process.RunProcess();
            }
        }
    }
}
