using fuml.syntax.actions;
using fuml.syntax.commonbehavior;
using System;
using System.IO.Pipes;

namespace fuml.syntax.activities
{
    public class Activity : Behavior
    {
        public List<StructuredActivityNode> structuredNode = new();
        public List<ActivityNode> node = new();
        public bool isReadOnly = false;
        public List<ActivityEdge> edge = new();
        public List<ActivityGroup> group = new();

        public void SetIsReadOnly(bool isReadOnly)
        {
            this.isReadOnly = isReadOnly;
        } // setIsReadOnly

        public void AddNode(
                ActivityNode node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (!this.node.Contains(node))
            {
                AddOwnedElement(node);

                this.node.Add(node);
                node._setActivity(this);
            }

            if (node is StructuredActivityNode structuredActivityNode &&
                    !structuredNode.Contains(node)) {
                structuredNode.Add(structuredActivityNode);
            }

        } // addNode

        public void AddStructuredNode(StructuredActivityNode node)
        {
            AddNode(node);
        }

        public void AddGroup(ActivityGroup group)
        {
            if (group is null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            this.group.Add(group);
        }

        public void AddEdge(
                ActivityEdge edge)
        {
            if (edge is null)
            {
                throw new ArgumentNullException(nameof(edge));
            }

            AddOwnedElement(edge);

            this.edge.Add(edge);
            edge._setActivity(this);
        } // addEdge

        public override void _setContext(
                BehavioredClassifier context)
        {
            // Note: The context of an activity should be set only _after_ all nodes
            // have been added to the activity.

            base._setContext(context);

            foreach (ActivityNode node in node)
            {
                if (node is actions.Action) {
                (node as actions.Action)!
                        ._setContext(context);
            }
        }
    } // _setContext
} // Activity
}
