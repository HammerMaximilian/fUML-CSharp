using fuml.library.common;
using fuml.library.libraryclass;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.channel
{
    public abstract class InputChannelObject : ChannelObject
    {
        public InputChannelObject()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_InputChannel);
        }

        public abstract bool HasMore();
        public abstract Value Read(Status errorStatus);
        public abstract Value Peek(Status errorStatus);

        public override void Execute(OperationExecution execution)
        {
            string name = execution.GetOperationName();

            Status status = new(locus!, "InputChannel");

            if (name.Equals("hasMore"))
            {
                BooleanValue hasMoreValue = new()
                {
                    value = HasMore(),
                    type = locus?.factory?.GetBuiltInType("Boolean")
                };
                execution.SetReturnParameterValue(hasMoreValue);
            }
            else if (name.Equals("read"))
            {
                Value value = Read(status);
                if (value is not null)
                {
                    execution.SetParameterValue("value", value);
                }
                UpdateStatus(execution, status);
            }
            else if (name.Equals("peek"))
            {
                Value value = Peek(status);
                if (value != null)
                {
                    execution.SetParameterValue("value", value);
                }
                UpdateStatus(execution, status);
            }
            else
            {
                base.Execute(execution);
            }
        }
    } // InputChannelObject
}
