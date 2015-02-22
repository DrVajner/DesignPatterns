
namespace DesignPatterns.Adapter
{
    class CollectionClassAdapter : DPStack // Using inheritence
    {
        public void Add(string str)
        {
            this.Push(str);
        }
    }
}
