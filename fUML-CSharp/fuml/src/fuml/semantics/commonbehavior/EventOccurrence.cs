using fuml.semantics.structuredclassifiers;
using uml.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public abstract class EventOccurrence
    {
		public Reference? target = null;

		public EventOccurrence()
        {
			behavior = new EventOccurrence_SendingBehaviorExecution(this);
		}

		public void SendTo(Reference target)
		{
			// Set the target reference and start the SendingBehavior, which
			// will send this event occurrence to the target.

			this.target = target;
			_startObjectBehavior();
		}

		public virtual void DoSend()
		{
			// Send this event occurrence to the target.

			target?.Send(this);
		}

		public abstract bool Match(Trigger trigger);

		public bool MatchAny(List<Trigger> triggers)
		{
			// Check that at least one of the given triggers is matched by this 
			// event occurrence.

			bool matches = false;
			int i = 1;
			while (!matches & i <= triggers.Count)
			{
				if (Match(triggers.ElementAt(i - 1)))
				{
					matches = true;
				}
				i++;
			}
			return matches;

		}

		public abstract List<ParameterValue> GetParameterValues(Event event_);


		private readonly EventOccurrence_SendingBehaviorExecution behavior;

		private void _startObjectBehavior()
		{
			behavior._startObjectBehavior();
		}
	} // EventOccurrence
}
