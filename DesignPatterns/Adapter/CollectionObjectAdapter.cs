
namespace DesignPatterns.Adapter
{
    class CollectionObjectAdapter : DPCollection // Using aggregation
    {
        private DPStack _stack = new DPStack();

        public override void Add(string str)
        {
            _stack.Push(str);
        }
    }
}
