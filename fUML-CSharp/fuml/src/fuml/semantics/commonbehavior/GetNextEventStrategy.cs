﻿using fuml.semantics.loci;

namespace fuml.semantics.commonbehavior
{
    public abstract class GetNextEventStrategy : SemanticStrategy
    {
		public override string getName()
		{
			// Get next event strategies are always named "getNextEvent".

			return "getNextEvent";
		} // getName

		public abstract EventOccurrence getNextEvent(ObjectActivation objectActivation);
	} // GetNextEventStrategy
}