﻿using fuml.semantics.values;

namespace fuml.semantics.commonbehavior
{
    public class ObjectActivation_EventDispatchLoopExecution : Execution
    {
		public ObjectActivation self;

		public ObjectActivation_EventDispatchLoopExecution(ObjectActivation self)
		{
			this.self = self;
		}

		public int signalCount = 0;

		public void _startObjectBehavior()
		{
			// *** This should start the EventDispatchLoop ***

			context = self.object_;

		} // _startObjectBehavior

		public void _send(
                ArrivalSignal signal)
		{
			// Signal the arrival of a new signal instance in the event pool.
			// *** This should send an ArrivalSignal to the EventDispatchLoop. ***

			signalCount++;
			if (signalCount == 1)
			{
				ExecutionQueue.Enqueue(this);
			}
		} // _send
		public override void Execute()
		{
			self.DispatchNextEvent();
			signalCount--;
			if (signalCount > 0)
			{
				ExecutionQueue.Enqueue(this);
			}
		}

		protected override Value New_()
		{
			return new ObjectActivation_EventDispatchLoopExecution(self);
		}

		public override string ToString()
		{
			return "EventDispatchLoopExecution(" + self.object_ +")";
		}
	} // ObjectActivation_EventDispatchLoopExecution
}
