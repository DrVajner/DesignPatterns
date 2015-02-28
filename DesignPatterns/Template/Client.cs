using System;

namespace DesignPatterns.Template
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var fileParser = new FileParser();
            fileParser.Process();
            Console.WriteLine("-----------------------");
            var sqlServerParser = new SqlServerParser();
            sqlServerParser.Process();
        }
    }
}
