using uml.structuredclassifiers;

namespace uml.packages
{
    public class Stereotype : Class_ // PSCS-specific, Stereotypes are required in PSCS
    {
        public Profile? profile = null;

        public void _setProfile(Profile profile)
        {
            this.profile = profile ?? throw new ArgumentNullException(nameof(profile));
        }
    } // Stereotype
}
