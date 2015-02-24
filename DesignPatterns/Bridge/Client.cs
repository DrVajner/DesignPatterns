
namespace DesignPatterns.Bridge
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var bulb = new Bulb();
            var refrigerator = new Refrigerator();
            var equipmentSwitch = new Switch();

            equipmentSwitch.SetEquipment(bulb);
            equipmentSwitch.On();
            equipmentSwitch.Off();

            equipmentSwitch.SetEquipment(refrigerator);
            equipmentSwitch.On();
            equipmentSwitch.Off();
        }
    }
}
