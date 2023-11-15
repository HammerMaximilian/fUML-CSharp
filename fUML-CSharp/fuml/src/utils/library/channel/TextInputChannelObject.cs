using fuml.library.common;
using fuml.library.libraryclass;
using fuml.semantics.simpleclassifiers;
using UMLPrimitiveTypes;

namespace fuml.library.channel
{
    public abstract class TextInputChannelObject : InputChannelObject
    {
        public TextInputChannelObject()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_TextInputChannel);
        }

        public abstract string ReadCharacter(Status errorStatus);
        public abstract string PeekCharacter(Status errorStatus);
        public abstract string ReadLine(Status errorStatus);
        public abstract int? ReadInteger(Status errorStatus);
        public abstract float? ReadReal(Status errorStatus);
        public abstract bool? ReadBoolean(Status errorStatus);
        public abstract UnlimitedNatural ReadUnlimitedNatural(Status errorStatus);

        public override void Execute(OperationExecution execution)
        {
            string name = execution.GetOperationName();

            Status status = new(locus!, "TextInputChannel");
            PrimitiveValue? resultValue = null;

            if (name.Equals("readCharacter"))
            {
                string result = ReadCharacter(status);
                if (result is not null)
                {
                    resultValue = new StringValue
                    {
                        type = locus?.factory?.GetBuiltInType("String")
                    };
                    ((StringValue)resultValue).value = result;
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("peekCharacter"))
            {
                string result = PeekCharacter(status);
                if (result is not null)
                {
                    resultValue = new StringValue
                    {
                        type = locus?.factory?.GetBuiltInType("String")
                    };
                    ((StringValue)resultValue).value = result;
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("readLine"))
            {
                string result = ReadLine(status);
                if (result is not null)
                {
                    resultValue = new StringValue
                    {
                        type = locus?.factory?.GetBuiltInType("String")
                    };
                    ((StringValue)resultValue).value = result;
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("readInteger"))
            {
                int? result = ReadInteger(status);
                if (result != null)
                {
                    resultValue = new IntegerValue
                    {
                        type = locus?.factory?.GetBuiltInType("Integer")
                    };
                    ((IntegerValue)resultValue).value = (int)result;
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("readReal"))
            {
                float? result = ReadReal(status);
                if (result != null)
                {
                    resultValue = new RealValue
                    {
                        type = locus?.factory?.GetBuiltInType("Real")
                    };
                    ((RealValue)resultValue).value = (float)result;
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("readBoolean"))
            {
                bool? result = ReadBoolean(status);
                if (result != null)
                {
                    resultValue = new BooleanValue
                    {
                        type = locus?.factory?.GetBuiltInType("Boolean")
                    };
                    ((BooleanValue)resultValue).value = (bool)result;
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("readUnlimitedNatural"))
            {
                UnlimitedNatural result = ReadUnlimitedNatural(status);
                if (result is not null)
                {
                    resultValue = new UnlimitedNaturalValue
                    {
                        type = locus?.factory?.GetBuiltInType("UnlimitedNatural")
                    };
                    ((UnlimitedNaturalValue)resultValue).value = result;
                }
                UpdateStatus(execution, status);
            }
            else
            {
                base.Execute(execution);
            }

            if (resultValue is not null)
            {
                execution.SetReturnParameterValue(resultValue);
            }
        }
    } // TextInputChannelObject
}
