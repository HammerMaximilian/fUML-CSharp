using fuml.semantics.structuredclassifiers;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.loci
{
    public class Locus : FumlObject
    {
        public string identifier;
        public Executor? executor = null;
        public ExecutionFactory? factory = null;
        public List<ExtensionalValue> extensionalValues = new();

        public Locus()
        {
            identifier = GetHashCode().ToString("X8");
        }

        public void setExecutor(Executor executor)
        {
            // Set the executor for this locus.

            this.executor = executor;
            this.executor.locus = this;
        } // setExecutor

        public void setFactory(ExecutionFactory factory)
        {
            // Set the factory for this locus.

            this.factory = factory;
            this.factory.locus = this;
        } // setFactory

        public List<ExtensionalValue> getExtent(
                Classifier classifier)
        {
            // Return the set of extensional values at this locus which have the
            // given classifier as a type.

            List<ExtensionalValue> extent = new();

            List<ExtensionalValue> extensionalValues = this.extensionalValues;
            foreach (ExtensionalValue value in extensionalValues)
            {
                List<Classifier> types = value.getTypes();

                bool conforms = false;
                int j = 1;
                while (!conforms & j <= types.Count())
                {
                    conforms = this.conforms(types.ElementAt(j - 1), classifier);
                    j = j + 1;
                }

                if (conforms)
                {
                    extent.Add(value);
                }
            }

            return extent;
        } // getExtent

        public void add(ExtensionalValue value)
        {
            // Add the given extensional value to this locus

            value.locus = this;
            value.identifier = identifier + "#" + makeIdentifier(value);
            extensionalValues.Add(value);

        } // add

        public string makeIdentifier(ExtensionalValue value)
        {
            // Return an identifier for the given (newly created) extensional value.

            // [No normative specification. A conforming implementation may create an identifier 
            // an identifier in any way such that all identifiers for extensional values created
            // at any one locus are unique.]

            // Non-normative Java implementation
            return value.GetHashCode().ToString("X8");
        } // makeIdentifier

        public void remove(ExtensionalValue value)
        {
            // Remove the given extensional value from this locus.

            value.locus = null;

            bool notFound = true;
            int i = 1;
            while (notFound & i <= extensionalValues.Count())
            {
                if (extensionalValues.ElementAt(i - 1) == value)
                {
                    extensionalValues.RemoveAt(i - 1);
                    notFound = false;
                }
                i = i + 1;
            }
        } // remove

        public Object_ instantiate(
                Class_ type)
        {
            // Instantiate the given class at this locus.

            Object_? object_;
            if (type is Behavior)
            {
                object_ = factory?.createExecution((Behavior)type, null!);
            }
            else
            {
                object_ = new Object_();

                object_.types.Add(type);
                object_.createFeatureValues();
                add(object_);
            }

            return object_;
        } // instantiate

        public bool conforms(Classifier type,
                Classifier classifier)
        {
            // Test if a type conforms to a given classifier, that is, the type is
            // equal to or a descendant of the classifier.

            bool doesConform = false;

            if (type == classifier)
            {
                doesConform = true;
            }
            else
            {
                int i = 1;
                while (!doesConform & i <= type.general.Count())
                {
                    doesConform = conforms(type.general.ElementAt(i - 1),
                            classifier);
                    i = i + 1;
                }
            }

            return doesConform;

        } // conforms
    } // Locus
}
