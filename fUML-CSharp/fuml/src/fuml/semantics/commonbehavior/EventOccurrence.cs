using fuml.semantics.structuredclassifiers;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public abstract class EventOccurrence : FumlObject
    {
		public Reference? target = null;

		public EventOccurrence()
        {
			behavior = new EventOccurrence_SendingBehaviorExecution(this);
		}

		public void sendTo(Reference target)
		{
			// Set the target reference and start the SendingBehavior, which
			// will send this event occurrence to the target.

			this.target = target;
			_startObjectBehavior();
		}

		public void doSend()
		{
			// Send this event occurrence to the target.

			target?.send(this);
		}

		public abstract bool match(Trigger trigger);

		public bool matchAny(List<Trigger> triggers)
		{
			// Check that at least one of the given triggers is matched by this 
			// event occurrence.

			bool matches = false;
			int i = 1;
			while (!matches & i <= triggers.Count)
			{
				if (match(triggers.ElementAt(i - 1)))
				{
					matches = true;
				}
				i++;
			}
			return matches;

		}

		public abstract List<ParameterValue> getParameterValues(Event event_);


		private readonly EventOccurrence_SendingBehaviorExecution behavior;

		private void _startObjectBehavior()
		{
			behavior._startObjectBehavior();
		}
	} // EventOccurrence
}
