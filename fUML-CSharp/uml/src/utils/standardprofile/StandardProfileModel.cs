using uml.packages;

namespace uml.standardprofile
{
    public class StandardProfileModel : environment.InMemoryModel // PSCS-specific
    {
        private static StandardProfileModel? instance;

        public Profile Profile_StandardProfile = new();
        public Stereotype Stereotype_Create = new(); // For PSCS, only stereotype "Create" is required

        public static StandardProfileModel Instance()
        {
            if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
        }

        private void InitializeInMemoryModel()
        {
            /*
			 * Create in-memory model elements
			 */
            Profile_StandardProfile.SetName("StandardProfile");
            Stereotype_Create.SetName("Create");
            Stereotype_Create._setProfile(Profile_StandardProfile);
        }
    } // StandardProfileModel
}
