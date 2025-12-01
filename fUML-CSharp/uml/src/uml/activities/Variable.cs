using uml.actions;
using uml.commonstructure;
using uml.structuredclassifiers;

namespace uml.activities
{
    public class Variable : ConnectableElement
    {
        public MultiplicityElement multiplicityElement = new();

        public Activity? activityScope = null;
        public StructuredActivityNode? scope = null;

        public void SetActivityScope(Activity activityScope)
        {
            if (activityScope is null)
            {
                throw new ArgumentNullException(nameof(activityScope));
            }

            this.activityScope = activityScope;
        } // SetActivityScope

        public void SetScope(StructuredActivityNode scope)
        {
            if (scope is null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            this.scope = scope;
        } // SetScope
    } // Variable
}
