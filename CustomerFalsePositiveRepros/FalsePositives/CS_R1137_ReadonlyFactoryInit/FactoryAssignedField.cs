namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1137_ReadonlyFactoryInit
{
    // Rule: CS-R1137 - Field should be readonly
    // False positive: Field is mutated by static factory after construction.
    public class Config
    {
        public bool ShouldSave;

        private Config() { }

        public static Config LoadOrDefault()
        {
            var c = new Config();
            c.ShouldSave = true; // assigned post-construction
            return c;
        }
    }
}
