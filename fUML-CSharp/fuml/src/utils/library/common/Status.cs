using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.simpleclassifiers;

namespace fuml.library.common
{
    public class Status
    {
        private PrimitiveType? stringType = null;
        private PrimitiveType? integerType = null;

        private string context = "";
        private int code = 0;
        private string description = "";

        static private DataType? statusType = null;

        static public DataType GetStatusType()
        {
            statusType ??= FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status;
            return statusType!;
        }

        static public void SetStatusType(DataType type)
        {
            statusType = type;
        }

        public Status()
        {

        }

        public Status(Locus locus, string context, int code, string description)
        {
            SetPrimitiveTypes(locus);
            SetStatus(context, code, description);
        }

        public Status(Locus locus, string context)
        {
            SetPrimitiveTypes(locus);
            SetStatus(context, 0, "Normal");
        }

        private void SetPrimitiveTypes(Locus locus)
        {
            stringType = locus?.factory?.GetBuiltInType("String");
            integerType = locus?.factory?.GetBuiltInType("Integer");
        }

        public bool IsNormal()
        {
            return code == 0;
        }

        public void SetStatus(string context, int code, string description)
        {
            this.context = context;
            this.code = code;
            this.description = description;
        }

        public string GetContext()
        {
            return context;
        }

        public int GetCode()
        {
            return code;
        }

        public string GetDescription()
        {
            return description;
        }

        public Value GetValue()
        {
            DataValue value = new();
            DataType statusType = GetStatusType();
            value.type = statusType;
            foreach (Property attribute in statusType.ownedAttribute)
            {
                PrimitiveValue? attributeValue = null;
                if (attribute.name.Equals("context"))
                {
                    attributeValue = new StringValue
                    {
                        type = stringType
                    };
                    ((StringValue)attributeValue).value = context;
                }
                else if (attribute.name.Equals("code"))
                {
                    attributeValue = new IntegerValue
                    {
                        type = integerType
                    };
                    ((IntegerValue)attributeValue).value = code;
                }
                else if (attribute.name.Equals("description"))
                {
                    attributeValue = new StringValue
                    {
                        type = stringType
                    };
                    ((StringValue)attributeValue).value = description;
                }
                List<Value> values = new()
                {
                    attributeValue!
                };
                value.SetFeatureValue(attribute, values, 0);
            }
            return value;
        }
    } // Status
}
