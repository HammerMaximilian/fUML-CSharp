using fuml.syntax.activities;
using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class StructuredActivityNode : Action
    {
        public List<ActivityNode> node = new();
        public new Activity? activity = null;
        public bool mustIsolate = false;
        public List<ActivityEdge> edge = new();
        public List<OutputPin> structuredNodeOutput = new();
        public List<InputPin> structuredNodeInput = new();

        public void setMustIsolate(bool mustIsolate)
        {
            this.mustIsolate = mustIsolate;
        } // setMustIsolate

        public void addNode(
                ActivityNode node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            this.node.Add(node);
            node._setInStructuredNode(this);
        } // addNode

        public void addEdge(
                ActivityEdge edge)
        {
            if (edge is null)
            {
                throw new ArgumentNullException(nameof(edge));
            }

            this.edge.Add(edge);
            edge._setInStructuredNode(this);
        } // addEdge

        public void addStructuredNodeOutput(
                OutputPin structuredNodeOutput)
        {
            addOutput(structuredNodeOutput);
            this.structuredNodeOutput.Add(structuredNodeOutput);
        } // addStructuredNodeOutput

        public void addStructuredNodeInput(
                InputPin structuredNodeInput)
        {
            addInput(structuredNodeInput);
            this.structuredNodeInput.Add(structuredNodeInput);
        } // addStructuredNodeInput

        public override void _setContext(Classifier context)
        {
            base._setContext(context);
            foreach (ActivityNode node in node)
            {
                if (node is Action)
                {
                    (node as Action)!._setContext(context);
                }
            }
        } // _setContext

        public override void _setActivity(
                Activity activity)
        {
            base._setActivity(activity);
            this.activity = activity;
        } // _setActivity
    } // StructuredActivityNode
}
