using fuml.environment;
using fuml.syntax.simpleclassifiers;

namespace fuml.primitivetypes
{
    public class PrimitiveTypesModel : InMemoryModel
    {
		private static PrimitiveTypesModel? instance;

		public PrimitiveType? PrimitiveTypes_Boolean;
		public PrimitiveType? PrimitiveTypes_Integer;
		public PrimitiveType? PrimitiveTypes_Real;
		public PrimitiveType? PrimitiveTypes_String;
		public PrimitiveType? PrimitiveTypes_UnlimitedNatural;

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
			PrimitiveTypes_Boolean = new();
			PrimitiveTypes_Boolean.SetName("Boolean");

			//PrimitiveType Integer
			PrimitiveTypes_Integer = new();
			PrimitiveTypes_Integer.SetName("Integer");

			//PrimitiveType Real
			PrimitiveTypes_Real = new();
			PrimitiveTypes_Real.SetName("Real");

			//PrimitiveType Integer
			PrimitiveTypes_String = new();
			PrimitiveTypes_String.SetName("String");

			//PrimitiveType Integer
			PrimitiveTypes_UnlimitedNatural = new();
			PrimitiveTypes_UnlimitedNatural.SetName("UnlimitedNatural");
		}
	} // PrimitiveTypesModel
}
