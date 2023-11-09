using fuml.library.common;
using fuml.library.libraryclass;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.channel
{
    public abstract class ChannelObject : ImplementationObject
    {
        // NOTE: Initial status is not set here because this.locus will not be
        // set when the object is first created.
        protected Status? status = null;

        public abstract string GetName();
        public abstract void Open(Status errorStatus);
        public abstract void Close(Status errorStatus);
        public abstract bool IsOpen();

        public Status GetStatus()
        {
            status ??= new Status(locus!, "ChannelObject");
            return status;
        }

        public void UpdateStatus(OperationExecution execution, Status status)
        {
            if (!status.IsNormal())
            {
                execution.SetParameterValue("errorStatus", status.GetValue());
            }
            this.status = status;
        }

        public override void Execute(OperationExecution execution)
        {
            string name = execution.GetOperationName();

            Status status = new(locus!, "ChannelObject");

            if (name.Equals("getName"))
            {
                StringValue nameValue = new()
                {
                    value = GetName(),
                    type = locus?.factory?.GetBuiltInType("String")
                };
                execution.SetReturnParameterValue(nameValue);
            }
            else if (name.Equals("open"))
            {
                Open(status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("close"))
            {
                Close(status);
                UpdateStatus(execution, status);
            }
            else if (name.Equals("isOpen"))
            {
                BooleanValue isOpenValue = new()
                {
                    value = IsOpen(),
                    type = locus?.factory?.GetBuiltInType("Boolean")
                };
                execution.SetReturnParameterValue(isOpenValue);
            }
            else if (name.Equals("getStatus"))
            {
                Status result = GetStatus();
                execution.SetReturnParameterValue(result.GetValue());
            }
        }
    } // ChannelObject
}
