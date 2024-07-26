namespace uml.statemachines
{
    public enum PseudoStateKind // PSSM-specific
    {
        initial,
        deepHistory,
        shallowHistory,
        join,
        fork,
        junction,
        choice,
        entryPoint,
        exitPoint,
        terminate
    } // PseudoStateKind
}
