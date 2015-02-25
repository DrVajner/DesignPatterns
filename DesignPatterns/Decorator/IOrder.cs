
namespace DesignPatterns.Decorator
{
    public interface IOrder
    {
        string Prepare();
        double CalculateCost();
    }
}
