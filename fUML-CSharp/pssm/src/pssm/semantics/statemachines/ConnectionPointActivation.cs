namespace pssm.semantics.statemachines
{
    public abstract class ConnectionPointActivation : PseudostateActivation
    {
        public override VertexActivation GetParentVertexActivation()
        {
            // The parent state of a connection point reference is its owning state
            VertexActivation? vertexActivation = null;
            if (parent is not null)
            {
                vertexActivation = (VertexActivation)parent;
            }
            return vertexActivation!;
        }

        public override RegionActivation GetOwningRegionActivation()
        {
            // Return the owning region activation of the state activation
            // on which this point activation is placed.
            RegionActivation? regionActivation = null;
            if (GetParentVertexActivation() is not null)
            {
                regionActivation = (RegionActivation)GetParentVertexActivation()?.parent!;
            }
            return regionActivation!;
        }

    } // ConnectionPointActivation
}
