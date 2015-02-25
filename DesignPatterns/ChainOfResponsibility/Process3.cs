using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Process3 : IProcess
    {
        public override void RunProcess()
        {
            Console.WriteLine("Run process 3");
            if (Process != null)
            {
                Process.RunProcess();
            }
        }
    }
}
