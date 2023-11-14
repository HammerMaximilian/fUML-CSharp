﻿using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealGreaterThanEqualFunctionBehaviorExecution : RealRelationalFunctionBehaviorExecution
    {
        public override bool DoRealFunction(List<float> arguments)
        {

            float x1 = arguments.ElementAt(0);
            float x2 = arguments.ElementAt(1);

            bool b = x1 >= x2;

            Debug.Println("[doBody] Real Greater Than or Equal result = " + b);
            return b;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealGreaterThanEqualFunctionBehaviorExecution();
        }
    } // RealGreaterThanEqualFunctionBehaviorExecution
}