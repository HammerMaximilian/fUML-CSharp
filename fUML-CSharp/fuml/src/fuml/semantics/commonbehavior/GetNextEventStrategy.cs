using fuml.semantics.loci;

namespace fuml.semantics.commonbehavior
{
    public abstract class GetNextEventStrategy : SemanticStrategy
    {
		public override string GetName()
		{
			// Get next event strategies are always named "getNextEvent".

			return "getNextEvent";
		} // getName

		public abstract EventOccurrence GetNextEvent(ObjectActivation objectActivation);
	} // GetNextEventStrategy
}
