using fuml.library.common;
using fuml.library.libraryclass;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.channel
{
    public abstract class OutputChannelObject : ChannelObject
    {
        public OutputChannelObject()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_OutputChannel);
        }

        public abstract void Write(Value value, Status errorStatus);
        public abstract bool IsFull();

        public override void Execute(OperationExecution execution)
        {
            string name = execution.GetOperationName();

            if (name.Equals("write"))
            {
                Status status = new(locus!, "OutputChannelObject");
                Write(execution.GetParameterValue("value").values.ElementAt(0), status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("isFull"))
            {
                BooleanValue isFullValue = new()
                {
                    value = IsFull(),
                    type = locus?.factory?.GetBuiltInType("Boolean")
                };
                execution.SetReturnParameterValue(isFullValue);
            }
            else
            {
                base.Execute(execution);
            }

        }
    } // OutputChannelObject
}
