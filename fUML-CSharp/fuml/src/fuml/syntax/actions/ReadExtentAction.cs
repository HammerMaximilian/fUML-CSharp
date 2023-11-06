using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class ReadExtentAction: Action
    {
		public OutputPin? result = null;
		public Classifier? classifier = null;

		public void SetClassifier(Classifier classifier)
		{
			this.classifier = classifier ?? throw new ArgumentNullException(nameof(classifier));
		} // setClassifier

		public void SetResult(OutputPin result)
		{
			AddOutput(result);
			this.result = result;
		} // setResult
	} // ReadExtentAction
}
