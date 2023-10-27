using fuml.semantics.values;

namespace fuml.semantics.commonbehavior
{
    public class EventOccurrence_SendingBehaviorExecution : Execution
    {
		public EventOccurrence self;

		public EventOccurrence_SendingBehaviorExecution(EventOccurrence self)
		{
			this.self = self;
		}

		public void _startObjectBehavior()
		{
			context = self.target?.referent;
			ExecutionQueue.Enqueue(this);
		}

		public override void Execute()
		{
			self.DoSend();
		}
							
		public override Value New_()
		{
			return new EventOccurrence_SendingBehaviorExecution(self);
		}

		public override string ToString()
		{
			return "SendingBehaviorExecution(" + self + ")";
		}
	} // EventOccurrence_SendingBehaviorExecution
}
