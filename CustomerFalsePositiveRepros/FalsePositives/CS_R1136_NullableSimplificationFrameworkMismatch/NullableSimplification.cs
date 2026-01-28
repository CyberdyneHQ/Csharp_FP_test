//trigger
namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1136_NullableSimplificationFrameworkMismatch
{
    // Rule: CS-R1136 - Nullable expression can be simplified
    // False positive: Target framework does not support suggested syntax.
    public class NullableCheck
    {
        public bool IsTrue(bool? value)
        {
            return value.HasValue && value.Value;
        }
    }
}
