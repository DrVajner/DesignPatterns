
namespace DesignPatterns.ChainOfResponsibility
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var process1 = new Process1();
            var process2 = new Process2();
            var process3 = new Process3();

            process1.SetProcess(process2);
            process2.SetProcess(process3);

            process1.RunProcess();
        }
    }
}
