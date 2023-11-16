using uml.classification;
using uml.simpleclassifiers;

namespace uml.structuredclassifiers
{
    public class Port : Property // PSCS-specific
    {
        public bool isBehavior = false;
        public bool isConjugated = false;
        public bool isService = false;
        public List<Interface> required = new();
        public List<Interface> provided = new();

        public void AddRequired(Interface required)
        {
            if (required is null)
            {
                throw new ArgumentNullException(nameof(required));
            }

            this.required.Add(required);
        }

        public void AddProvided(Interface provided)
        {
            if (provided is null)
            {
                throw new ArgumentNullException(nameof(provided));
            }

            this.provided.Add(provided);
        }
    } // Port
}
