namespace pssm.semantics.statemachines
{
    public abstract class ConnectionPointActivation : PseudostateActivation
    {
        public override VertexActivation GetParentVertexActivation()
        {
            throw new NotImplementedException();
        }

        public override RegionActivation GetOwningRegionActivation()
        {
            throw new NotImplementedException();
        }

    } // ConnectionPointActivation
}
