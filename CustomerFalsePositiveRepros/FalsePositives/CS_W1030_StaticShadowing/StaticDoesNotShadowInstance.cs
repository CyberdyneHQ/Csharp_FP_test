namespace CustomerFalsePositiveRepros.FalsePositives.CS_W1030_StaticShadowing
{
    // Rule: CS-W1030 - Variable shadows field
    // False positive: Static method cannot shadow instance field.
    public class Logger
    {
        private string name;

        public Logger(string n)
        {
            this.name = n;
        }

        public void SetName(string n)
        {
            this.name = n; // non-constructor assignment prevents CS-R1137
        }

        public static void Init()
        {
            string name = "static"; // not shadowing instance field
            _ = name;
        }
    }
}
