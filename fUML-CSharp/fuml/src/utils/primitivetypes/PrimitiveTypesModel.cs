using fuml.environment;
using uml.simpleclassifiers;

namespace fuml.primitivetypes
{
    public class PrimitiveTypesModel : InMemoryModel
    {
		private static PrimitiveTypesModel? instance;

		public PrimitiveType PrimitiveTypes_Boolean = new();
		public PrimitiveType PrimitiveTypes_Integer = new();
		public PrimitiveType PrimitiveTypes_Real = new();
		public PrimitiveType PrimitiveTypes_String = new();
		public PrimitiveType PrimitiveTypes_UnlimitedNatural = new();

		public static PrimitiveTypesModel Instance()
        {
			if(instance is null)
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

			//PrimitiveType Boolean
			PrimitiveTypes_Boolean.SetName("Boolean");

			//PrimitiveType Integer
			PrimitiveTypes_Integer.SetName("Integer");

			//PrimitiveType Real
			PrimitiveTypes_Real.SetName("Real");

			//PrimitiveType Integer
			PrimitiveTypes_String.SetName("String");

			//PrimitiveType Integer
			PrimitiveTypes_UnlimitedNatural.SetName("UnlimitedNatural");
		}
	} // PrimitiveTypesModel
}
