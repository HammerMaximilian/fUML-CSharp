﻿using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanXorFunctionBehaviorExecution : BooleanFunctionBehaviorExecution
    {
        public override bool DoBooleanFunction(List<bool> arguments)
        {
            bool result = arguments.ElementAt(0) ^ arguments.ElementAt(1);
            Debug.Println("[doBody] Boolean Xor result = " + result);
            return result;
        }

        public override Value New_()
        {
            return new BooleanXorFunctionBehaviorExecution();
        }
    } // BooleanXorFunctionBehaviorExecution
}
