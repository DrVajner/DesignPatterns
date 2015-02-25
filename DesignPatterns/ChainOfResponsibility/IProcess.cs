
namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class IProcess
    {
        protected IProcess Process;
        public void SetProcess(IProcess process)
        {
            Process = process;
        }
        public abstract void RunProcess();
    }
}
