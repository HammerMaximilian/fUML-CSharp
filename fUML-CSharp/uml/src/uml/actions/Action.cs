using uml.activities;
using uml.classification;

namespace uml.actions
{
    public abstract class Action : ExecutableNode
    {

        public List<OutputPin> output = new();
        public Classifier? context = null;
        public List<InputPin> input = new();
        public bool isLocallyReentrant = false;

        protected void AddInput(InputPin input)
        {
            AddOwnedElement(input);
            this.input.Add(input);
        } // addInput

        protected void AddOutput(OutputPin output)
        {
            AddOwnedElement(output);
            this.output.Add(output);
        } // addOutput

        public void SetIsLocallyReentrant(bool isLocallyReentrant)
        {
            this.isLocallyReentrant = isLocallyReentrant;
        } // setIsLocallyReentrant

        virtual public void _setContext(Classifier context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        } // _setContext

        public override void _setActivity(
                Activity activity)
        {
            base._setActivity(activity);
            _setContext(activity);
        } // _setActivity
    } // Action
}
