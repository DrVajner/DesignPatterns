using System;

namespace DesignPatterns.Template
{
    public class FileParser : GeneralParser
    {
        protected override void Load()
        {
            Console.WriteLine("Load the data from the file");
        }

        protected override void Parse()
        {
            Console.WriteLine("Parse the file data");
        }
    }
}
