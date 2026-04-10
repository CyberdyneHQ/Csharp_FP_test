namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1137_ReadonlyFactoryInit
{
    // Rule: CS-R1137 - Field should be readonly
    // False positive: Field is mutated by static factory after construction.
    public class Config
    {
        private bool shouldSave;

        private Config() { }

        public static Config LoadOrDefault()
        {
            var c = new Config();
            SetDefaults(c);
            return c;
        }

        private static void SetDefaults(Config c)
        {
            c.shouldSave = true; // assigned post-construction, not in constructor
        }
    }
}
