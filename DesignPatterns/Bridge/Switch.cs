
namespace DesignPatterns.Bridge
{
    public class Switch : ISwitch
    {
        private IEquipment _equipment;
        public void SetEquipment(IEquipment equipment)
        {
            _equipment = equipment;
        }

        public void On()
        {
            _equipment.Start();
        }

        public void Off()
        {
            _equipment.Stop();
        }
    }
}
