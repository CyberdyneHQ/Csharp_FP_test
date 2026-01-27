namespace CustomerFalsePositiveRepros.FalsePositives.CS_R1019_RangeIndexLastElement
{
    // Rule: CS-R1019 - Suggest ^1 index
    // False positive: Range operators unsupported in netstandard2.0.
    public class ArrayAccess
    {
        public int GetLast(int[] arr)
        {
            return arr[arr.Length - 1];
        }
    }
}
//trigger 
