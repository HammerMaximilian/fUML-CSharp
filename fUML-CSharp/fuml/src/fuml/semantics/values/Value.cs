using fuml.semantics.loci;
using fuml.syntax.classification;

namespace fuml.semantics.values
{
    public abstract class Value : SemanticVisitor
    {
        public abstract syntax.values.ValueSpecification Specify();

        public virtual bool Equals(Value otherValue)
        {
            // Test if this value is equal to otherValue. To be equal, this value
            // must have the same type as otherValue.
            // This operation must be overridden in Value subclasses to check for
            // equality of properties defined in those subclasses.

            List<Classifier> myTypes = GetTypes();
            List<Classifier> otherTypes = otherValue.GetTypes();

            bool isEqual = true;

            if (myTypes.Count != otherTypes.Count)
            {
                isEqual = false;

            }
            else
            {
                int i = 1;
                while (isEqual & i <= myTypes.Count)
                {
                    bool matched = false;
                    int j = 1;
                    while (!matched & j <= otherTypes.Count)
                    {
                        matched = otherTypes.ElementAt(j - 1) == myTypes
                                .ElementAt(i - 1);
                        j++;
                    }

                    isEqual = matched;
                    i++;
                }
            }

            return isEqual;
        } // equals

        public virtual Value Copy()
        {
            // Create a new value that is equal to this value.
            // By default, this operation simply creates a new value with empty
            // properties.
            // It must be overridden in each Value subclass to do the superclass
            // copy and then appropriately set properties defined in the subclass.

            return New_();
        } // copy

        protected abstract Value New_();

        public abstract List<Classifier> GetTypes();

        public bool HasType(Classifier type)
        {
            // Check if this object has the given classifier as a type.

            List<Classifier> types = GetTypes();

            bool found = false;
            int i = 1;
            while (!found & i <= types.Count)
            {
                found = types.ElementAt(i - 1) == type;
                i++;
            }

            return found;
        } // hasType

        public bool IsInstanceOf(Classifier classifier)
        {
            // Check if this value has the given classifier as its type
            // or as an ancestor of one of its types.

            List<Classifier> types = GetTypes();

            bool isInstance = HasType(classifier);
            int i = 1;
            while (!isInstance & i <= types.Count)
            {
                isInstance = CheckAllParents(types.ElementAt(i - 1), classifier);
                i++;
            }
            return isInstance;
        }

        public bool CheckAllParents(Classifier type,
                Classifier classifier)
        {
            // Check if the given classifier matches any of the direct or indirect
            // ancestors of a given type.

            List<Classifier> directParents = type.general;
            bool matched = false;
            int i = 1;
            while (!matched & i <= directParents.Count)
            {
                Classifier directParent = directParents.ElementAt(i - 1);
                if (directParent == classifier)
                {
                    matched = true;
                }
                else
                {
                    matched = CheckAllParents(directParent, classifier);
                }
                i++;
            }

            return matched;

        }
        public abstract new string ToString();
    }
}
