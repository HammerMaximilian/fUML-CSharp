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
			ExecutionQueue.enqueue(this);
		}

		public override void execute()
		{
			self.doSend();
		}
							
		public override Value new_()
		{
			return new EventOccurrence_SendingBehaviorExecution(self);
		}

		public override string toString()
		{
			return "SendingBehaviorExecution(" + self + ")";
		}
	} // EventOccurrence_SendingBehaviorExecution
}
