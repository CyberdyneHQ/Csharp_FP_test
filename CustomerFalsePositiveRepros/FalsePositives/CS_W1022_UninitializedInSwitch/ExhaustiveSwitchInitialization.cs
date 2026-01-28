//trigger
// DeepSource Rule: CS-W1022 - Variable is uninitialized
//
// The analyzer believes 'result' might be used without being assigned.
//
// Why this is a FALSE POSITIVE:
// In C#, an exhaustive switch that assigns in all branches guarantees
// the variable is initialized. Otherwise, the code would not compile.
// The compiler performs definite assignment analysis correctly.
// The analyzer fails to understand that all enum cases are covered.
//
// Root cause in analyzer:
// Incomplete control-flow analysis for exhaustive switch statements.

namespace CustomerFalsePositiveRepros.FalsePositives.CS_W1022_UninitializedInSwitch
{
    public enum OrderState
    {
        Created,
        Cancelled,
        Completed
    }

    public class SwitchAssignmentExample
    {
        public int MapStateToCode(OrderState state)
        {
            int result;

            switch (state)
            {
                case OrderState.Created:
                    result = 1;
                    break;

                case OrderState.Cancelled:
                    result = -1;
                    break;

                case OrderState.Completed:
                    result = 2;
                    break;

                default:
                    throw new System.InvalidOperationException();
            }

            // Compiler guarantees 'result' is assigned on all paths
            return result;
        }
    }
}

