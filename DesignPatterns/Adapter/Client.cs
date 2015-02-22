using System;

namespace DesignPatterns.Adapter
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var collection = new DPCollection();
            var stack = new DPStack();

            Console.WriteLine("Using object adapter:");
            var objectAdapter = new CollectionObjectAdapter();
            collection.Add("Some string");
            objectAdapter.Add("Some string");

            Console.WriteLine("Using class adapter:");
            var classAdapter = new CollectionClassAdapter();
            collection.Add("Another string");
            classAdapter.Add("Another string");
        }
    }
}
