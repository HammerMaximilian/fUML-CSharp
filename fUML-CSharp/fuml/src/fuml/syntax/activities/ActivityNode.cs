using fuml.syntax.actions;
using fuml.syntax.classification;

namespace fuml.syntax.activities
{
    public abstract class ActivityNode : RedefinableElement
    {
        public StructuredActivityNode? inStructuredNode = null;
        public Activity? activity = null;
        public List<ActivityEdge> outgoing = new();
        public List<ActivityEdge> incoming = new();

        virtual public void _setActivity(
                Activity activity)
        {
            this.activity = activity ?? throw new ArgumentNullException(nameof(activity));
        } // _setActivity

        public void _setInStructuredNode(
                StructuredActivityNode inStructuredNode)
        {
            this.inStructuredNode = inStructuredNode ?? throw new ArgumentNullException(nameof(inStructuredNode));
        } // _setInStructuredNode

        public void _addIncoming(
                ActivityEdge incoming)
        {
            if (incoming is null)
            {
                throw new ArgumentNullException(nameof(incoming));
            }

            this.incoming.Add(incoming);
        } // _addIncoming

        public void _addOutgoing(
                ActivityEdge outgoing)
        {
            this.outgoing.Add(outgoing);
        } // _addOutgoing
    } // ActivityNode
}
