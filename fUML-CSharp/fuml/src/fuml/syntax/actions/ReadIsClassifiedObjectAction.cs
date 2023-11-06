using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class ReadIsClassifiedObjectAction : Action
    {
		public bool isDirect = false;
		public Classifier? classifier = null;
		public OutputPin? result = null;
		public InputPin? object_ = null;

		public void SetIsDirect(bool isDirect)
		{
			this.isDirect = isDirect;
		} // setIsDirect

		public void SetClassifier(Classifier classifier)
		{
			this.classifier = classifier ?? throw new ArgumentNullException(nameof(classifier));
		} // setClassifier

		public void SetResult(OutputPin result)
		{
			AddOutput(result);
			this.result = result;
		} // setResult

		public void SetObject(InputPin object_)
		{
			AddInput(object_);
			this.object_ = object_;
		} // setObject
	} // ReadIsClassifiedObjectAction
}
