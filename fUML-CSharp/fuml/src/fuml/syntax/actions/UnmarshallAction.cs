using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class UnmarshallAction : Action
    {
		public InputPin? object_ = null;
		public List<OutputPin> result = new();
		public Classifier? unmarshallType = null;

		public void SetObject(InputPin object_)
		{
			AddInput(object_);
            this.object_ = object_;
		}

		public void AddResult(OutputPin result)
		{
			AddOutput(result);
			this.result.Add(result);
		}

		public void SetUnmarshallType(Classifier unmarshallType)
        {
			this.unmarshallType = unmarshallType ?? throw new ArgumentNullException(nameof(unmarshallType));
		}
	} // UnmarshallAction
}
