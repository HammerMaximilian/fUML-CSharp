using fuml.environment;
using fuml.primitivetypes;
using fuml.syntax.actions;
using fuml.syntax.activities;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;
using fuml.syntax.simpleclassifiers;
using fuml.syntax.structuredclassifiers;

namespace fuml.library
{
    public class FoundationalModelLibraryModel : InMemoryModel
    {
        private static FoundationalModelLibraryModel? instance;

        /*
		 * Primitive Behaviors
		 */
        /*
         * Boolean functions
         */
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_y = new();

        /*
         * Integer functions
         */
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_y = new();

        /*
         * Real Functions
         */
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_y = new();

        /*
         * String Functions
         */
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_lower = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_upper = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_x = new();

        /*
         * UnlimitedNatural Functions
         */
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_x = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_y = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_result = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_x = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_y = new();

        /*
         * List Functions
         */
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_list = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_result = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_list = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_index = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_result = new();
        public FunctionBehavior FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list1 = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list2 = new();
        public Parameter FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_result = new();

        /*
         * Common
         */
        /*
         * Signal Notification
         */
        public Signal FoundationalModelLibrary_Common_Notification = new();
        public Property FoundationalModelLibrary_Common_Notification_content = new();

        /*
         * Class Listener
         */
        public Class_ FoundationalModelLibrary_Common_Listener = new();
        public Reception FoundationalModelLibrary_Common_Listener_Notification = new();

        /*
         * DataType Status
         */
        public DataType FoundationalModelLibrary_Common_Status = new();
        public Property FoundationalModelLibrary_Common_Status_context = new();
        public Property FoundationalModelLibrary_Common_Status_code = new();
        public Property FoundationalModelLibrary_Common_Status_description = new();

        /*
         * BasicInputOutput
         */
        /*
         * Class Channel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_Channel = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_Channel_getName = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_Channel_getName_ReturnResult = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_Channel_open = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_Channel_open_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_Channel_close = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_Channel_close_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_Channel_isOpen = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_Channel_isOpen_ReturnResult = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_Channel_getStatus = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_Channel_getStatus_ReturnResult = new();

        /*
         * Class InputChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_InputChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_InputChannel_Generalization_Channel = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore_ReturnResult = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_InputChannel_read = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_InputChannel_read_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_InputChannel_read_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_InputChannel_peek = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_errorStatus = new();

        /*
         * Class OutputChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_OutputChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_OutputChannel_Generalization_Channel = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_OutputChannel_write = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull_ReturnResult = new();

        /*
         * TextInputChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_TextInputChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_TextInputChannel_Generalization_InputChannel = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_ReturnResult = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_OwnedParameter = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_ReturnResult = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_ReturnResult = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_ReturnResult = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_ReturnResult = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_ReturnResult = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_errorStatus = new();

        /*
         * TextOutputChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_TextOutputChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_Generalization_OutputChannel = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_errorStatus = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_errorStatus = new();

        /*
         * StandardInputChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_StandardInputChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_StandardInputChannel_Generalization_TextInputChannel = new();

        /*
         * StandardOutputChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel_Generalization_TextOutputChannel = new();

        /*
         * Activity WriteLine
         */
        public Activity FoundationalModelLibrary_BasicInputOutput_WriteLine = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_WriteLine_value = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus = new();
        public ActivityParameterNode FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_value = new();
        public ActivityParameterNode FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_errorStatus = new();
        public ReadExtentAction FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel = new();
        public OutputPin FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel_result = new();
        public CallOperationAction FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine = new();
        public InputPin FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_target = new();
        public InputPin FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_value = new();
        public OutputPin FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_errorStatus = new();
        public ObjectFlow FoundationalModelLibrary_BasicInputOutput_WriteLine_From_StandardOutputChannel_result_To_writeLine_target = new();
        public ObjectFlow FoundationalModelLibrary_BasicInputOutput_WriteLine_From_value_To_writeLine_value = new();
        public ObjectFlow FoundationalModelLibrary_BasicInputOutput_WriteLine_From_writeLine_errorStatus_To_errorStatus = new();

        /*
         * Class ActiveChannel
         */
        public Class_ FoundationalModelLibrary_BasicInputOutput_ActiveChannel = new();
        public Generalization FoundationalModelLibrary_BasicInputOutput_ActiveChannel_Generalization_Channel = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register_listener = new();
        public Operation FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister_listener = new();

        /*
         * Activity ReadLine
         */
        public Activity FoundationalModelLibrary_BasicInputOutput_ReadLine = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_ReadLine_errorStatus = new();
        public Parameter FoundationalModelLibrary_BasicInputOutput_ReadLine_result = new();
        public ActivityParameterNode FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_errorStatus = new();
        public ActivityParameterNode FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_result = new();
        public ReadExtentAction FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel = new();
        public OutputPin FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel_result = new();
        public CallOperationAction FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine = new();
        public InputPin FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_target = new();
        public OutputPin FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_result = new();
        public OutputPin FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_errorStatus = new();
        public ObjectFlow FoundationalModelLibrary_BasicInputOutput_ReadLine_From_StandardInputChannel_result_To_readLine_target = new();
        public ObjectFlow FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_result_To_result = new();
        public ObjectFlow FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_errorStatus_To_errorStatus = new();

        public static FoundationalModelLibraryModel Instance()
        {
            if (instance is null)
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

            /*
			 * Boolean functions
			 */
            //FunctionBehavior And
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And.SetName("And");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_y);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And_result);

            //FunctionBehavior Implies
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies.SetName("Implies");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_y);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies_result);

            //FunctionBehavior Not
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not.SetName("Not");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_x);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not_result);

            //FunctionBehavior Or
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or.SetName("Or");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_y);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or_result);

            //FunctionBehavior ToBoolean
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean.SetName("ToBoolean");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_x);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_result.SetLower(0);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean_result);

            //FunctionBehavior ToString
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString.SetName("ToString");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_x);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString_result);

            //FunctionBehavior Xor
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor.SetName("Xor");
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_y);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor_result);

            /*
			 * Integer functions
			 */
            //FunctionBehavior Abs
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs.SetName("Abs");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Abs_x);

            //FunctionBehavior Div
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div.SetName("Div");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div_y);

            //FunctionBehavior Max
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max.SetName("Max");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Max_y);

            //FunctionBehavior Min
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min.SetName("Min");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min_y);

            //FunctionBehavior Mod
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod.SetName("Mod");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod_y);

            //FunctionBehavior Neg
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg.SetName("Neg");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg_x);

            //FunctionBehavior ToInteger
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger.SetName("ToInteger");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToInteger_x);

            //FunctionBehavior ToString
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString.SetName("ToString");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString_x);

            //FunctionBehavior ToUnlimitedNatural
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural.SetName("ToUnlimitedNatural");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural_x);

            //FunctionBehavior divide
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide.SetName("/");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide_y);
            /* NOT PRESENT IN FUML LIBRARY
				//FunctionBehavior equals
				FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals.SetName("equals");
					//Parameter result
					FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals_result = nullptr;
					//Parameter x
					FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals_x = nullptr;
					//Parameter y
					FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_equals_y = nullptr;
			*/
            //FunctionBehavior greaterOrEqual
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual.SetName(">=");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterOrEqual_y);

            //FunctionBehavior greaterThan
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan.SetName(">");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_greaterThan_y);

            //FunctionBehavior lessOrEqual
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual.SetName("<=");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessOrEqual_y);

            //FunctionBehavior lessThan
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan.SetName("<");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan_y);

            //FunctionBehavior minus
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus.SetName("-");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_minus_y);

            //FunctionBehavior plus
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus.SetName("+");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus_y);

            //FunctionBehavior times
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times.SetName("*");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times_y);

            /*
			 * Real functions
			 */
            //FunctionBehavior Abs
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs.SetName("Abs");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs_x);

            //FunctionBehavior Floor
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor.SetName("Floor");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Floor_x);

            //FunctionBehavior Inv
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv.SetName("Inv");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv_x);

            //FunctionBehavior Max
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max.SetName("Max");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max_y);

            //FunctionBehavior Min
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min.SetName("Min");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Min_y);

            //FunctionBehavior Neg
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg.SetName("Neg");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg_x);

            //FunctionBehavior Round
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round.SetName("Round");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Round_x);

            //FunctionBehavior ToInteger
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger.SetName("ToInteger");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger_x);

            //FunctionBehavior ToReal
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal.SetName("ToReal");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal_x);

            //FunctionBehavior ToString
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString.SetName("ToString");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString_x);

            //FunctionBehavior divide
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide.SetName("/");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_divide_y);
            /* NOT PRESENT IN FUML LIBRARY
				//FunctionBehavior equals
				FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_equals.SetName("equals");
					//Parameter result
					FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_equals_result = nullptr;
					//Parameter x
					FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_equals_x = nullptr;
					//Parameter y
					FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_equals_y = nullptr;
			*/
            //FunctionBehavior greaterOrEqual
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual.SetName(">=");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterOrEqual_y);

            //FunctionBehavior greaterThan
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan.SetName(">");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_greaterThan_y);

            //FunctionBehavior lessOrEqual
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual.SetName("<=");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessOrEqual_y);

            //FunctionBehavior lessThan
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan.SetName("<");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_lessThan_y);

            //FunctionBehavior minus
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus.SetName("-");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_minus_y);

            //FunctionBehavior plus
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus.SetName("+");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_plus_y);

            //FunctionBehavior times
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times.SetName("*");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times_y);

            /*
			 * String functions
			 */
            //FunctionBehavior Concat
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat.SetName("Concat");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat_y);

            //FunctionBehavior Size
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size.SetName("Size");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size_x);

            //FunctionBehavior Substring
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring.SetName("Substring");
            //Parameter lower
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_lower.SetName("lower");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_lower.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_lower);
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_result);
            //Parameter upper
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_upper.SetName("upper");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_upper.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_upper);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring_x);

            /*
			 * UnlimitedNatural functions
			 */
            //FunctionBehavior Max
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max.SetName("Max");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Max_y);

            //FunctionBehavior Min
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min.SetName("Min");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min_y);

            //FunctionBehavior ToInteger
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger.SetName("ToInteger");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger_x);

            //FunctionBehavior ToString
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString.SetName("ToString");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString_x);

            //FunctionBehavior ToUnlimitedNatural
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural.SetName("ToUnlimitedNatural");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural_x);
            /* NOT PRESENT IN FUML LIBRARY
				//FunctionBehavior equals
				FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_equals.SetName("equals");
					//Parameter result
					FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_equals_result = nullptr;
					//Parameter x
					FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_equals_x = nullptr;
					//Parameter y
					FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_equals_y = nullptr;
			*/
            //FunctionBehavior greaterOrEqual
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual.SetName(">=");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual_y);

            //FunctionBehavior greaterThan
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan.SetName(">");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterThan_y);

            //FunctionBehavior lessOrEqual
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual.SetName("<=");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual_y);

            //FunctionBehavior lessThan
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan.SetName("<");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_result);
            //Parameter x
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_x.SetName("x");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_x);
            //Parameter y
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_y.SetName("y");
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessThan_y);

            /*
			 * List functions
			 */
            //FunctionBehavior ListSize
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize.SetName("ListSize");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_result);
            //Parameter list
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_list.SetName("list");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_list.SetLower(0);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_list.SetUpper(-1);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize_list);

            //FunctionBehavior ListGet
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet.SetName("ListGet");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_result);
            //Parameter index
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_index.SetName("index");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_index.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_index);
            //Parameter list
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_list.SetName("list");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_list.SetLower(0);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_list.SetUpper(-1);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet_list);

            //FunctionBehavior ListConcat
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat.SetName("ListConcat");
            //Parameter result
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_result.SetName("result");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_result.SetLower(0);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_result.SetUpper(-1);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_result);
            //Parameter index
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list1.SetName("list1");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list1.SetLower(0);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list1.SetUpper(-1);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list1);
            //Parameter list
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list2.SetName("list2");
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list2.SetLower(0);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list2.SetUpper(-1);
            FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat.AddOwnedParameter(FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat_list2);

            /*
			 * Common
			 */
            //Signal Notification
            FoundationalModelLibrary_Common_Notification.SetName("Notification");
            //Property content
            FoundationalModelLibrary_Common_Notification_content.SetName("content");
            FoundationalModelLibrary_Common_Notification_content.SetLower(0);
            FoundationalModelLibrary_Common_Notification.AddOwnedAttribute(FoundationalModelLibrary_Common_Notification_content);

            //Class Listener
            FoundationalModelLibrary_Common_Listener.SetName("Listener");
            FoundationalModelLibrary_Common_Listener.SetIsAbstract(true);
            FoundationalModelLibrary_Common_Listener.SetIsActive(true);
            //Reception Notification
            FoundationalModelLibrary_Common_Listener_Notification.SetName("Notification");
            FoundationalModelLibrary_Common_Listener_Notification.SetSignal(FoundationalModelLibrary_Common_Notification);
            FoundationalModelLibrary_Common_Listener.AddOwnedReception(FoundationalModelLibrary_Common_Listener_Notification);

            //DataType Status
            FoundationalModelLibrary_Common_Status.SetName("Status");
            //Property context
            FoundationalModelLibrary_Common_Status_context.SetName("context");
            FoundationalModelLibrary_Common_Status_context.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_Common_Status.AddOwnedAttribute(FoundationalModelLibrary_Common_Status_context);
            //Property code
            FoundationalModelLibrary_Common_Status_code.SetName("code");
            FoundationalModelLibrary_Common_Status_code.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_Common_Status.AddOwnedAttribute(FoundationalModelLibrary_Common_Status_code);
            //Property description
            FoundationalModelLibrary_Common_Status_description.SetName("description");
            FoundationalModelLibrary_Common_Status_description.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_Common_Status.AddOwnedAttribute(FoundationalModelLibrary_Common_Status_description);

            /*
			 * BasicInputOutput
			 */
            // Class Channel
            FoundationalModelLibrary_BasicInputOutput_Channel.SetName("Channel");
            FoundationalModelLibrary_BasicInputOutput_Channel.SetIsAbstract(true);
            //Operation getName
            FoundationalModelLibrary_BasicInputOutput_Channel_getName.SetName("getName");
            FoundationalModelLibrary_BasicInputOutput_Channel_getName.SetIsAbstract(true);
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_Channel_getName_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_Channel_getName_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_Channel_getName_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_Channel_getName.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_Channel_getName_ReturnResult);
            FoundationalModelLibrary_BasicInputOutput_Channel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_Channel_getName);
            //Operation open
            FoundationalModelLibrary_BasicInputOutput_Channel_open.SetName("open");
            FoundationalModelLibrary_BasicInputOutput_Channel_open.SetIsAbstract(true);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_Channel_open_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_Channel_open_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_Channel_open_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_Channel_open.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_Channel_open_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_Channel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_Channel_open);
            //Operation close
            FoundationalModelLibrary_BasicInputOutput_Channel_close.SetName("close");
            FoundationalModelLibrary_BasicInputOutput_Channel_close.SetIsAbstract(true);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_Channel_close_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_Channel_close_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_Channel_close_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_Channel_close.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_Channel_close_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_Channel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_Channel_close);
            //Operation isOpen
            FoundationalModelLibrary_BasicInputOutput_Channel_isOpen.SetName("isOpen");
            FoundationalModelLibrary_BasicInputOutput_Channel_isOpen.SetIsAbstract(true);
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_Channel_isOpen_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_Channel_isOpen_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_BasicInputOutput_Channel_isOpen_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_Channel_isOpen.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_Channel_isOpen_ReturnResult);
            FoundationalModelLibrary_BasicInputOutput_Channel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_Channel_isOpen);
            //Operation getStatus
            FoundationalModelLibrary_BasicInputOutput_Channel_getStatus.SetName("getStatus");
            FoundationalModelLibrary_BasicInputOutput_Channel_getStatus.SetIsAbstract(true);
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_Channel_getStatus_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_Channel_getStatus_ReturnResult.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_Channel_getStatus_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_Channel_getStatus.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_Channel_getStatus_ReturnResult);
            FoundationalModelLibrary_BasicInputOutput_Channel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_Channel_getStatus);

            //Class InputChannel
            FoundationalModelLibrary_BasicInputOutput_InputChannel.SetName("InputChannel");
            FoundationalModelLibrary_BasicInputOutput_InputChannel.SetIsAbstract(true);
            //Generalization to Channel
            FoundationalModelLibrary_BasicInputOutput_InputChannel_Generalization_Channel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_Channel);
            FoundationalModelLibrary_BasicInputOutput_InputChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_InputChannel_Generalization_Channel);
            //Operation hasMore
            FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore.SetName("hasMore");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore.SetIsAbstract(true);
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore_ReturnResult);
            FoundationalModelLibrary_BasicInputOutput_InputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_InputChannel_hasMore);
            //Operation read
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read.SetName("read");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read.SetIsAbstract(true);
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read_value.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_InputChannel_read_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_read.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_InputChannel_read_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_InputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_InputChannel_read);
            //Operation peek
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek.SetName("peek");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek.SetIsAbstract(true);
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_value.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_InputChannel_peek.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_InputChannel_peek_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_InputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_InputChannel_peek);

            //Class OutputChannel
            FoundationalModelLibrary_BasicInputOutput_OutputChannel.SetName("OutputChannel");
            FoundationalModelLibrary_BasicInputOutput_OutputChannel.SetIsAbstract(true);
            //Generalization to Channel
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_Generalization_Channel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_Channel);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_OutputChannel_Generalization_Channel);
            //Operation isFull
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull.SetName("isFull");
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull.SetIsAbstract(true);
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull_ReturnResult);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_OutputChannel_isFull);
            //Operation write
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write.SetName("write");
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write.SetIsAbstract(true);
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel_write.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_OutputChannel_write_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_OutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_OutputChannel_write);

            //Class TextInputChannel
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.SetName("TextInputChannel");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.SetIsAbstract(true);
            //Generalization to Channel
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_Generalization_InputChannel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_InputChannel);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_Generalization_InputChannel);
            //Operation readCharacter
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter.SetName("readCharacter");
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_ReturnResult);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readCharacter);
            //Operation peekCharacter
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter.SetName("peekCharacter");
            //Parameter OwnedParameter
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_OwnedParameter.SetName("OwnedParameter");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_OwnedParameter.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_OwnedParameter.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_OwnedParameter);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_peekCharacter);
            //Operation readLine
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine.SetName("readLine");
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_ReturnResult);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine);
            //Operation readInteger
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger.SetName("readInteger");
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_ReturnResult);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readInteger);
            //Operation readReal
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal.SetName("readReal");
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_ReturnResult);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readReal);
            //Operation readBoolean
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean.SetName("readBoolean");
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_ReturnResult);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readBoolean);
            //Operation readUnlimitedNatural
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural.SetName("readUnlimitedNatural");
            //Parameter ReturnResult
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_ReturnResult.SetName("ReturnResult");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_ReturnResult.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_ReturnResult.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_ReturnResult);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextInputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readUnlimitedNatural);

            //Class TextOutputChannel
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.SetName("TextOutputChannel");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.SetIsAbstract(true);
            //Generalization to Channel
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_Generalization_OutputChannel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_OutputChannel);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_Generalization_OutputChannel);

            //Class StandardInputChannel
            FoundationalModelLibrary_BasicInputOutput_StandardInputChannel.SetName("StandardInputChannel");
            FoundationalModelLibrary_BasicInputOutput_StandardInputChannel.SetIsAbstract(true);
            //Generalization to TextInputChannel
            FoundationalModelLibrary_BasicInputOutput_StandardInputChannel_Generalization_TextInputChannel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_TextInputChannel);
            FoundationalModelLibrary_BasicInputOutput_StandardInputChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_StandardInputChannel_Generalization_TextInputChannel);

            //Class StandardOutputChannel
            FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel.SetName("StandardOutputChannel");
            FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel.SetIsAbstract(true);
            //Generalization to TextOutputChannel
            FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel_Generalization_TextOutputChannel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel);
            FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel_Generalization_TextOutputChannel);
            //Operation writeString
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString.SetName("writeString");
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeString);
            //Operation writeNewLine
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine.SetName("writeNewLine");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine.SetIsAbstract(true);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeNewLine);
            //Operation writeLine
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine.SetName("writeLine");
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine);
            //Operation writeInteger
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger.SetName("writeInteger");
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeInteger);
            //Operation writeReal
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal.SetName("writeReal");
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeReal);
            //Operation writeBoolean
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean.SetName("writeBoolean");
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeBoolean);
            //Operation writeUnlimitedNatural
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural.SetName("writeUnlimitedNatural");
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_TextOutputChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeUnlimitedNatural);

            //Activity WriteLine
            FoundationalModelLibrary_BasicInputOutput_WriteLine.SetName("WriteLine");
            FoundationalModelLibrary_BasicInputOutput_WriteLine.isReentrant = false;
            //Parameter value
            FoundationalModelLibrary_BasicInputOutput_WriteLine_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_WriteLine_value);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus);
            //ActivityParameterNode value
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_value.SetParameter(FoundationalModelLibrary_BasicInputOutput_WriteLine_value);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddNode(FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_value);
            //ActivityParameterNode errorStatus
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_errorStatus.SetParameter(FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddNode(FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_errorStatus);
            //ReadExtentAction StandardOutputChannel
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel.SetName("StandardOutputChannel");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel.SetClassifier(FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel);
            //OutputPin result
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel_result.SetName("result");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel_result.SetType(FoundationalModelLibrary_BasicInputOutput_StandardOutputChannel);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel_result.SetUpper(-1);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel.SetResult(FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel_result);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddNode(FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel);
            //CallOperationAction writeLine
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine.SetName("writeLine");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine.SetOperation(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel_writeLine);
            //InputPin target
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_target.SetName("target");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_target.SetType(FoundationalModelLibrary_BasicInputOutput_TextOutputChannel);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine.SetTarget(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_target);
            //InputPin value
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_value.SetName("value");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine.AddArgument(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_value);
            //OutputPin errorStatus
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine.AddResult(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddNode(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine);
            //ObjectFlow from value to writeLine_value
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_value_To_writeLine_value.SetName("From_value_To_writeLine_value");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_value_To_writeLine_value.SetSource(FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_value);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_value_To_writeLine_value.SetTarget(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_value);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddEdge(FoundationalModelLibrary_BasicInputOutput_WriteLine_From_value_To_writeLine_value);
            //ObjectFlow from StandardOutputChannel_result to writeLine_target
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_StandardOutputChannel_result_To_writeLine_target.SetName("From_StandardOutputChannel_result_To_writeLine_target");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_StandardOutputChannel_result_To_writeLine_target.SetSource(FoundationalModelLibrary_BasicInputOutput_WriteLine_ReadExtentAction_StandardOutputChannel_result);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_StandardOutputChannel_result_To_writeLine_target.SetTarget(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_target);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddEdge(FoundationalModelLibrary_BasicInputOutput_WriteLine_From_StandardOutputChannel_result_To_writeLine_target);
            //ObjectFlow from writeLine_errorStatus to errorStatus
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_writeLine_errorStatus_To_errorStatus.SetName("From_FoundationalModelLibrary_BasicInputOutput_WriteLine_errorStatus_To_errorStatus");
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_writeLine_errorStatus_To_errorStatus.SetSource(FoundationalModelLibrary_BasicInputOutput_WriteLine_CallOperationAction_writeLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_WriteLine_From_writeLine_errorStatus_To_errorStatus.SetTarget(FoundationalModelLibrary_BasicInputOutput_WriteLine_ActivityParameterNode_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_WriteLine.AddEdge(FoundationalModelLibrary_BasicInputOutput_WriteLine_From_writeLine_errorStatus_To_errorStatus);

            //Class ActiveChannel
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel.SetName("ActiveChannel");
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel.SetIsAbstract(true);
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel.SetIsActive(true);
            //Generalization to Channel
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_Generalization_Channel.SetGeneral(FoundationalModelLibrary_BasicInputOutput_Channel);
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel.AddGeneralization(FoundationalModelLibrary_BasicInputOutput_ActiveChannel_Generalization_Channel);
            //Operation register
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register.SetName("register");
            //Parameter listener
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register_listener.SetName("listener");
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register_listener.SetType(FoundationalModelLibrary_Common_Listener);
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register_listener);
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_ActiveChannel_register);
            //Operation unregister
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister.SetName("unregister");
            //Parameter listener
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister_listener.SetName("listener");
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister_listener.SetType(FoundationalModelLibrary_Common_Listener);
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister_listener);
            FoundationalModelLibrary_BasicInputOutput_ActiveChannel.AddOwnedOperation(FoundationalModelLibrary_BasicInputOutput_ActiveChannel_unregister);

            //Activity ReadLine
            FoundationalModelLibrary_BasicInputOutput_ReadLine.SetName("ReadLine");
            FoundationalModelLibrary_BasicInputOutput_ReadLine.isReentrant = false;
            //Parameter result
            FoundationalModelLibrary_BasicInputOutput_ReadLine_result.SetName("result");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_result.SetDirection(ParameterDirectionKind.return_);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_ReadLine_result);
            //Parameter errorStatus
            FoundationalModelLibrary_BasicInputOutput_ReadLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_errorStatus.SetDirection(ParameterDirectionKind.out_);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddOwnedParameter(FoundationalModelLibrary_BasicInputOutput_ReadLine_errorStatus);
            //ActivityParameterNode result
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_result.SetName("result");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_result.SetParameter(FoundationalModelLibrary_BasicInputOutput_ReadLine_result);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddNode(FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_result);
            //ActivityParameterNode errorStatus
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_errorStatus.SetParameter(FoundationalModelLibrary_BasicInputOutput_ReadLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddNode(FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_errorStatus);
            //ReadExtentAction StandardInputChannel
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel.SetName("StandardInputChannel");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel.SetClassifier(FoundationalModelLibrary_BasicInputOutput_StandardInputChannel);
            //OutputPin result
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel_result.SetName("result");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel_result.SetType(FoundationalModelLibrary_BasicInputOutput_StandardInputChannel);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel_result.SetUpper(-1);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel.SetResult(FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel_result);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddNode(FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel);
            //CallOperationAction readLine
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine.SetName("readLine");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine.SetOperation(FoundationalModelLibrary_BasicInputOutput_TextInputChannel_readLine);
            //InputPin target
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_target.SetName("target");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_target.SetType(FoundationalModelLibrary_BasicInputOutput_TextInputChannel);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine.SetTarget(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_target);
            //OutputPin result
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_result.SetName("result");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine.AddResult(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_result);
            //OutputPin errorStatus
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_errorStatus.SetName("errorStatus");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_errorStatus.SetType(FoundationalModelLibrary_Common_Status);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine.AddResult(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddNode(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine);
            //ObjectFlow from StandardInputChannel_result to readLine_target
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_StandardInputChannel_result_To_readLine_target.SetName("From_StandardInputChannel_result_To_readLine_target");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_StandardInputChannel_result_To_readLine_target.SetSource(FoundationalModelLibrary_BasicInputOutput_ReadLine_ReadExtentAction_StandardInputChannel_result);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_StandardInputChannel_result_To_readLine_target.SetTarget(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_target);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddEdge(FoundationalModelLibrary_BasicInputOutput_ReadLine_From_StandardInputChannel_result_To_readLine_target);
            //ObjectFlow from readLine_result to result
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_result_To_result.SetName("From_readLine_result_To_result");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_result_To_result.SetSource(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_result);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_result_To_result.SetTarget(FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_result);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddEdge(FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_result_To_result);
            //ObjectFlow from readLine_errorStatus to errorStatus
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_errorStatus_To_errorStatus.SetName("From_readline_errorStatus_To_errorStatus");
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_errorStatus_To_errorStatus.SetSource(FoundationalModelLibrary_BasicInputOutput_ReadLine_CallOperationAction_readLine_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_errorStatus_To_errorStatus.SetTarget(FoundationalModelLibrary_BasicInputOutput_ReadLine_ActivityParameterNode_errorStatus);
            FoundationalModelLibrary_BasicInputOutput_ReadLine.AddEdge(FoundationalModelLibrary_BasicInputOutput_ReadLine_From_readLine_errorStatus_To_errorStatus);
        }
    } // FoundationalModelLibraryModel
}
