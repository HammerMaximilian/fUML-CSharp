using fuml.semantics.structuredclassifiers;
using uml.classification;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace fuml.semantics.loci
{
    public class Locus
    {
        public string identifier;
        public Executor? executor = null;
        public ExecutionFactory? factory = null;
        public List<ExtensionalValue> extensionalValues = new();

        public Locus()
        {
            identifier = GetHashCode().ToString("X8");
        }

        public void SetExecutor(Executor executor)
        {
            // Set the executor for this locus.

            this.executor = executor;
            this.executor.locus = this;
        } // setExecutor

        public void SetFactory(ExecutionFactory factory)
        {
            // Set the factory for this locus.

            this.factory = factory;
            this.factory.locus = this;
        } // setFactory

        public List<ExtensionalValue> GetExtent(
                Classifier classifier)
        {
            // Return the set of extensional values at this locus which have the
            // given classifier as a type.

            List<ExtensionalValue> extent = new();

            List<ExtensionalValue> extensionalValues = this.extensionalValues;
            foreach (ExtensionalValue value in extensionalValues)
            {
                List<Classifier> types = value.GetTypes();

                bool conforms = false;
                int j = 1;
                while (!conforms & j <= types.Count)
                {
                    conforms = Conforms(types.ElementAt(j - 1), classifier);
                    j++;
                }

                if (conforms)
                {
                    extent.Add(value);
                }
            }

            return extent;
        } // getExtent

        public void Add(ExtensionalValue value)
        {
            // Add the given extensional value to this locus

            value.locus = this;
            value.identifier = identifier + "#" + MakeIdentifier(value);
            extensionalValues.Add(value);

        } // add

        public string MakeIdentifier(ExtensionalValue value)
        {
            // Return an identifier for the given (newly created) extensional value.

            // [No normative specification. A conforming implementation may create an identifier 
            // an identifier in any way such that all identifiers for extensional values created
            // at any one locus are unique.]

            // Non-normative Java implementation
            return value.GetHashCode().ToString("X8");
        } // makeIdentifier

        public void Remove(ExtensionalValue value)
        {
            // Remove the given extensional value from this locus.

            value.locus = null;

            bool notFound = true;
            int i = 1;
            while (notFound & i <= extensionalValues.Count)
            {
                if (extensionalValues.ElementAt(i - 1) == value)
                {
                    extensionalValues.RemoveAt(i - 1);
                    notFound = false;
                }
                i++;
            }
        } // remove

        public Object_ Instantiate(
                Class_ type)
        {
            // Instantiate the given class at this locus.

            Object_? object_;
            if (type is Behavior behavior)
            {
                object_ = factory?.CreateExecution(behavior, null!);
            }
            else
            {
                object_ = new Object_();

                object_.types.Add(type);
                object_.CreateFeatureValues();
                Add(object_);
            }

            return object_!;
        } // instantiate

        public bool Conforms(Classifier type,
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
                while (!doesConform & i <= type.general.Count)
                {
                    doesConform = Conforms(type.general.ElementAt(i - 1),
                            classifier);
                    i++;
                }
            }

            return doesConform;

        } // conforms
    } // Locus
}
