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

        public void setIsReadOnly(bool isReadOnly)
        {
            this.isReadOnly = isReadOnly;
        } // setIsReadOnly

        public void addNode(
                ActivityNode node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (!this.node.Contains(node))
            {
                addOwnedElement(node);

                this.node.Add(node);
                node._setActivity(this);
            }

            if (node is StructuredActivityNode &&
                    !this.structuredNode.Contains(node)) {
                this.structuredNode.Add((StructuredActivityNode)node);
            }

        } // addNode

        public void addStructuredNode(StructuredActivityNode node)
        {
            this.addNode(node);
        }

        public void addGroup(ActivityGroup group)
        {
            if (group is null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            this.group.Add(group);
        }

        public void addEdge(
                ActivityEdge edge)
        {
            if (edge is null)
            {
                throw new ArgumentNullException(nameof(edge));
            }

            addOwnedElement(edge);

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
