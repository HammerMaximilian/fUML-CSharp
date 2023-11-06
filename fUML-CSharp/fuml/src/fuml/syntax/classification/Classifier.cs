using fuml.syntax.commonstructure;

namespace fuml.syntax.classification
{
    public abstract class Classifier : commonstructure.Type
    {
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

            List<NamedElement> inheritedMembers = Inherit(generalization!.general!
                    .InheritableMembers(this));

            foreach (NamedElement inheritedMember in inheritedMembers)
            {
                AddMember(inheritedMember);
                this.inheritedMember.Add(inheritedMember);
            }
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
    } // Classifier
}
