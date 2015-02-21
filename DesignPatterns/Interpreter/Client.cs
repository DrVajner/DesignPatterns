using System;

namespace DesignPatterns.Interpreter
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var text = "START";

            while (!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Enter date format (or press enter to finish):");
                text = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(text))
                {
                    text = Interpreter.InterpretDate(text);
                    Console.WriteLine("Result: {0}", text);
                }
            }
        }
    }
}
