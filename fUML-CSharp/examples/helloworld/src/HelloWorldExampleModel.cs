using fuml.library;
using fuml.primitivetypes;
using fuml.syntax.actions;
using fuml.syntax.activities;
using fuml.syntax.values;

namespace examples.HelloWorldExample
{
    public class HelloWorldExampleModel : fuml.environment.InMemoryModel
    {
        private static HelloWorldExampleModel? instance;

        public ActivityFinalNode? HelloWorldModel_main_ActivityFinalNode;
        public Activity? HelloWorldModel_main;
        public CallBehaviorAction? HelloWorldModel_main_callWriteLine;
        public ControlFlow? HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode;
        public ControlFlow? HelloWorldModel_main_From_InitialNode_To_SpecifyString;
        public InitialNode? HelloWorldModel_main_InitialNode;
        public InputPin? HelloWorldModel_main_callWriteLine_value;
        public OutputPin? HelloWorldModel_main_callWriteLine_errorStatus;
        public LiteralString? HelloWorldModel_main_SpecifyString_value;
        public ObjectFlow? HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input;
        public OutputPin? HelloWorldModel_main_SpecifyString_result;
        public ValueSpecificationAction? HelloWorldModel_main_SpecifyString;

        public static HelloWorldExampleModel Instance()
        {
            if (instance is null)
            {
                instance = new();
                instance.initializeInMemoryModel();
            }

            return instance;
        }

        private void initializeInMemoryModel()
        {
            /*
			 * Create in-memory model elements
			 */
            // Activity main
            HelloWorldModel_main = new();
            HelloWorldModel_main.SetName("main");
            AddToElementRepository("main", HelloWorldModel_main);
            //InitialNode InitialNode
            HelloWorldModel_main_InitialNode = new();
            HelloWorldModel_main_InitialNode.SetName("InitialNode");
            HelloWorldModel_main.node.Add(HelloWorldModel_main_InitialNode);
            //ValueSpecificationAction SpecifyString
            HelloWorldModel_main_SpecifyString = new();
            HelloWorldModel_main_SpecifyString.SetName("SpecifyString");
            //ValueSpecification value
            HelloWorldModel_main_SpecifyString_value = new();
            HelloWorldModel_main_SpecifyString_value.name = "value";
            HelloWorldModel_main_SpecifyString_value.value = "Hello World from activity! :)";
            HelloWorldModel_main_SpecifyString.SetValue(HelloWorldModel_main_SpecifyString_value);
            //OutputPin result
            HelloWorldModel_main_SpecifyString_result = new();
            HelloWorldModel_main_SpecifyString_result.SetName("result");
            HelloWorldModel_main_SpecifyString.SetResult(HelloWorldModel_main_SpecifyString_result);
            HelloWorldModel_main.node.Add(HelloWorldModel_main_SpecifyString);
            //CallBehaviorAction callWriteLine
            HelloWorldModel_main_callWriteLine = new();
            HelloWorldModel_main_callWriteLine.SetName("callWriteLine");
            HelloWorldModel_main_callWriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine!);
            HelloWorldModel_main_callWriteLine.isSynchronous = true; //imposed by the fUML specification
                                                                     //InputPin value
            HelloWorldModel_main_callWriteLine_value = new();
            HelloWorldModel_main_callWriteLine_value.SetName("value");
            HelloWorldModel_main_callWriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String!);
            HelloWorldModel_main_callWriteLine.AddArgument(HelloWorldModel_main_callWriteLine_value);
            //OutputPin errorStatus
            HelloWorldModel_main_callWriteLine_errorStatus = new();
            HelloWorldModel_main_callWriteLine_errorStatus.SetName("errorStatus");
            HelloWorldModel_main_callWriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status!);
            HelloWorldModel_main_callWriteLine.AddResult(HelloWorldModel_main_callWriteLine_errorStatus);
            HelloWorldModel_main.node.Add(HelloWorldModel_main_callWriteLine);
            //ActivityFinalNode ActivityFinalNode
            HelloWorldModel_main_ActivityFinalNode = new();
            HelloWorldModel_main_ActivityFinalNode.SetName("ActivityFinalNode");
            HelloWorldModel_main.node.Add(HelloWorldModel_main_ActivityFinalNode);
            //ControlFlow from InitialNode to SpecifyString
            HelloWorldModel_main_From_InitialNode_To_SpecifyString = new();
            HelloWorldModel_main_From_InitialNode_To_SpecifyString.SetName("From_InitialNode_To_SpecifyString");
            HelloWorldModel_main_From_InitialNode_To_SpecifyString.SetSource(HelloWorldModel_main_InitialNode);
            HelloWorldModel_main_InitialNode.outgoing.Add(HelloWorldModel_main_From_InitialNode_To_SpecifyString);
            HelloWorldModel_main_From_InitialNode_To_SpecifyString.SetTarget(HelloWorldModel_main_SpecifyString);
            HelloWorldModel_main_SpecifyString.incoming.Add(HelloWorldModel_main_From_InitialNode_To_SpecifyString);
            HelloWorldModel_main.edge.Add(HelloWorldModel_main_From_InitialNode_To_SpecifyString);
            //ObjectFlow from SpecifyString_result to callPrintln_input
            HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input = new();
            HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input.SetName("From_SpecifyString_result_To_callPrintln_input");
            HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input.SetSource(HelloWorldModel_main_SpecifyString_result);
            HelloWorldModel_main_SpecifyString_result.outgoing.Add(HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input);
            HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input.SetTarget(HelloWorldModel_main_callWriteLine_value);
            HelloWorldModel_main_callWriteLine_value.incoming.Add(HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input);
            HelloWorldModel_main.edge.Add(HelloWorldModel_main_From_SpecifyString_result_To_callPrintln_input);
            //ControlFlow from callPrintln to ActivityFinalNode
            HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode = new();
            HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode.SetName("From_callPrintln_To_ActivityFinalNode");
            HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode.SetSource(HelloWorldModel_main_callWriteLine);
            HelloWorldModel_main_callWriteLine.outgoing.Add(HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode);
            HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode.SetTarget(HelloWorldModel_main_ActivityFinalNode);
            HelloWorldModel_main_ActivityFinalNode.incoming.Add(HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode);
            HelloWorldModel_main.edge.Add(HelloWorldModel_main_From_callPrintln_To_ActivityFinalNode);
        }
    } // HelloWorldExampleModel
}
