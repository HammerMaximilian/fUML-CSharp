using fuml.semantics.loci;
using fuml.syntax.classification;

namespace fuml.semantics.values
{
    public abstract class Value : SemanticVisitor
    {
        public abstract syntax.values.ValueSpecification specify();

        public virtual bool equals(Value otherValue)
        {
            // Test if this value is equal to otherValue. To be equal, this value
            // must have the same type as otherValue.
            // This operation must be overridden in Value subclasses to check for
            // equality of properties defined in those subclasses.

            List<Classifier> myTypes = this.getTypes();
            List<Classifier> otherTypes = otherValue.getTypes();

            bool isEqual = true;

            if (myTypes.Count() != otherTypes.Count())
            {
                isEqual = false;

            }
            else
            {
                int i = 1;
                while (isEqual & i <= myTypes.Count())
                {
                    bool matched = false;
                    int j = 1;
                    while (!matched & j <= otherTypes.Count())
                    {
                        matched = (otherTypes.ElementAt(j - 1) == myTypes
                                .ElementAt(i - 1));
                        j = j + 1;
                    }

                    isEqual = matched;
                    i = i + 1;
                }
            }

            return isEqual;
        } // equals

        public virtual Value copy()
        {
            // Create a new value that is equal to this value.
            // By default, this operation simply creates a new value with empty
            // properties.
            // It must be overridden in each Value subclass to do the superclass
            // copy and then appropriately set properties defined in the subclass.

            return new_();
        } // copy

        protected abstract Value new_();

        public abstract List<Classifier> getTypes();

        public bool hasType(Classifier type)
        {
            // Check if this object has the given classifier as a type.

            List<Classifier> types = this.getTypes();

            bool found = false;
            int i = 1;
            while (!found & i <= types.Count())
            {
                found = (types.ElementAt(i - 1) == type);
                i = i + 1;
            }

            return found;
        } // hasType

        public bool isInstanceOf(Classifier classifier)
        {
            // Check if this value has the given classifier as its type
            // or as an ancestor of one of its types.

            List<Classifier> types = this.getTypes();

            bool isInstance = this.hasType(classifier);
            int i = 1;
            while (!isInstance & i <= types.Count())
            {
                isInstance = this.checkAllParents(types.ElementAt(i - 1), classifier);
                i = i + 1;
            }
            return isInstance;
        }

        public bool checkAllParents(Classifier type,
                Classifier classifier)
        {
            // Check if the given classifier matches any of the direct or indirect
            // ancestors of a given type.

            List<Classifier> directParents = type.general;
            bool matched = false;
            int i = 1;
            while (!matched & i <= directParents.Count())
            {
                Classifier directParent = directParents.ElementAt(i - 1);
                if (directParent == classifier)
                {
                    matched = true;
                }
                else
                {
                    matched = this.checkAllParents(directParent, classifier);
                }
                i = i + 1;
            }

            return matched;

        }
        public abstract string toString();
    }
}
