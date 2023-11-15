﻿using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealRoundFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public RealRoundFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            RealValue rv = (RealValue)inputParameters.ElementAt(0).values.ElementAt(0);
            float x = rv.value;
            Debug.Println("[doBody] argument = " + x);

            int resultInt = (int)Math.Round(x);

            IntegerValue result = new()
            {
                value = resultInt,
                type = locus?.factory?.GetBuiltInType("Integer")
            };

            Debug.Println("[doBody] Real Round result = " + result.value);

            outputParameters.ElementAt(0).values.Add(result);
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealRoundFunctionBehaviorExecution();
        }
    } // RealRoundFunctionBehaviorExecution
}
