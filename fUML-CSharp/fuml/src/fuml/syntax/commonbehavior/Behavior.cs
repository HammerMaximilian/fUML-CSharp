using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;
using System;

namespace fuml.syntax.commonbehavior
{
    public abstract class Behavior : Class_
    {
        public bool isReentrant = true;
        public BehavioralFeature? specification = null;
        public List<Parameter> ownedParameter = new();
        public BehavioredClassifier? context = null;

        public void addOwnedParameter(
                Parameter ownedParameter)
        {
            if (ownedParameter is null)
            {
                throw new ArgumentNullException(nameof(ownedParameter));
            }

            addOwnedMember(ownedParameter);
            this.ownedParameter.Add(ownedParameter);
        } // addOwnedParameter

        public virtual void _setContext(
                BehavioredClassifier context)
        {
            // Note: This is a helper operation intended to be called by certain
            // operations outside the Behavior class in order to allow the setting
            // of the context to be overriden in subclasses.
            // It should _not_ be called otherwise in order to set the context
            // directly, rather than via these other operations.

            // Debug.println("[_setContext] behavior = " + this.name +
            // ", context = " + context.name);

            this.context = context;
        } // _setContext

        public void _setSpecification(
                BehavioralFeature specification)
        {
            this.specification = specification ?? throw new ArgumentNullException(nameof(specification));
        } // _setSpecification
    } // Behavior
}
