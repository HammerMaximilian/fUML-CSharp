using fuml.library.common;
using fuml.library.libraryclass;
using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.channel
{
    public abstract class TextOutputChannelObject : OutputChannelObject
    {
        public TextOutputChannelObject() 
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_TextOutputChannel);
        }

        public abstract void WriteString(string value, Status errorStatus);
        public abstract void WriteNewLine(Status errorStatus);

        public void WriteLine(string value, Status errorStatus)
        {
            WriteString(value, errorStatus);
            WriteNewLine(errorStatus);
        }

        public void WriteInteger(int value, Status errorStatus)
        {
            WriteString(value.ToString(), errorStatus);
        }

        public void WriteReal(float value, Status errorStatus)
        {
            WriteString(value.ToString(), errorStatus);
        }

        public void WriteBoolean(bool value, Status errorStatus)
        {
            WriteString(value.ToString(), errorStatus);
        }

        public void WriteUnlimitedNatural(UMLPrimitiveTypes.UnlimitedNatural value, Status errorStatus)
        {
            int naturalValue = value.naturalValue;

            if (naturalValue < 0)
            {
                WriteString("*", errorStatus);
            }
            else
            {
                WriteString(naturalValue.ToString(), errorStatus);
            }

        }

        public override void Execute(OperationExecution execution)
        {
            string name = execution.GetOperationName();

            ParameterValue parameterValue = execution.GetParameterValue("value");

            Status status = new(locus!, "TextOutputChannel");

            if (name.Equals("writeNewLine"))
            {
                WriteNewLine(status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("writeString"))
            {
                WriteString(((StringValue)parameterValue.values.ElementAt(0)).value, status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("writeLine"))
            {
                WriteLine(((StringValue)parameterValue.values.ElementAt(0)).value, status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("writeInteger"))
            {
                WriteInteger(((IntegerValue)parameterValue.values.ElementAt(0)).value, status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("writeReal"))
            {
                WriteReal(((RealValue)parameterValue.values.ElementAt(0)).value, status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("writeBoolean"))
            {
                WriteBoolean(((BooleanValue)parameterValue.values.ElementAt(0)).value, status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("writeUnlimitedNatural"))
            {
                WriteUnlimitedNatural(((UnlimitedNaturalValue)parameterValue.values.ElementAt(0)).value, status);
                UpdateStatus(execution, status);
            }
            else
            {
                base.Execute(execution);
            }
        }
    } // TextOutputChannelObject
}
