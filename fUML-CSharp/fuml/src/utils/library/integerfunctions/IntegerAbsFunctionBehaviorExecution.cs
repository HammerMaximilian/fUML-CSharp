﻿using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerAbsFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerAbsFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {

            int arg1 = arguments.ElementAt(0);

            // Compute the absolute value function.
            int i = Math.Abs(arg1);
            Debug.Println("[doBody] Integer Abs result = " + i);
            return i;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerAbsFunctionBehaviorExecution();
        }
    } // IntegerAbsFunctionBehaviorExecution
}
