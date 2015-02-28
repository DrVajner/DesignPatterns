using System;

namespace DesignPatterns.Template
{
    public class SqlServerParser : GeneralParser
    {
        protected override void Load()
        {
            Console.WriteLine("Connect to SQL Server");
        }

        protected override void Parse()
        {
            Console.WriteLine("Loop through data set");
        }
    }
}
