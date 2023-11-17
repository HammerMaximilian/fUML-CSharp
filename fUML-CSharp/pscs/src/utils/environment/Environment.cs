using fuml;
using pscs.semantics.actions;
using pscs.semantics.loci;
using pscs.semantics.structuredclassifiers;

namespace pscs.environment
{
    public abstract class Environment : fuml.environment.Environment
    {
        protected override void InitializeLoci()
        {
            locus = new CS_Locus();
            locus.SetExecutor(new CS_Executor());
            locus.SetFactory(new CS_ExecutionFactory());
        }

        protected override void InitializeLociContents()
        {
            base.InitializeLociContents();

            if (locus is null)
            {
                Debug.Println("[error] Locus is not set for execution environment");
                throw new NullReferenceException();
            }

            locus.factory?.SetStrategy(new CS_DefaultConstructStrategy());
            locus.factory?.SetStrategy(new CS_DefaultRequestPropagationStrategy());
            locus.factory?.SetStrategy(new CS_DispatchOperationOfInterfaceStrategy());
            locus.factory?.SetStrategy(new CS_NameBased_StructuralFeatureOfInterfaceAccessStrategy());
        }
    }
}
