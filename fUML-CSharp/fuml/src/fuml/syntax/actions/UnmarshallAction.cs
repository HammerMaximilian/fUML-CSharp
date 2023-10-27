using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class UnmarshallAction : Action
    {
		public InputPin? object_ = null;
		public List<OutputPin> result = new();
		public Classifier? unmarshallType = null;

		public void setObject(InputPin object_)
		{
			AddInput(object_);
            this.object_ = object_;
		}

		public void addResult(OutputPin result)
		{
			AddOutput(result);
			this.result.Add(result);
		}

		public void setUnmarshallType(Classifier unmarshallType)
        {
			this.unmarshallType = unmarshallType ?? throw new ArgumentNullException(nameof(unmarshallType));
		}
	} // UnmarshallAction
}
