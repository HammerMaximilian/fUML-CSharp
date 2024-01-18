using uml.commonstructure;

namespace uml.classification
{
    public abstract class Classifier : commonstructure.Type
    {
        private bool memberConstructed = false;

        public bool isAbstract = false;
        public List<Generalization> generalization = new();
        public List<Feature> feature = new();
        public List<NamedElement> inheritedMember = new();
        public List<Property> attribute = new();
        public List<Classifier> general = new();
        public bool isFinalSpecialization = false;

        protected void AddFeature(Feature feature)
        {
            if (feature is null)
            {
                throw new ArgumentNullException(nameof(feature));
            }
            // Note: This operation should not be used directly to add Properties.
            // The addAttribute operation should be used instead.

            this.feature.Add(feature);
            feature._addFeaturingClassifier(this);
        } // addFeature

        protected void AddAttribute(Property attribute)
        {
            if (attribute is null)
            {
                throw new ArgumentNullException(nameof(attribute));
            }

            AddFeature(attribute);
            this.attribute.Add(attribute);
        } // addAttribute

        virtual public void AddGeneralization(
                Generalization generalization)
        {
            if (generalization is null)
            {
                throw new ArgumentNullException(nameof(generalization));
            }

            AddOwnedElement(generalization);
            this.generalization.Add(generalization);
            generalization._setSpecific(this);
            general.Add(generalization.general!);

            // In this implementation, members of base classifiers are not inherited here
            // See method "Classifier.Member()" below for further explanation
            /*List<NamedElement> inheritedMembers = Inherit(generalization!.general!
                    .InheritableMembers(this));

            foreach (NamedElement inheritedMember in inheritedMembers)
            {
                AddMember(inheritedMember);
                this.inheritedMember.Add(inheritedMember);
            }*/
        } // addGeneralization

        public void SetIsAbstract(bool isAbstract)
        {
            this.isAbstract = isAbstract;
        } // setIsAbstract

        virtual public List<NamedElement> Inherit(
                List<NamedElement> inhs)
        {
            List<NamedElement> inheritedElements = new();

            foreach (NamedElement inherit in inhs)
            {
                inheritedElements.Add(inherit);
            }

            return inheritedElements;

        } // inherit

        public List<NamedElement> InheritableMembers(
                Classifier c)
        {
            List<NamedElement> inheritable = new();

            foreach (NamedElement m in member)
            {
                if (c.HasVisibilityOf(m))
                {
                    inheritable.Add(m);
                }
            }

            return inheritable;
        } // inheritableMembers

        public bool HasVisibilityOf(NamedElement n)
        {
            foreach (NamedElement m in inheritedMember)
            {
                if (m == n)
                {
                    return n.visibility != VisibilityKind.private_;
                }
            }

            return true;
        } // hasVisibilityOf

        public void SetIsFinalSpecialization(bool isFinalSpecialization)
        {
            this.isFinalSpecialization = isFinalSpecialization;
        } // setIsFinalSpecialization


        // When using the generator to create an executable model within this implementation
        // the order in which classifiers are initialized and base classifiers are added (and thus, base members are inherited)
        // is arbitrary.
        // This can lead to base classifier members not being inherited as they are not yet created
        // Because of that, in this implementation, base members are not inherited when a generalization is added (i.e. in method "AddGeneralization").
        // Instead, property "Namespace.member" is encapsulated and can be accessed by method "Namespace.Member()".
        // This method is overridden here to inherit all base members recursively when "Classifier.Member()" is first invoked.
        // This first invocation happens during model execution, i.e. after all model classifiers have been completely created.
        override public List<NamedElement> Member()
        {
            if (!memberConstructed)
            {
                foreach (Classifier c in general)
                {
                    List<NamedElement> allMembersOfBase = c.Member(); // This is only done to recursively construct member
                    List<NamedElement> inheritedMembers = Inherit(c.InheritableMembers(this));

                    foreach (NamedElement inheritedMember in inheritedMembers)
                    {
                        AddMember(inheritedMember);
                        this.inheritedMember.Add(inheritedMember);
                    }
                }

                memberConstructed = true;
            }

            return member;
        } // AllMembers
    } // Classifier
}
