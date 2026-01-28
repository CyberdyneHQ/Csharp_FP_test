namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1093_EmptyVirtualMethods
{
    // Rule: CS-R1093 - Method is empty
    // False positive: Template method pattern. Base class provides empty hooks.
    public abstract class JobProcessor
    {
        public void Run()
        {
            BeforeRun();
            Execute();
            AfterRun();
        }

        protected virtual void BeforeRun() { }   // intentionally empty
        protected abstract void Execute();
        protected virtual void AfterRun() { }    // intentionally empty
    }
}
