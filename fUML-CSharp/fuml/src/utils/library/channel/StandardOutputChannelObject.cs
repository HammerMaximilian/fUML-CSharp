using fuml.library.common;
using fuml.semantics.values;

namespace fuml.library.channel
{
    public class StandardOutputChannelObject : TextOutputChannelObject
    {
        private bool opened = true;

        public StandardOutputChannelObject()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel!);
        }

        public override string GetName()
        {
            return "StandardOutput";
        }

        public override void Open(Status errorStatus)
        {
            opened = true;
        }

        public override void Close(Status errorStatus)
        {
            opened = false;
        }

        public override bool IsOpen()
        {
            return opened;
        }

        public override bool IsFull()
        {
            return false;
        }

        public override void Write(Value value, Status errorStatus)
        {
            WriteString(value.ToString(), errorStatus);
        }

        public override void WriteString(string value, Status errorStatus)
        {
            if (IsOpen())
            {
                Console.Write(value);
            }
            else
            {
                errorStatus.SetStatus("StandardOutputChannel", -1, "Not open");
            }
        }

        public override void WriteNewLine(Status errorStatus)
        {
            if (IsOpen())
            {
                Console.WriteLine();
            }
            else
            {
                errorStatus.SetStatus("StandardOutputChannel", -1, "Not open");
            }
        }

        protected override Value New_()
        {
            return new StandardOutputChannelObject();
        }
    } // StandardOutputChannelObject
}
