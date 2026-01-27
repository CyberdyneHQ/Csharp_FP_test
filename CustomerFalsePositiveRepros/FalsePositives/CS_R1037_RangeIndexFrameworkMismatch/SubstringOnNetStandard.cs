//trigger fp
namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1037_RangeIndexFrameworkMismatch
{
    // Rule: CS-R1037 - Suggest range operator
    // False positive: C# 8 range not available in netstandard2.0.
    public class StringUtils
    {
        public string GetPrefix(string s)
        {
            return s.Substring(0, 3);
        }
    }
}
