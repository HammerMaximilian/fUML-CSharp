using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class ReadIsClassifiedObjectAction : Action
    {
		public bool isDirect = false;
		public Classifier? classifier = null;
		public OutputPin? result = null;
		public InputPin? object_ = null;

		public void setIsDirect(bool isDirect)
		{
			this.isDirect = isDirect;
		} // setIsDirect

		public void setClassifier(Classifier classifier)
		{
			this.classifier = classifier ?? throw new ArgumentNullException(nameof(classifier));
		} // setClassifier

		public void setResult(OutputPin result)
		{
			AddOutput(result);
			this.result = result;
		} // setResult

		public void setObject(InputPin object_)
		{
			AddInput(object_);
			this.object_ = object_;
		} // setObject
	} // ReadIsClassifiedObjectAction
}
