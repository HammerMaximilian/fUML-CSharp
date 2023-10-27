using fuml.syntax.activities;
using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public abstract class Action : ExecutableNode
    {

        public List<OutputPin> output = new();
        public Classifier? context = null;
        public List<InputPin> input = new();
        public bool isLocallyReentrant = false;

        protected void addInput(InputPin input)
        {
            base.addOwnedElement(input);
            this.input.Add(input);
        } // addInput

        protected void addOutput(OutputPin output)
        {
            base.addOwnedElement(output);
            this.output.Add(output);
        } // addOutput

        public void setIsLocallyReentrant(bool isLocallyReentrant)
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
