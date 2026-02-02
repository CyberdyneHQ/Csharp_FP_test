namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1000_CustomBooleanAlias
{
    // Rule: CS-R1000 - Suggest bool over Boolean
    // False positive: Boolean is user-defined, not System.Boolean.
    public class Boolean
    {
        public Boolean(bool v) { }
    }

    public class Usage
    {
        public void Create()
        {
            var b = new Boolean(false);
        }
    }
}
