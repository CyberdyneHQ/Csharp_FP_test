using System.Collections.Generic;

namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1123_DictionaryTryAddFrameworkMismatch
{
    // Rule: CS-R1123 - Suggest TryAdd
    // False positive: netstandard2.0 does not support Dictionary.TryAdd.
    public class DictionaryUsage
    {
        public void AddValue(Dictionary<string, int> dict, string key, int value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
        }
    }
}
