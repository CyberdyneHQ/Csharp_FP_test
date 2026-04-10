namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1000_CustomBooleanAlias
{
    // Rule: CS-R1000 - Suggest bool over Boolean
    // False positive: Boolean is user-defined, not System.Boolean.
    public class Boolean
    {
        public Boolean(bool v) { }
    }

    internal class Usage
    {
        public void Create()
        {
            _ = new Boolean(false);
        }
    }
}
