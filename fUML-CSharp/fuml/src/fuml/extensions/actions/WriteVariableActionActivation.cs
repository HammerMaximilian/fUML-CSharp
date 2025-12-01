using fuml.semantics.values;

namespace fuml.extensions.actions
{
    public abstract class WriteVariableActionActivation : VariableActionActivation
    {
        public int Position(Value value, List<Value> list, int startAt)
        {
            // Return the position (counting from 1) of the first occurance of the
            // given value in the given list at or after the starting index, or 0 if
            // it is not found.

            bool found = false;
            int i = startAt;
            while (!found & i <= list.Count())
            {
                found = list.ElementAt(i - 1).Equals(value);
                i = i + 1;
            }

            if (!found)
            {
                i = 1;
            }

            return i - 1;
        } // Position
    } // WriteVariableActionActivation
}
