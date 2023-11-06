using fuml.syntax.actions;
using fuml.syntax.classification;
using fuml.syntax.values;

namespace fuml.syntax.activities
{
    public abstract class ActivityEdge : RedefinableElement
    {
        public Activity? activity = null;
        public ActivityNode? source = null;
        public ActivityNode? target = null;
        public ValueSpecification? guard = null;
        public StructuredActivityNode? inStructuredNode = null;

        public void SetTarget(
                ActivityNode target)
        {
            this.target = target ?? throw new ArgumentNullException(nameof(target));
            target._addIncoming(this);
        } // setTarget

        public void SetSource(
                ActivityNode source)
        {
            this.source = source ?? throw new ArgumentNullException(nameof(source));
            source._addOutgoing(this);
        } // setSource

        public void SetGuard(ValueSpecification guard)
        {
            if (guard is not null)
            {
                AddOwnedElement(guard);
            }

            this.guard = guard;
        } // setGuard

        public void _setActivity(
                Activity activity)
        {
            this.activity = activity ?? throw new ArgumentNullException(nameof(activity));
        } // _setActivity

        public void _setInStructuredNode(
                StructuredActivityNode inStructuredNode)
        {
            this.inStructuredNode = inStructuredNode ?? throw new ArgumentNullException(nameof(inStructuredNode));
        } // _setInStructuredNode
    } // ActivityEdge
}
